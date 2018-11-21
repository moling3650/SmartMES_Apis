using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.WorkTool
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class WorkToolModelsController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkToolModelsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkToolModels
        [HttpGet]
        public IEnumerable<BWorkToolModel> GetBWorkToolModel([FromQuery] int? kindId)
        {
            if (kindId != null)
            {
                return _context.BWorkToolModel.Where(item => item.KindId == kindId);
            }
            return _context.BWorkToolModel;
        }

        // GET: api/WorkToolModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkToolModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolModel = await _context.BWorkToolModel.FindAsync(id);

            if (bWorkToolModel == null)
            {
                return NotFound();
            }

            return Ok(bWorkToolModel);
        }

        // GET: api/WorkToolModels/Validate?mouldCode=mCode
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string mouldCode)
        {
            if (String.IsNullOrWhiteSpace(mouldCode))
            {
                return false;
            }
            return !_context.BWorkToolModel.Any(e => e.ModelCode.Equals(mouldCode));
        }

        // PUT: api/WorkToolModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkToolModel([FromRoute] int id, [FromBody] BWorkToolModel bWorkToolModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkToolModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(bWorkToolModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkToolModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/WorkToolModels
        [HttpPost]
        public async Task<IActionResult> PostBWorkToolModel([FromBody] BWorkToolModel bWorkToolModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkToolModel.Add(bWorkToolModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkToolModel", new { id = bWorkToolModel.Id }, bWorkToolModel);
        }

        // DELETE: api/WorkToolModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkToolModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolModel = await _context.BWorkToolModel.FindAsync(id);
            if (bWorkToolModel == null)
            {
                return NotFound();
            }

            _context.BWorkToolModel.Remove(bWorkToolModel);
            await _context.SaveChangesAsync();

            return Ok(bWorkToolModel);
        }

        private bool BWorkToolModelExists(int id)
        {
            return _context.BWorkToolModel.Any(e => e.Id == id);
        }
    }
}
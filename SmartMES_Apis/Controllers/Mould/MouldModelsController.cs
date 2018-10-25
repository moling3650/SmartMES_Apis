using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Mould
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class MouldModelsController : ControllerBase
    {
        private readonly dbContext _context;

        public MouldModelsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MouldModels
        [HttpGet]
        public IEnumerable<BMouldModel> GetBMouldModel([FromQuery] int? kindId)
        {
            if (kindId != null)
            {
                return _context.BMouldModel.Where(item => item.KindId == kindId);
            }
            return _context.BMouldModel;
        }


        // GET: api/MouldModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMouldModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldModel = await _context.BMouldModel.FindAsync(id);

            if (bMouldModel == null)
            {
                return NotFound();
            }

            return Ok(bMouldModel);
        }

        // PUT: api/MouldModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMouldModel([FromRoute] int id, [FromBody] BMouldModel bMouldModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMouldModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMouldModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMouldModelExists(id))
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

        // POST: api/MouldModels
        [HttpPost]
        public async Task<IActionResult> PostBMouldModel([FromBody] BMouldModel bMouldModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMouldModel.Add(bMouldModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMouldModel", new { id = bMouldModel.Id }, bMouldModel);
        }

        // DELETE: api/MouldModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMouldModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldModel = await _context.BMouldModel.FindAsync(id);
            if (bMouldModel == null)
            {
                return NotFound();
            }

            _context.BMouldModel.Remove(bMouldModel);
            await _context.SaveChangesAsync();

            return Ok(bMouldModel);
        }

        private bool BMouldModelExists(int id)
        {
            return _context.BMouldModel.Any(e => e.Id == id);
        }
    }
}
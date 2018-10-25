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
    public class BWorkToolTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public BWorkToolTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/BWorkToolTypes
        [HttpGet]
        public IEnumerable<BWorkToolType> GetBWorkToolType()
        {
            return _context.BWorkToolType;
        }

        // GET: api/BWorkToolTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkToolType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolType = await _context.BWorkToolType.FindAsync(id);

            if (bWorkToolType == null)
            {
                return NotFound();
            }

            return Ok(bWorkToolType);
        }

        // PUT: api/BWorkToolTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkToolType([FromRoute] int id, [FromBody] BWorkToolType bWorkToolType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkToolType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bWorkToolType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkToolTypeExists(id))
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

        // POST: api/BWorkToolTypes
        [HttpPost]
        public async Task<IActionResult> PostBWorkToolType([FromBody] BWorkToolType bWorkToolType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkToolType.Add(bWorkToolType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkToolType", new { id = bWorkToolType.TypeId }, bWorkToolType);
        }

        // DELETE: api/BWorkToolTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkToolType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolType = await _context.BWorkToolType.FindAsync(id);
            if (bWorkToolType == null)
            {
                return NotFound();
            }

            _context.BWorkToolType.Remove(bWorkToolType);
            await _context.SaveChangesAsync();

            return Ok(bWorkToolType);
        }

        private bool BWorkToolTypeExists(int id)
        {
            return _context.BWorkToolType.Any(e => e.TypeId == id);
        }
    }
}
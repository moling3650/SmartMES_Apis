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
    public class WorkToolKindsController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkToolKindsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkToolKinds
        [HttpGet]
        public IEnumerable<BWorkToolKinds> GetBWorkToolKinds([FromQuery] int? typeId)
        {
            if (typeId != null)
            {
                return _context.BWorkToolKinds.Where(item => item.TypeId == typeId);
            }
            return _context.BWorkToolKinds;
        }

        // GET: api/WorkToolKinds/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkToolKinds([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolKinds = await _context.BWorkToolKinds.FindAsync(id);

            if (bWorkToolKinds == null)
            {
                return NotFound();
            }

            return Ok(bWorkToolKinds);
        }

        // PUT: api/WorkToolKinds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkToolKinds([FromRoute] int id, [FromBody] BWorkToolKinds bWorkToolKinds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkToolKinds.KindId)
            {
                return BadRequest();
            }

            _context.Entry(bWorkToolKinds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkToolKindsExists(id))
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

        // POST: api/WorkToolKinds
        [HttpPost]
        public async Task<IActionResult> PostBWorkToolKinds([FromBody] BWorkToolKinds bWorkToolKinds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkToolKinds.Add(bWorkToolKinds);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkToolKinds", new { id = bWorkToolKinds.KindId }, bWorkToolKinds);
        }

        // DELETE: api/WorkToolKinds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkToolKinds([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolKinds = await _context.BWorkToolKinds.FindAsync(id);
            if (bWorkToolKinds == null)
            {
                return NotFound();
            }

            _context.BWorkToolKinds.Remove(bWorkToolKinds);
            await _context.SaveChangesAsync();

            return Ok(bWorkToolKinds);
        }

        private bool BWorkToolKindsExists(int id)
        {
            return _context.BWorkToolKinds.Any(e => e.KindId == id);
        }
    }
}
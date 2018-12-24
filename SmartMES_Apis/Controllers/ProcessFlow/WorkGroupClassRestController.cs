using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.ProcessFlow
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class WorkGroupClassRestController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkGroupClassRestController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkGroupClassRest
        [HttpGet]
        public IEnumerable<BWorkGroupClassRest> GetBWorkGroupClassRest([FromQuery] int? classId)
        {
            if (classId != null)
            {
                return _context.BWorkGroupClassRest.Where(e => e.ClassId == classId);
            }
            return _context.BWorkGroupClassRest;
        }

        // GET: api/WorkGroupClassRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkGroupClassRest([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkGroupClassRest = await _context.BWorkGroupClassRest.FindAsync(id);

            if (bWorkGroupClassRest == null)
            {
                return NotFound();
            }

            return Ok(bWorkGroupClassRest);
        }

        // PUT: api/WorkGroupClassRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkGroupClassRest([FromRoute] int id, [FromBody] BWorkGroupClassRest bWorkGroupClassRest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkGroupClassRest.Id)
            {
                return BadRequest();
            }

            _context.Entry(bWorkGroupClassRest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkGroupClassRestExists(id))
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

        // POST: api/WorkGroupClassRest
        [HttpPost]
        public async Task<IActionResult> PostBWorkGroupClassRest([FromBody] BWorkGroupClassRest bWorkGroupClassRest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkGroupClassRest.Add(bWorkGroupClassRest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkGroupClassRest", new { id = bWorkGroupClassRest.Id }, bWorkGroupClassRest);
        }

        // DELETE: api/WorkGroupClassRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkGroupClassRest([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkGroupClassRest = await _context.BWorkGroupClassRest.FindAsync(id);
            if (bWorkGroupClassRest == null)
            {
                return NotFound();
            }

            _context.BWorkGroupClassRest.Remove(bWorkGroupClassRest);
            await _context.SaveChangesAsync();

            return Ok(bWorkGroupClassRest);
        }

        private bool BWorkGroupClassRestExists(int id)
        {
            return _context.BWorkGroupClassRest.Any(e => e.Id == id);
        }
    }
}
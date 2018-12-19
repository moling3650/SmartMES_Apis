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
    public class WorkGroupsController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkGroupsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkGroups
        [HttpGet]
        public IEnumerable<BWorkGroup> GetBWorkGroup()
        {
            return _context.BWorkGroup;
        }

        // GET: api/WorkGroups/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkGroup([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkGroup = await _context.BWorkGroup.FindAsync(id);

            if (bWorkGroup == null)
            {
                return NotFound();
            }

            return Ok(bWorkGroup);
        }

        // api/WorkGroups/Validate?groupCode=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string groupCode)
        {
            if (String.IsNullOrWhiteSpace(groupCode))
            {
                return false;
            }
            return !_context.BWorkGroup.Any(e => e.GroupCode.Equals(groupCode));
        }

        // PUT: api/WorkGroups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkGroup([FromRoute] int id, [FromBody] BWorkGroup bWorkGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(bWorkGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkGroupExists(id))
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

        // POST: api/WorkGroups
        [HttpPost]
        public async Task<IActionResult> PostBWorkGroup([FromBody] BWorkGroup bWorkGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkGroup.Add(bWorkGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkGroup", new { id = bWorkGroup.Id }, bWorkGroup);
        }

        // DELETE: api/WorkGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkGroup([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkGroup = await _context.BWorkGroup.FindAsync(id);
            if (bWorkGroup == null)
            {
                return NotFound();
            }

            _context.BWorkGroup.Remove(bWorkGroup);
            await _context.SaveChangesAsync();

            return Ok(bWorkGroup);
        }

        private bool BWorkGroupExists(int id)
        {
            return _context.BWorkGroup.Any(e => e.Id == id);
        }
    }
}
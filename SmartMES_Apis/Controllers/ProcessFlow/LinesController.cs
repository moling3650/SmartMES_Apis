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
    public class LinesController : ControllerBase
    {
        private readonly dbContext _context;

        public LinesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Lines
        [HttpGet]
        public IEnumerable<BLine> GetBLine([FromQuery] int? wsid)
        {
            if (wsid != null)
            {
                return _context.BLine.Where(e => e.Wsid == wsid);
            }
            return _context.BLine;
        }

        // GET: api/Lines/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBLine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bLine = await _context.BLine.FindAsync(id);

            if (bLine == null)
            {
                return NotFound();
            }

            return Ok(bLine);
        }

        // PUT: api/Lines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBLine([FromRoute] int id, [FromBody] BLine bLine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bLine.LineId)
            {
                return BadRequest();
            }

            _context.Entry(bLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BLineExists(id))
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

        // POST: api/Lines
        [HttpPost]
        public async Task<IActionResult> PostBLine([FromBody] BLine bLine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BLine.Add(bLine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBLine", new { id = bLine.LineId }, bLine);
        }

        // DELETE: api/Lines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBLine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bLine = await _context.BLine.FindAsync(id);
            if (bLine == null)
            {
                return NotFound();
            }

            _context.BLine.Remove(bLine);
            await _context.SaveChangesAsync();

            return Ok(bLine);
        }

        private bool BLineExists(int id)
        {
            return _context.BLine.Any(e => e.LineId == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Quality
{
    [Route("api/[controller]")]
    [ApiController]
    public class NgReasonsController : ControllerBase
    {
        private readonly dbContext _context;

        public NgReasonsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/NgReasons
        [HttpGet]
        public IEnumerable<BNgReason> GetBNgReason([FromQuery] string typeCode)
        {
            if (!String.IsNullOrWhiteSpace(typeCode))
            {
                return _context.BNgReason.Where(e => e.TypeCode.Equals(typeCode));
            }
            return _context.BNgReason;
        }

        // GET: api/NgReasons/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBNgReason([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bNgReason = await _context.BNgReason.FindAsync(id);

            if (bNgReason == null)
            {
                return NotFound();
            }

            return Ok(bNgReason);
        }

        // PUT: api/NgReasons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBNgReason([FromRoute] int id, [FromBody] BNgReason bNgReason)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bNgReason.Id)
            {
                return BadRequest();
            }

            _context.Entry(bNgReason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BNgReasonExists(id))
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

        // api/NgReasons/Validate?ngCode=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string reasonCode)
        {
            if (String.IsNullOrWhiteSpace(reasonCode))
            {
                return false;
            }
            return !_context.BNgReason.Any(e => e.ReasonCode.Equals(reasonCode));
        }

        // POST: api/NgReasons
        [HttpPost]
        public async Task<IActionResult> PostBNgReason([FromBody] BNgReason bNgReason)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BNgReason.Add(bNgReason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBNgReason", new { id = bNgReason.Id }, bNgReason);
        }

        // DELETE: api/NgReasons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBNgReason([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bNgReason = await _context.BNgReason.FindAsync(id);
            if (bNgReason == null)
            {
                return NotFound();
            }

            _context.BNgReason.Remove(bNgReason);
            await _context.SaveChangesAsync();

            return Ok(bNgReason);
        }

        private bool BNgReasonExists(int id)
        {
            return _context.BNgReason.Any(e => e.Id == id);
        }
    }
}
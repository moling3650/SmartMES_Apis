using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class MatSubstitutesController : ControllerBase
    {
        private readonly dbContext _context;

        public MatSubstitutesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MatSubstitutes
        [HttpGet]
        public IEnumerable<BMatSubstitute> GetBMatSubstitute([FromQuery] string bomCode, [FromQuery] string matCode)
        {
            var list = _context.BMatSubstitute.AsNoTracking();
            if (!String.IsNullOrWhiteSpace(bomCode))
            {
                list = list.Where(e => e.BomCode.Equals(bomCode));
            }
            if (!String.IsNullOrWhiteSpace(matCode))
            {
                list = list.Where(e => e.MatCode.Equals(matCode));
            }
            return list;
        }

        // GET: api/MatSubstitutes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMatSubstitute([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMatSubstitute = await _context.BMatSubstitute.FindAsync(id);

            if (bMatSubstitute == null)
            {
                return NotFound();
            }

            return Ok(bMatSubstitute);
        }

        // PUT: api/MatSubstitutes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMatSubstitute([FromRoute] int id, [FromBody] BMatSubstitute bMatSubstitute)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMatSubstitute.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMatSubstitute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMatSubstituteExists(id))
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

        // POST: api/MatSubstitutes
        [HttpPost]
        public async Task<IActionResult> PostBMatSubstitute([FromBody] BMatSubstitute bMatSubstitute)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMatSubstitute.Add(bMatSubstitute);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMatSubstitute", new { id = bMatSubstitute.Id }, bMatSubstitute);
        }

        // DELETE: api/MatSubstitutes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMatSubstitute([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMatSubstitute = await _context.BMatSubstitute.FindAsync(id);
            if (bMatSubstitute == null)
            {
                return NotFound();
            }

            _context.BMatSubstitute.Remove(bMatSubstitute);
            await _context.SaveChangesAsync();

            return Ok(bMatSubstitute);
        }

        private bool BMatSubstituteExists(int id)
        {
            return _context.BMatSubstitute.Any(e => e.Id == id);
        }
    }
}
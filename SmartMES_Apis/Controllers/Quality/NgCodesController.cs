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
    public class NgCodesController : ControllerBase
    {
        private readonly dbContext _context;

        public NgCodesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/NgCodes
        [HttpGet]
        public IEnumerable<BNgCode> GetBNgCode([FromQuery] string productType)
        {
            if (!String.IsNullOrWhiteSpace(productType))
            {
                return _context.BNgCode.Where(e => e.ProductType.Equals(productType));
            }
            return _context.BNgCode;
        }

        // GET: api/NgCodes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBNgCode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bNgCode = await _context.BNgCode.FindAsync(id);

            if (bNgCode == null)
            {
                return NotFound();
            }

            return Ok(bNgCode);
        }

        // api/NgCodes/Validate?ngCode=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string ngCode)
        {
            if (String.IsNullOrWhiteSpace(ngCode))
            {
                return false;
            }
            return !_context.BNgCode.Any(e => e.NgCode.Equals(ngCode));
        }

        // PUT: api/NgCodes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBNgCode([FromRoute] int id, [FromBody] BNgCode bNgCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bNgCode.NgId)
            {
                return BadRequest();
            }

            _context.Entry(bNgCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BNgCodeExists(id))
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

        // POST: api/NgCodes
        [HttpPost]
        public async Task<IActionResult> PostBNgCode([FromBody] BNgCode bNgCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BNgCode.Add(bNgCode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBNgCode", new { id = bNgCode.NgId }, bNgCode);
        }

        // DELETE: api/NgCodes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBNgCode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bNgCode = await _context.BNgCode.FindAsync(id);
            if (bNgCode == null)
            {
                return NotFound();
            }

            _context.BNgCode.Remove(bNgCode);
            await _context.SaveChangesAsync();

            return Ok(bNgCode);
        }

        private bool BNgCodeExists(int id)
        {
            return _context.BNgCode.Any(e => e.NgId == id);
        }
    }
}
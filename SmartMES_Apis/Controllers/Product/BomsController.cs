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
    public class BomsController : ControllerBase
    {
        private readonly dbContext _context;

        public BomsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Boms
        [HttpGet]
        public IEnumerable<BBom> GetBBom([FromQuery] string productCode)
        {
            if (!String.IsNullOrWhiteSpace(productCode))
            {
                return _context.BBom.Where(e => e.ProductCode.Equals(productCode));
            }
            return _context.BBom;
        }

        // GET: api/Boms/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBBom([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bBom = await _context.BBom.FindAsync(id);

            if (bBom == null)
            {
                return NotFound();
            }

            return Ok(bBom);
        }

        // api/Boms/Validate?bomCode=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string bomCode)
        {
            if (String.IsNullOrWhiteSpace(bomCode))
            {
                return false;
            }
            return !_context.BBom.Any(e => e.BomCode.Equals(bomCode));
        }

        // PUT: api/Boms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBBom([FromRoute] int id, [FromBody] BBom bBom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bBom.BomId)
            {
                return BadRequest();
            }

            _context.Entry(bBom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BBomExists(id))
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

        // POST: api/Boms
        [HttpPost]
        public async Task<IActionResult> PostBBom([FromBody] BBom bBom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BBom.Add(bBom);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBBom", new { id = bBom.BomId }, bBom);
        }

        // DELETE: api/Boms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBBom([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bBom = await _context.BBom.FindAsync(id);
            if (bBom == null)
            {
                return NotFound();
            }

            _context.BBom.Remove(bBom);
            await _context.SaveChangesAsync();

            return Ok(bBom);
        }

        private bool BBomExists(int id)
        {
            return _context.BBom.Any(e => e.BomId == id);
        }
    }
}
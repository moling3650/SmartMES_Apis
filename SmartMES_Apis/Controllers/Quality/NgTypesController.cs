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
    public class NgTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public NgTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/NgTypes
        [HttpGet]
        public IEnumerable<BNgType> GetBNgType()
        {
            return _context.BNgType;
        }

        // GET: api/NgTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBNgType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bNgType = await _context.BNgType.FindAsync(id);

            if (bNgType == null)
            {
                return NotFound();
            }

            return Ok(bNgType);
        }

        // api/NgTypes/Validate?typeCode=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string typeCode)
        {
            if (String.IsNullOrWhiteSpace(typeCode))
            {
                return false;
            }
            return !_context.BNgType.Any(e => e.TypeCode.Equals(typeCode));
        }

        // PUT: api/NgTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBNgType([FromRoute] int id, [FromBody] BNgType bNgType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bNgType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bNgType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BNgTypeExists(id))
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

        // POST: api/NgTypes
        [HttpPost]
        public async Task<IActionResult> PostBNgType([FromBody] BNgType bNgType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BNgType.Add(bNgType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBNgType", new { id = bNgType.TypeId }, bNgType);
        }

        // DELETE: api/NgTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBNgType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bNgType = await _context.BNgType.FindAsync(id);
            if (bNgType == null)
            {
                return NotFound();
            }

            _context.BNgType.Remove(bNgType);
            await _context.SaveChangesAsync();

            return Ok(bNgType);
        }

        private bool BNgTypeExists(int id)
        {
            return _context.BNgType.Any(e => e.TypeId == id);
        }
    }
}
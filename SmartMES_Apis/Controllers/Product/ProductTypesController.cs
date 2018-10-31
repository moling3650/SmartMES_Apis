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
    public class ProductTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public ProductTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProductTypes
        [HttpGet]
        public IEnumerable<BProductType> GetBProductType()
        {
            return _context.BProductType;
        }

        // GET: api/ProductTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProductType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProductType = await _context.BProductType.FindAsync(id);

            if (bProductType == null)
            {
                return NotFound();
            }

            return Ok(bProductType);
        }

        // PUT: api/ProductTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProductType([FromRoute] int id, [FromBody] BProductType bProductType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProductType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bProductType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProductTypeExists(id))
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

        // POST: api/ProductTypes
        [HttpPost]
        public async Task<IActionResult> PostBProductType([FromBody] BProductType bProductType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProductType.Add(bProductType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProductType", new { id = bProductType.TypeId }, bProductType);
        }

        // DELETE: api/ProductTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProductType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProductType = await _context.BProductType.FindAsync(id);
            if (bProductType == null)
            {
                return NotFound();
            }

            _context.BProductType.Remove(bProductType);
            await _context.SaveChangesAsync();

            return Ok(bProductType);
        }

        private bool BProductTypeExists(int id)
        {
            return _context.BProductType.Any(e => e.TypeId == id);
        }
    }
}
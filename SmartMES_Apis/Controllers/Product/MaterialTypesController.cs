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
    public class MaterialTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public MaterialTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MaterialTypes
        [HttpGet]
        public IEnumerable<BMaterialType> GetBMaterialType()
        {
            return _context.BMaterialType;
        }

        // GET: api/MaterialTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMaterialType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMaterialType = await _context.BMaterialType.FindAsync(id);

            if (bMaterialType == null)
            {
                return NotFound();
            }

            return Ok(bMaterialType);
        }

        // PUT: api/MaterialTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMaterialType([FromRoute] int id, [FromBody] BMaterialType bMaterialType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMaterialType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bMaterialType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMaterialTypeExists(id))
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

        // POST: api/MaterialTypes
        [HttpPost]
        public async Task<IActionResult> PostBMaterialType([FromBody] BMaterialType bMaterialType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMaterialType.Add(bMaterialType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMaterialType", new { id = bMaterialType.TypeId }, bMaterialType);
        }

        // DELETE: api/MaterialTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMaterialType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMaterialType = await _context.BMaterialType.FindAsync(id);
            if (bMaterialType == null)
            {
                return NotFound();
            }

            _context.BMaterialType.Remove(bMaterialType);
            await _context.SaveChangesAsync();

            return Ok(bMaterialType);
        }

        private bool BMaterialTypeExists(int id)
        {
            return _context.BMaterialType.Any(e => e.TypeId == id);
        }
    }
}
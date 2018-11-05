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
    public class MaterialsController : ControllerBase
    {
        private readonly dbContext _context;

        public MaterialsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Materials
        [HttpGet]
        public IEnumerable<BMaterial> GetBMaterial()
        {
            return _context.BMaterial;
        }

        // GET: api/Materials/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMaterial([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMaterial = await _context.BMaterial.FindAsync(id);

            if (bMaterial == null)
            {
                return NotFound();
            }

            return Ok(bMaterial);
        }

        // PUT: api/Materials/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMaterial([FromRoute] int id, [FromBody] BMaterial bMaterial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMaterial.MatId)
            {
                return BadRequest();
            }

            _context.Entry(bMaterial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMaterialExists(id))
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

        // POST: api/Materials
        [HttpPost]
        public async Task<IActionResult> PostBMaterial([FromBody] BMaterial bMaterial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMaterial.Add(bMaterial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMaterial", new { id = bMaterial.MatId }, bMaterial);
        }

        // DELETE: api/Materials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMaterial([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMaterial = await _context.BMaterial.FindAsync(id);
            if (bMaterial == null)
            {
                return NotFound();
            }

            _context.BMaterial.Remove(bMaterial);
            await _context.SaveChangesAsync();

            return Ok(bMaterial);
        }

        private bool BMaterialExists(int id)
        {
            return _context.BMaterial.Any(e => e.MatId == id);
        }
    }
}
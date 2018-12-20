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
    public class ProductModelsController : ControllerBase
    {
        private readonly dbContext _context;

        public ProductModelsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProductModels
        [HttpGet]
        public IEnumerable<BProductModel> GetBProductModel()
        {
            return _context.BProductModel;
        }

        // GET: api/ProductModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProductModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProductModel = await _context.BProductModel.FindAsync(id);

            if (bProductModel == null)
            {
                return NotFound();
            }

            return Ok(bProductModel);
        }

        // api/ProductModels/Validate?modelCode=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string modelCode)
        {
            if (String.IsNullOrWhiteSpace(modelCode))
            {
                return false;
            }
            return !_context.BProductModel.Any(e => e.ModelCode.Equals(modelCode));
        }

        // PUT: api/ProductModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProductModel([FromRoute] int id, [FromBody] BProductModel bProductModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProductModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(bProductModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProductModelExists(id))
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

        // POST: api/ProductModels
        [HttpPost]
        public async Task<IActionResult> PostBProductModel([FromBody] BProductModel bProductModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProductModel.Add(bProductModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProductModel", new { id = bProductModel.Id }, bProductModel);
        }

        // DELETE: api/ProductModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProductModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProductModel = await _context.BProductModel.FindAsync(id);
            if (bProductModel == null)
            {
                return NotFound();
            }

            _context.BProductModel.Remove(bProductModel);
            await _context.SaveChangesAsync();

            return Ok(bProductModel);
        }

        private bool BProductModelExists(int id)
        {
            return _context.BProductModel.Any(e => e.Id == id);
        }
    }
}
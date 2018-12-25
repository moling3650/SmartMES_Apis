using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.System
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class DataTranslationsController : ControllerBase
    {
        private readonly dbContext _context;

        public DataTranslationsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/DataTranslations
        [HttpGet]
        public IEnumerable<BDataTranslation> GetBDataTranslation()
        {
            return _context.BDataTranslation;
        }

        // GET: api/DataTranslations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBDataTranslation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bDataTranslation = await _context.BDataTranslation.FindAsync(id);

            if (bDataTranslation == null)
            {
                return NotFound();
            }

            return Ok(bDataTranslation);
        }

        // PUT: api/DataTranslations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBDataTranslation([FromRoute] int id, [FromBody] BDataTranslation bDataTranslation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bDataTranslation.Id)
            {
                return BadRequest();
            }

            _context.Entry(bDataTranslation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BDataTranslationExists(id))
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

        // POST: api/DataTranslations
        [HttpPost]
        public async Task<IActionResult> PostBDataTranslation([FromBody] BDataTranslation bDataTranslation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BDataTranslation.Add(bDataTranslation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBDataTranslation", new { id = bDataTranslation.Id }, bDataTranslation);
        }

        // DELETE: api/DataTranslations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBDataTranslation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bDataTranslation = await _context.BDataTranslation.FindAsync(id);
            if (bDataTranslation == null)
            {
                return NotFound();
            }

            _context.BDataTranslation.Remove(bDataTranslation);
            await _context.SaveChangesAsync();

            return Ok(bDataTranslation);
        }

        private bool BDataTranslationExists(int id)
        {
            return _context.BDataTranslation.Any(e => e.Id == id);
        }
    }
}
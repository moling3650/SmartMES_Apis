using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Mould
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class MouldKindPropertiesController : ControllerBase
    {
        private readonly dbContext _context;

        public MouldKindPropertiesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MouldKindProperties
        [HttpGet]
        public IEnumerable<BMouldKindProperty> GetBMouldKindProperty([FromQuery] string modelCode, [FromQuery] int? kindId)
        {
            if (String.IsNullOrWhiteSpace(modelCode) && kindId == null)
            {
                return _context.BMouldKindProperty;
            }
            if (!String.IsNullOrWhiteSpace(modelCode))
            {
                kindId = _context.BMouldModel.Where(item => item.ModelCode.Equals(modelCode)).FirstOrDefault()?.KindId;
            }
            if (kindId != null)
            {
                return _context.BMouldKindProperty.Where(item => item.KindId == kindId);
            }
            else
            {
                return new List<BMouldKindProperty>();
            }
        }

        // GET: api/MouldKindProperties/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMouldKindProperty([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldKindProperty = await _context.BMouldKindProperty.FindAsync(id);

            if (bMouldKindProperty == null)
            {
                return NotFound();
            }

            return Ok(bMouldKindProperty);
        }

        // PUT: api/MouldKindProperties/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMouldKindProperty([FromRoute] int id, [FromBody] BMouldKindProperty bMouldKindProperty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMouldKindProperty.PptId)
            {
                return BadRequest();
            }

            var item = await _context.BMouldKindProperty.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            if (item.PptType != bMouldKindProperty.PptType)
            {
                var details = _context.BMouldPropertyDetail.Where(e => e.PptId == id);
                _context.BMouldPropertyDetail.RemoveRange(details);
            }
            item.PptName = bMouldKindProperty.PptName;
            item.PptType = bMouldKindProperty.PptType;
            item.Description = bMouldKindProperty.Description;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMouldKindPropertyExists(id))
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

        // POST: api/MouldKindProperties
        [HttpPost]
        public async Task<IActionResult> PostBMouldKindProperty([FromBody] BMouldKindProperty bMouldKindProperty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMouldKindProperty.Add(bMouldKindProperty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMouldKindProperty", new { id = bMouldKindProperty.PptId }, bMouldKindProperty);
        }

        // DELETE: api/MouldKindProperties/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMouldKindProperty([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldKindProperty = await _context.BMouldKindProperty.FindAsync(id);
            if (bMouldKindProperty == null)
            {
                return NotFound();
            }
            var details = _context.BMouldPropertyDetail.Where(e => e.PptId == id);
            _context.BMouldPropertyDetail.RemoveRange(details);

            _context.BMouldKindProperty.Remove(bMouldKindProperty);
            await _context.SaveChangesAsync();

            return Ok(bMouldKindProperty);
        }

        private bool BMouldKindPropertyExists(int id)
        {
            return _context.BMouldKindProperty.Any(e => e.PptId == id);
        }
    }
}
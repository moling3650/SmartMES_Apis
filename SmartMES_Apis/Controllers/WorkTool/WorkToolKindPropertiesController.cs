using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.WorkTool
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class WorkToolKindPropertiesController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkToolKindPropertiesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkToolKindProperties
        [HttpGet]
        public IEnumerable<BWorkToolKindProperty> GetBWorkToolKindProperty([FromQuery] string modelCode, [FromQuery] int? kindId)
        {
            if (String.IsNullOrWhiteSpace(modelCode) && kindId == null)
            {
                return _context.BWorkToolKindProperty;
            }
            if (!String.IsNullOrWhiteSpace(modelCode))
            {
                kindId = _context.BWorkToolModel.Where(item => item.ModelCode.Equals(modelCode)).FirstOrDefault()?.KindId;
            }
            if (kindId != null)
            {
                return _context.BWorkToolKindProperty.Where(item => item.KindId == kindId);
            }
            else
            {
                return new List<BWorkToolKindProperty>();
            }
        }

        // GET: api/WorkToolKindProperties/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkToolKindProperty([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolKindProperty = await _context.BWorkToolKindProperty.FindAsync(id);

            if (bWorkToolKindProperty == null)
            {
                return NotFound();
            }

            return Ok(bWorkToolKindProperty);
        }

        // PUT: api/WorkToolKindProperties/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkToolKindProperty([FromRoute] int id, [FromBody] BWorkToolKindProperty bWorkToolKindProperty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkToolKindProperty.PptId)
            {
                return BadRequest();
            }

            _context.Entry(bWorkToolKindProperty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkToolKindPropertyExists(id))
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

        // POST: api/WorkToolKindProperties
        [HttpPost]
        public async Task<IActionResult> PostBWorkToolKindProperty([FromBody] BWorkToolKindProperty bWorkToolKindProperty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkToolKindProperty.Add(bWorkToolKindProperty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkToolKindProperty", new { id = bWorkToolKindProperty.PptId }, bWorkToolKindProperty);
        }

        // DELETE: api/WorkToolKindProperties/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkToolKindProperty([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolKindProperty = await _context.BWorkToolKindProperty.FindAsync(id);
            if (bWorkToolKindProperty == null)
            {
                return NotFound();
            }

            _context.BWorkToolKindProperty.Remove(bWorkToolKindProperty);
            await _context.SaveChangesAsync();

            return Ok(bWorkToolKindProperty);
        }

        private bool BWorkToolKindPropertyExists(int id)
        {
            return _context.BWorkToolKindProperty.Any(e => e.PptId == id);
        }
    }
}
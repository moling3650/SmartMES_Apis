using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Machine
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class PointTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public PointTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/PointTypes
        [HttpGet]
        public IEnumerable<BPointType> GetBPointType()
        {
            return _context.BPointType;
        }

        // GET: api/PointTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBPointType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bPointType = await _context.BPointType.FindAsync(id);

            if (bPointType == null)
            {
                return NotFound();
            }

            return Ok(bPointType);
        }

        // PUT: api/PointTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBPointType([FromRoute] int id, [FromBody] BPointType bPointType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bPointType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bPointType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BPointTypeExists(id))
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

        // POST: api/PointTypes
        [HttpPost]
        public async Task<IActionResult> PostBPointType([FromBody] BPointType bPointType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BPointType.Add(bPointType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBPointType", new { id = bPointType.TypeId }, bPointType);
        }

        // DELETE: api/PointTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBPointType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bPointType = await _context.BPointType.FindAsync(id);
            if (bPointType == null)
            {
                return NotFound();
            }

            _context.BPointType.Remove(bPointType);
            await _context.SaveChangesAsync();

            return Ok(bPointType);
        }

        private bool BPointTypeExists(int id)
        {
            return _context.BPointType.Any(e => e.TypeId == id);
        }
    }
}
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
    public class MouldTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public MouldTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MouldTypes
        [HttpGet]
        public IEnumerable<BMouldType> GetBMouldType()
        {
            return _context.BMouldType;
        }

        // GET: api/MouldTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMouldType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldType = await _context.BMouldType.FindAsync(id);

            if (bMouldType == null)
            {
                return NotFound();
            }

            return Ok(bMouldType);
        }

        // PUT: api/MouldTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMouldType([FromRoute] int id, [FromBody] BMouldType bMouldType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMouldType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bMouldType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMouldTypeExists(id))
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

        // POST: api/MouldTypes
        [HttpPost]
        public async Task<IActionResult> PostBMouldType([FromBody] BMouldType bMouldType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMouldType.Add(bMouldType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMouldType", new { id = bMouldType.TypeId }, bMouldType);
        }

        // DELETE: api/MouldTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMouldType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldType = await _context.BMouldType.FindAsync(id);
            if (bMouldType == null)
            {
                return NotFound();
            }

            _context.BMouldType.Remove(bMouldType);
            await _context.SaveChangesAsync();

            return Ok(bMouldType);
        }

        private bool BMouldTypeExists(int id)
        {
            return _context.BMouldType.Any(e => e.TypeId == id);
        }
    }
}
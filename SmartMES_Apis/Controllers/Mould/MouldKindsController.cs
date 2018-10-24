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
    public class MouldKindsController : ControllerBase
    {
        private readonly dbContext _context;

        public MouldKindsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MouldKinds
        [HttpGet]
        public IEnumerable<BMouldKinds> GetBMouldKinds()
        {
            return _context.BMouldKinds;
        }

        // GET: api/MouldKinds/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMouldKinds([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldKinds = await _context.BMouldKinds.FindAsync(id);

            if (bMouldKinds == null)
            {
                return NotFound();
            }

            return Ok(bMouldKinds);
        }

        // PUT: api/MouldKinds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMouldKinds([FromRoute] int id, [FromBody] BMouldKinds bMouldKinds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMouldKinds.KindId)
            {
                return BadRequest();
            }

            _context.Entry(bMouldKinds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMouldKindsExists(id))
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

        // POST: api/MouldKinds
        [HttpPost]
        public async Task<IActionResult> PostBMouldKinds([FromBody] BMouldKinds bMouldKinds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMouldKinds.Add(bMouldKinds);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMouldKinds", new { id = bMouldKinds.KindId }, bMouldKinds);
        }

        // DELETE: api/MouldKinds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMouldKinds([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldKinds = await _context.BMouldKinds.FindAsync(id);
            if (bMouldKinds == null)
            {
                return NotFound();
            }

            _context.BMouldKinds.Remove(bMouldKinds);
            await _context.SaveChangesAsync();

            return Ok(bMouldKinds);
        }

        private bool BMouldKindsExists(int id)
        {
            return _context.BMouldKinds.Any(e => e.KindId == id);
        }
    }
}
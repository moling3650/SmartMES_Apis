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
    public class MouldCavitiesController : ControllerBase
    {
        private readonly dbContext _context;

        public MouldCavitiesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MouldCavities
        [HttpGet]
        public IEnumerable<BMouldCavity> GetBMouldCavity()
        {
            return _context.BMouldCavity;
        }

        // GET: api/MouldCavities/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMouldCavity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldCavity = await _context.BMouldCavity.FindAsync(id);

            if (bMouldCavity == null)
            {
                return NotFound();
            }

            return Ok(bMouldCavity);
        }

        // PUT: api/MouldCavities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMouldCavity([FromRoute] int id, [FromBody] BMouldCavity bMouldCavity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMouldCavity.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMouldCavity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMouldCavityExists(id))
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

        // POST: api/MouldCavities
        [HttpPost]
        public async Task<IActionResult> PostBMouldCavity([FromBody] BMouldCavity bMouldCavity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMouldCavity.Add(bMouldCavity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMouldCavity", new { id = bMouldCavity.Id }, bMouldCavity);
        }

        // DELETE: api/MouldCavities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMouldCavity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldCavity = await _context.BMouldCavity.FindAsync(id);
            if (bMouldCavity == null)
            {
                return NotFound();
            }

            _context.BMouldCavity.Remove(bMouldCavity);
            await _context.SaveChangesAsync();

            return Ok(bMouldCavity);
        }

        private bool BMouldCavityExists(int id)
        {
            return _context.BMouldCavity.Any(e => e.Id == id);
        }
    }
}
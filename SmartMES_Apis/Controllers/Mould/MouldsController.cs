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
    public class MouldsController : ControllerBase
    {
        private readonly dbContext _context;

        public MouldsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Moulds
        [HttpGet]
        public IEnumerable<BMoulds> GetBMoulds([FromQuery] string modelCode)
        {
            if (!String.IsNullOrEmpty(modelCode))
            {
                return _context.BMoulds.Where(item => item.ModelCode.Equals(modelCode));
            }
            return _context.BMoulds;
        }

        // GET: api/Moulds/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMoulds([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMoulds = await _context.BMoulds.FindAsync(id);

            if (bMoulds == null)
            {
                return NotFound();
            }

            return Ok(bMoulds);
        }

        // PUT: api/Moulds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMoulds([FromRoute] int id, [FromBody] BMoulds bMoulds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMoulds.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMoulds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMouldsExists(id))
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

        // POST: api/Moulds
        [HttpPost]
        public async Task<IActionResult> PostBMoulds([FromBody] BMoulds bMoulds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMoulds.Add(bMoulds);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMoulds", new { id = bMoulds.Id }, bMoulds);
        }

        // DELETE: api/Moulds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMoulds([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMoulds = await _context.BMoulds.FindAsync(id);
            if (bMoulds == null)
            {
                return NotFound();
            }

            _context.BMoulds.Remove(bMoulds);
            await _context.SaveChangesAsync();

            return Ok(bMoulds);
        }

        private bool BMouldsExists(int id)
        {
            return _context.BMoulds.Any(e => e.Id == id);
        }
    }
}
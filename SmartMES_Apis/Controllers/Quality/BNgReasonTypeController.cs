using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Quality
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class BNgReasonTypeController : ControllerBase
    {
        private readonly dbContext _context;

        public BNgReasonTypeController(dbContext context)
        {
            _context = context;
        }

        // GET: api/BNgReasonType
        [HttpGet]
        public IEnumerable<BNgReasonType> GetBNgReasonType()
        {
            return _context.BNgReasonType;
        }

        // GET: api/BNgReasonType/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBNgReasonType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bNgReasonType = await _context.BNgReasonType.FindAsync(id);

            if (bNgReasonType == null)
            {
                return NotFound();
            }

            return Ok(bNgReasonType);
        }

        // PUT: api/BNgReasonType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBNgReasonType([FromRoute] int id, [FromBody] BNgReasonType bNgReasonType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bNgReasonType.ReasonTypeId)
            {
                return BadRequest();
            }

            _context.Entry(bNgReasonType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BNgReasonTypeExists(id))
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

        // POST: api/BNgReasonType
        [HttpPost]
        public async Task<IActionResult> PostBNgReasonType([FromBody] BNgReasonType bNgReasonType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BNgReasonType.Add(bNgReasonType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBNgReasonType", new { id = bNgReasonType.ReasonTypeId }, bNgReasonType);
        }

        // DELETE: api/BNgReasonType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBNgReasonType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bNgReasonType = await _context.BNgReasonType.FindAsync(id);
            if (bNgReasonType == null)
            {
                return NotFound();
            }

            _context.BNgReasonType.Remove(bNgReasonType);
            await _context.SaveChangesAsync();

            return Ok(bNgReasonType);
        }

        private bool BNgReasonTypeExists(int id)
        {
            return _context.BNgReasonType.Any(e => e.ReasonTypeId == id);
        }
    }
}
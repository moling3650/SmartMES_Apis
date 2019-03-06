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
    public class PFailDetailController : ControllerBase
    {
        private readonly dbContext _context;

        public PFailDetailController(dbContext context)
        {
            _context = context;
        }

        // GET: api/PFailDetail
        [HttpGet]
        public IEnumerable<PFailDetail> GetPFailDetail([FromQuery] string sfc)
        {
            if (!String.IsNullOrWhiteSpace(sfc))
            {
                return _context.PFailDetail.Where(e => e.Sfc.Equals(sfc));
            }
            return _context.PFailDetail;
        }

        // GET: api/PFailDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPFailDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pFailDetail = await _context.PFailDetail.FindAsync(id);

            if (pFailDetail == null)
            {
                return NotFound();
            }

            return Ok(pFailDetail);
        }

        // PUT: api/PFailDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPFailDetail([FromRoute] int id, [FromBody] PFailDetail pFailDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pFailDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(pFailDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PFailDetailExists(id))
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

        // POST: api/PFailDetail
        [HttpPost]
        public async Task<IActionResult> PostPFailDetail([FromBody] PFailDetail pFailDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PFailDetail.Add(pFailDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPFailDetail", new { id = pFailDetail.Id }, pFailDetail);
        }

        // DELETE: api/PFailDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePFailDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pFailDetail = await _context.PFailDetail.FindAsync(id);
            if (pFailDetail == null)
            {
                return NotFound();
            }

            _context.PFailDetail.Remove(pFailDetail);
            await _context.SaveChangesAsync();

            return Ok(pFailDetail);
        }

        private bool PFailDetailExists(int id)
        {
            return _context.PFailDetail.Any(e => e.Id == id);
        }
    }
}
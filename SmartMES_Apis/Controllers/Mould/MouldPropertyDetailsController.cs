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
    public class MouldPropertyDetailsController : ControllerBase
    {
        private readonly dbContext _context;

        public MouldPropertyDetailsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MouldPropertyDetails
        [HttpGet]
        public IEnumerable<BMouldPropertyDetail> GetBMouldPropertyDetail([FromQuery] string mouldCode )
        {
            if (!String.IsNullOrWhiteSpace(mouldCode))
            {
                return _context.BMouldPropertyDetail.Where(item => item.MouldCode.Equals(mouldCode));
            }
            return _context.BMouldPropertyDetail;
        }

        // GET: api/MouldPropertyDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMouldPropertyDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldPropertyDetail = await _context.BMouldPropertyDetail.FindAsync(id);

            if (bMouldPropertyDetail == null)
            {
                return NotFound();
            }

            return Ok(bMouldPropertyDetail);
        }

        // PUT: api/MouldPropertyDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMouldPropertyDetail([FromRoute] int id, [FromBody] BMouldPropertyDetail bMouldPropertyDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMouldPropertyDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMouldPropertyDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMouldPropertyDetailExists(id))
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

        // POST: api/MouldPropertyDetails
        [HttpPost]
        public async Task<IActionResult> PostBMouldPropertyDetail([FromBody] BMouldPropertyDetail bMouldPropertyDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMouldPropertyDetail.Add(bMouldPropertyDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMouldPropertyDetail", new { id = bMouldPropertyDetail.Id }, bMouldPropertyDetail);
        }

        // DELETE: api/MouldPropertyDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMouldPropertyDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMouldPropertyDetail = await _context.BMouldPropertyDetail.FindAsync(id);
            if (bMouldPropertyDetail == null)
            {
                return NotFound();
            }

            _context.BMouldPropertyDetail.Remove(bMouldPropertyDetail);
            await _context.SaveChangesAsync();

            return Ok(bMouldPropertyDetail);
        }

        private bool BMouldPropertyDetailExists(int id)
        {
            return _context.BMouldPropertyDetail.Any(e => e.Id == id);
        }
    }
}
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
    public class WorkToolPropertyDetailsController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkToolPropertyDetailsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkToolPropertyDetails
        [HttpGet]
        public IEnumerable<BWorkToolPropertyDetail> GetBWorkToolPropertyDetail([FromQuery] string workToolCode)
        {
            if (!String.IsNullOrWhiteSpace(workToolCode))
            {
                return _context.BWorkToolPropertyDetail.Where(item => item.WorkToolCode.Equals(workToolCode));
            }
            return _context.BWorkToolPropertyDetail;
        }

        // GET: api/WorkToolPropertyDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkToolPropertyDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolPropertyDetail = await _context.BWorkToolPropertyDetail.FindAsync(id);

            if (bWorkToolPropertyDetail == null)
            {
                return NotFound();
            }

            return Ok(bWorkToolPropertyDetail);
        }

        // PUT: api/WorkToolPropertyDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkToolPropertyDetail([FromRoute] int id, [FromBody] BWorkToolPropertyDetail bWorkToolPropertyDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkToolPropertyDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(bWorkToolPropertyDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkToolPropertyDetailExists(id))
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

        // POST: api/WorkToolPropertyDetails
        [HttpPost]
        public async Task<IActionResult> PostBWorkToolPropertyDetail([FromBody] BWorkToolPropertyDetail bWorkToolPropertyDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkToolPropertyDetail.Add(bWorkToolPropertyDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkToolPropertyDetail", new { id = bWorkToolPropertyDetail.Id }, bWorkToolPropertyDetail);
        }

        // DELETE: api/WorkToolPropertyDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkToolPropertyDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkToolPropertyDetail = await _context.BWorkToolPropertyDetail.FindAsync(id);
            if (bWorkToolPropertyDetail == null)
            {
                return NotFound();
            }

            _context.BWorkToolPropertyDetail.Remove(bWorkToolPropertyDetail);
            await _context.SaveChangesAsync();

            return Ok(bWorkToolPropertyDetail);
        }

        private bool BWorkToolPropertyDetailExists(int id)
        {
            return _context.BWorkToolPropertyDetail.Any(e => e.Id == id);
        }
    }
}
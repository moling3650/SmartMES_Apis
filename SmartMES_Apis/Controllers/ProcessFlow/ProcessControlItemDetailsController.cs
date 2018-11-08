using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.ProcessFlow
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class ProcessControlItemDetailsController : ControllerBase
    {
        private readonly dbContext _context;

        public ProcessControlItemDetailsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProcessControlItemDetails
        [HttpGet]
        public IEnumerable<BProcessControlItemDetail> GetBProcessControlItemDetail([FromQuery] int? pid)
        {
            if (pid != null)
            {
                return _context.BProcessControlItemDetail.Where(e => e.Pid == pid);
            }
            return _context.BProcessControlItemDetail;
        }

        // GET: api/ProcessControlItemDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProcessControlItemDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessControlItemDetail = await _context.BProcessControlItemDetail.FindAsync(id);

            if (bProcessControlItemDetail == null)
            {
                return NotFound();
            }

            return Ok(bProcessControlItemDetail);
        }

        // PUT: api/ProcessControlItemDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProcessControlItemDetail([FromRoute] int id, [FromBody] BProcessControlItemDetail bProcessControlItemDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProcessControlItemDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(bProcessControlItemDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProcessControlItemDetailExists(id))
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

        // POST: api/ProcessControlItemDetails
        [HttpPost]
        public async Task<IActionResult> PostBProcessControlItemDetail([FromBody] BProcessControlItemDetail bProcessControlItemDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProcessControlItemDetail.Add(bProcessControlItemDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProcessControlItemDetail", new { id = bProcessControlItemDetail.Id }, bProcessControlItemDetail);
        }

        // DELETE: api/ProcessControlItemDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProcessControlItemDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessControlItemDetail = await _context.BProcessControlItemDetail.FindAsync(id);
            if (bProcessControlItemDetail == null)
            {
                return NotFound();
            }

            _context.BProcessControlItemDetail.Remove(bProcessControlItemDetail);
            await _context.SaveChangesAsync();

            return Ok(bProcessControlItemDetail);
        }

        private bool BProcessControlItemDetailExists(int id)
        {
            return _context.BProcessControlItemDetail.Any(e => e.Id == id);
        }
    }
}
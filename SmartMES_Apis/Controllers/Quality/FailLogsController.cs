using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Quality
{
    [Route("api/[controller]")]
    [ApiController]
    public class FailLogsController : ControllerBase
    {
        private readonly dbContext _context;

        public FailLogsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/FailLogs
        [HttpGet]
        public IEnumerable<PFailLog> GetPFailLog([FromQuery] string sfc)
        {
            if (!String.IsNullOrWhiteSpace(sfc))
            {
                return _context.PFailLog.Where(e => e.Sfc.Equals(sfc));
            }
            return _context.PFailLog;
        }

        // GET: api/FailLogs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPFailLog([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pFailLog = await _context.PFailLog.FindAsync(id);

            if (pFailLog == null)
            {
                return NotFound();
            }

            return Ok(pFailLog);
        }

        // PUT: api/FailLogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPFailLog([FromRoute] int id, [FromBody] PFailLog pFailLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pFailLog.Fid)
            {
                return BadRequest();
            }

            _context.Entry(pFailLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PFailLogExists(id))
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

        // POST: api/FailLogs
        [HttpPost]
        public async Task<IActionResult> PostPFailLog([FromBody] PFailLog pFailLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PFailLog.Add(pFailLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPFailLog", new { id = pFailLog.Fid }, pFailLog);
        }

        // DELETE: api/FailLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePFailLog([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pFailLog = await _context.PFailLog.FindAsync(id);
            if (pFailLog == null)
            {
                return NotFound();
            }

            _context.PFailLog.Remove(pFailLog);
            await _context.SaveChangesAsync();

            return Ok(pFailLog);
        }

        private bool PFailLogExists(int id)
        {
            return _context.PFailLog.Any(e => e.Fid == id);
        }
    }
}
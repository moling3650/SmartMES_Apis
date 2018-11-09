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
    public class ProcessListsController : ControllerBase
    {
        private readonly dbContext _context;

        public ProcessListsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProcessLists
        [HttpGet]
        public IEnumerable<BProcessList> GetBProcessList([FromQuery] string groupCode)
        {
            if (!String.IsNullOrWhiteSpace(groupCode))
            {
                return _context.BProcessList.AsNoTracking().Where(e => e.GroupCode.Equals(groupCode));
            }
            return _context.BProcessList;
        }

        // GET: api/ProcessLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProcessList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessList = await _context.BProcessList.FindAsync(id);

            if (bProcessList == null)
            {
                return NotFound();
            }

            return Ok(bProcessList);
        }

        // PUT: api/ProcessLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProcessList([FromRoute] int id, [FromBody] BProcessList bProcessList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProcessList.Processid)
            {
                return BadRequest();
            }

            _context.Entry(bProcessList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProcessListExists(id))
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

        // POST: api/ProcessLists
        [HttpPost]
        public async Task<IActionResult> PostBProcessList([FromBody] BProcessList bProcessList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProcessList.Add(bProcessList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProcessList", new { id = bProcessList.Processid }, bProcessList);
        }

        // DELETE: api/ProcessLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProcessList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessList = await _context.BProcessList.FindAsync(id);
            if (bProcessList == null)
            {
                return NotFound();
            }

            _context.BProcessList.Remove(bProcessList);
            await _context.SaveChangesAsync();

            return Ok(bProcessList);
        }

        private bool BProcessListExists(int id)
        {
            return _context.BProcessList.Any(e => e.Processid == id);
        }
    }
}
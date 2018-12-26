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
    public class WorkGroupClassesController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkGroupClassesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkGroupClasses
        [HttpGet]
        public IEnumerable<BWorkGroupClass> GetBWorkGroupClass([FromQuery] string groupCode)
        {
            if (!String.IsNullOrWhiteSpace(groupCode))
            {
                return _context.BWorkGroupClass.Where(e => e.GroupCode.Equals(groupCode));
            }
            return _context.BWorkGroupClass;
        }

        // GET: api/WorkGroupClasses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkGroupClass([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkGroupClass = await _context.BWorkGroupClass.FindAsync(id);

            if (bWorkGroupClass == null)
            {
                return NotFound();
            }

            return Ok(bWorkGroupClass);
        }

        // GET: api/WorkGroupClasses/WorkTime
        [HttpGet("WorkTime")]
        public IQueryable GetWorkTime([FromQuery] string groupCode)
        {
            return from c in _context.BWorkGroupClass
                   where c.GroupCode == groupCode
                   select new
                   {
                       c.ClassCode,
                       c.ClassName,
                       c.DayStart,
                       c.DayEnd,
                       c.TimeStart,
                       c.TimeEnd,
                       restTime = _context.BWorkGroupClassRest.Where(r => r.ClassId == c.Cid).OrderBy(r => r.TimeStart)
                   };
        }

        // PUT: api/WorkGroupClasses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkGroupClass([FromRoute] int id, [FromBody] BWorkGroupClass bWorkGroupClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkGroupClass.Cid)
            {
                return BadRequest();
            }

            _context.Entry(bWorkGroupClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkGroupClassExists(id))
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

        // POST: api/WorkGroupClasses
        [HttpPost]
        public async Task<IActionResult> PostBWorkGroupClass([FromBody] BWorkGroupClass bWorkGroupClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkGroupClass.Add(bWorkGroupClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkGroupClass", new { id = bWorkGroupClass.Cid }, bWorkGroupClass);
        }

        // DELETE: api/WorkGroupClasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkGroupClass([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkGroupClass = await _context.BWorkGroupClass.FindAsync(id);
            if (bWorkGroupClass == null)
            {
                return NotFound();
            }

            _context.BWorkGroupClass.Remove(bWorkGroupClass);
            await _context.SaveChangesAsync();

            return Ok(bWorkGroupClass);
        }

        private bool BWorkGroupClassExists(int id)
        {
            return _context.BWorkGroupClass.Any(e => e.Cid == id);
        }
    }
}
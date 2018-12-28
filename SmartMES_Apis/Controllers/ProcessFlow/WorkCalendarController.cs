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
    public class WorkCalendarController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkCalendarController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkCalendar
        [HttpGet]
        public IEnumerable<BWorkCalendar> GetBWorkCalendar([FromQuery] string groupCode, [FromQuery] DateTime month)
        {
            var monthStr = month.ToString("yyyy-MM");
            var list = _context.BWorkCalendar.AsNoTracking();
            if (!String.IsNullOrWhiteSpace(groupCode))
            {
                list = list.Where(e => e.GroupCode.Equals(groupCode));
            }
            if (!monthStr.Equals("0001-01"))
            {
                list = list.Where(e => e.Day.ToString("yyyy-MM").Equals(monthStr));
            }
            return list;
        }

        // GET: api/WorkCalendar/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkCalendar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkCalendar = await _context.BWorkCalendar.FindAsync(id);

            if (bWorkCalendar == null)
            {
                return NotFound();
            }

            return Ok(bWorkCalendar);
        }

        // GET: api/WorkCalendar/Months
        [HttpGet("Months")]
        public IQueryable GetMonths([FromQuery] string groupCode)
        {
            DateTime preYear = Convert.ToDateTime(DateTime.Now.AddYears(-1).ToString("yyyy") + "-01-01");
            DateTime nextYear = Convert.ToDateTime(DateTime.Now.AddYears(1).ToString("yyyy") + "-12-31");
            var months = _context.BWorkCalendar.Where(e => e.GroupCode.Equals(groupCode) && e.Day >= preYear && e.Day <= nextYear).Select(e => e.Day.ToString("yyyy-MM")).Distinct();
            return months;
        }

        // GET: api/WorkCalendar/Month/Validate
        [HttpGet("Month/Validate")]
        public bool ValidateMonth([FromQuery] string groupCode, [FromQuery] DateTime month)
        {
            if (DateTime.Now.ToString("yyyy-MM").Equals(month.ToString("yyyy-MM")))
            {
                return true;
            }
            DateTime preMonth = month.AddMonths(-1);
            return _context.BWorkCalendar.Any(e => e.GroupCode.Equals(groupCode) && e.Day >= preMonth && e.Day < month);
        }

        // PUT: api/WorkCalendar/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkCalendar([FromRoute] int id, [FromBody] BWorkCalendar bWorkCalendar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkCalendar.Id)
            {
                return BadRequest();
            }

            _context.Entry(bWorkCalendar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkCalendarExists(id))
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

        // POST: api/WorkCalendar
        [HttpPost]
        public async Task<IActionResult> PostBWorkCalendar([FromBody] BWorkCalendar bWorkCalendar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkCalendar.Add(bWorkCalendar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkCalendar", new { id = bWorkCalendar.Id }, bWorkCalendar);
        }

        // POST: api/WorkCalendar/List
        [HttpPost("List")]
        public async Task<IActionResult> PostBWorkCalendarList([FromBody] List<BWorkCalendar> wcList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkCalendar.AddRange(wcList);
            await _context.SaveChangesAsync();

            return Ok(wcList);
        }

        // DELETE: api/WorkCalendar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkCalendar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkCalendar = await _context.BWorkCalendar.FindAsync(id);
            if (bWorkCalendar == null)
            {
                return NotFound();
            }

            _context.BWorkCalendar.Remove(bWorkCalendar);
            await _context.SaveChangesAsync();

            return Ok(bWorkCalendar);
        }

        private bool BWorkCalendarExists(int id)
        {
            return _context.BWorkCalendar.Any(e => e.Id == id);
        }
    }
}
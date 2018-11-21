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
    public class StationListsController : ControllerBase
    {
        private readonly dbContext _context;

        public StationListsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/StationLists
        [HttpGet]
        public IEnumerable<BStationList> GetBStationList()
        {
            return _context.BStationList;
        }

        // GET: api/StationLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBStationList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bStationList = await _context.BStationList.FindAsync(id);

            if (bStationList == null)
            {
                return NotFound();
            }

            return Ok(bStationList);
        }

        // api/StationLists/CascaderOptions
        [HttpGet("CascaderOptions")]
        public IQueryable GetCascaderOptions([FromQuery] string ip)
        {
            var stations = _context.BStationList.ToList();
            if (!String.IsNullOrWhiteSpace(ip))
            {
                stations = stations.Where(e => e.IpAddress.Equals(ip)).ToList();
            }
            return _context.BProcessList
                .GroupJoin(stations, p => p.ProcessCode, s => s.ProcessCode, (p, sList) => new { value = p.ProcessCode, label = p.ProcessName, children = sList.Select(s => new { value = s.StationCode, label = s.StationName }) })
                .Where(p => p.children.Count() > 0);
        }

        // PUT: api/StationLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBStationList([FromRoute] int id, [FromBody] BStationList bStationList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bStationList.Stationid)
            {
                return BadRequest();
            }

            _context.Entry(bStationList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BStationListExists(id))
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

        // POST: api/StationLists
        [HttpPost]
        public async Task<IActionResult> PostBStationList([FromBody] BStationList bStationList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BStationList.Add(bStationList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBStationList", new { id = bStationList.Stationid }, bStationList);
        }

        // DELETE: api/StationLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBStationList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bStationList = await _context.BStationList.FindAsync(id);
            if (bStationList == null)
            {
                return NotFound();
            }

            _context.BStationList.Remove(bStationList);
            await _context.SaveChangesAsync();

            return Ok(bStationList);
        }

        private bool BStationListExists(int id)
        {
            return _context.BStationList.Any(e => e.Stationid == id);
        }
    }
}
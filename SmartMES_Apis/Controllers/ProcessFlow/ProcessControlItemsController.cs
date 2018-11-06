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
    public class ProcessControlItemsController : ControllerBase
    {
        private readonly dbContext _context;

        public ProcessControlItemsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProcessControlItems
        [HttpGet]
        public IEnumerable<BProcessControlItem> GetBProcessControlItem([FromQuery] string machineCode, [FromQuery] string stationCode, [FromQuery] string processCode)
        {
            if (!String.IsNullOrWhiteSpace(machineCode))
            {
                stationCode = _context.BStationMachine.AsNoTracking().Where(e => e.MachineCode.Equals(machineCode)).FirstOrDefault()?.StationCode;
            }
            if (!String.IsNullOrWhiteSpace(stationCode))
            {
                processCode = _context.BStationList.AsNoTracking().Where(e => e.StationCode.Equals(stationCode)).FirstOrDefault()?.ProcessCode;
            }
            if (!String.IsNullOrWhiteSpace(processCode))
            {
                return _context.BProcessControlItem.AsNoTracking().Where(e => e.ProcessCode.Equals(processCode));
            }
            return _context.BProcessControlItem.AsNoTracking();
        }

        // GET: api/ProcessControlItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProcessControlItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessControlItem = await _context.BProcessControlItem.FindAsync(id);

            if (bProcessControlItem == null)
            {
                return NotFound();
            }

            return Ok(bProcessControlItem);
        }

        // PUT: api/ProcessControlItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProcessControlItem([FromRoute] int id, [FromBody] BProcessControlItem bProcessControlItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProcessControlItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(bProcessControlItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProcessControlItemExists(id))
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

        // POST: api/ProcessControlItems
        [HttpPost]
        public async Task<IActionResult> PostBProcessControlItem([FromBody] BProcessControlItem bProcessControlItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProcessControlItem.Add(bProcessControlItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProcessControlItem", new { id = bProcessControlItem.Id }, bProcessControlItem);
        }

        // DELETE: api/ProcessControlItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProcessControlItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessControlItem = await _context.BProcessControlItem.FindAsync(id);
            if (bProcessControlItem == null)
            {
                return NotFound();
            }

            _context.BProcessControlItem.Remove(bProcessControlItem);
            await _context.SaveChangesAsync();

            return Ok(bProcessControlItem);
        }

        private bool BProcessControlItemExists(int id)
        {
            return _context.BProcessControlItem.Any(e => e.Id == id);
        }
    }
}
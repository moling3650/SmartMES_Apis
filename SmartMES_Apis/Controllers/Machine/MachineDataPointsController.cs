using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Machine
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class MachineDataPointsController : ControllerBase
    {
        private readonly dbContext _context;

        public MachineDataPointsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MachineDataPoints
        [HttpGet]
        public IEnumerable<BMachineDataPoint> GetBMachineDataPoints([FromQuery] string machineCode)
        {
            if (!String.IsNullOrEmpty(machineCode))
            {
                return _context.BMachineDataPoint.Where(item => item.MachineCode.Equals(machineCode));
            }
            return _context.BMachineDataPoint;
        }

        // GET: api/MachineDataPoints/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachineDataPoint([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineDataPoint = await _context.BMachineDataPoint.FindAsync(id);

            if (bMachineDataPoint == null)
            {
                return NotFound();
            }

            return Ok(bMachineDataPoint);
        }

        // PUT: api/MachineDataPoints/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachineDataPoint([FromRoute] int id, [FromBody] BMachineDataPoint bMachineDataPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachineDataPoint.PointId)
            {
                return BadRequest();
            }

            _context.Entry(bMachineDataPoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineDataPointExists(id))
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

        // POST: api/MachineDataPoints
        [HttpPost]
        public async Task<IActionResult> PostBMachineDataPoint([FromBody] BMachineDataPoint bMachineDataPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachineDataPoint.Add(bMachineDataPoint);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachineDataPoint", new { id = bMachineDataPoint.PointId }, bMachineDataPoint);
        }

        // DELETE: api/MachineDataPoints/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachineDataPoint([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineDataPoint = await _context.BMachineDataPoint.FindAsync(id);
            if (bMachineDataPoint == null)
            {
                return NotFound();
            }

            _context.BMachineDataPoint.Remove(bMachineDataPoint);
            await _context.SaveChangesAsync();

            return Ok(bMachineDataPoint);
        }

        private bool BMachineDataPointExists(int id)
        {
            return _context.BMachineDataPoint.Any(e => e.PointId == id);
        }
    }
}
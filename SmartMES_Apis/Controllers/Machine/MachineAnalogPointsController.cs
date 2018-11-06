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
    public class MachineAnalogPointsController : ControllerBase
    {
        private readonly dbContext _context;

        public MachineAnalogPointsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MachineAnalogPoints
        [HttpGet]
        public IEnumerable<BMachineAnalogPoint> GetBMachineAnalogPoint([FromQuery] string machineCode)
        {
            if (!String.IsNullOrWhiteSpace(machineCode))
            {
                return _context.BMachineAnalogPoint.Where(e => e.MachineCode.Equals(machineCode));
            }
            return _context.BMachineAnalogPoint;
        }

        // GET: api/MachineAnalogPoints/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachineAnalogPoint([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineAnalogPoint = await _context.BMachineAnalogPoint.FindAsync(id);

            if (bMachineAnalogPoint == null)
            {
                return NotFound();
            }

            return Ok(bMachineAnalogPoint);
        }

        [HttpGet("Validate")]
        public bool ValidateBMachineStandardPoint([FromQuery] string machineCode, [FromQuery] string businessCode)
        {
            if (String.IsNullOrWhiteSpace(machineCode) || String.IsNullOrWhiteSpace(businessCode))
            {
                return false;
            }
            return !_context.BMachineAnalogPoint.Any(p => p.MachineCode.Equals(machineCode) && p.BusinessCode.Equals(businessCode));
        }

        // PUT: api/MachineAnalogPoints/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachineAnalogPoint([FromRoute] int id, [FromBody] BMachineAnalogPoint bMachineAnalogPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachineAnalogPoint.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMachineAnalogPoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineAnalogPointExists(id))
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

        // POST: api/MachineAnalogPoints
        [HttpPost]
        public async Task<IActionResult> PostBMachineAnalogPoint([FromBody] BMachineAnalogPoint bMachineAnalogPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachineAnalogPoint.Add(bMachineAnalogPoint);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachineAnalogPoint", new { id = bMachineAnalogPoint.Id }, bMachineAnalogPoint);
        }

        // DELETE: api/MachineAnalogPoints/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachineAnalogPoint([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineAnalogPoint = await _context.BMachineAnalogPoint.FindAsync(id);
            if (bMachineAnalogPoint == null)
            {
                return NotFound();
            }

            _context.BMachineAnalogPoint.Remove(bMachineAnalogPoint);
            await _context.SaveChangesAsync();

            return Ok(bMachineAnalogPoint);
        }

        private bool BMachineAnalogPointExists(int id)
        {
            return _context.BMachineAnalogPoint.Any(e => e.Id == id);
        }
    }
}
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
    public class MachineStandardPointsController : ControllerBase
    {
        private readonly dbContext _context;

        public MachineStandardPointsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MachineStandardPoints
        [HttpGet]
        public IEnumerable<BMachineStandardPoint> GetBMachineStandardPoints([FromQuery] string machineCode)
        {
            if (!String.IsNullOrEmpty(machineCode))
            {
                return _context.BMachineStandardPoint.Where(item => item.MachineCode.Equals(machineCode));
            }
            return _context.BMachineStandardPoint;
        }

        // GET: api/MachineStandardPoints/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachineStandardPoint([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineStandardPoint = await _context.BMachineStandardPoint.FindAsync(id);

            if (bMachineStandardPoint == null)
            {
                return NotFound();
            }

            return Ok(bMachineStandardPoint);
        }

        // PUT: api/MachineStandardPoints/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachineStandardPoint([FromRoute] int id, [FromBody] BMachineStandardPoint bMachineStandardPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachineStandardPoint.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMachineStandardPoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineStandardPointExists(id))
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

        // POST: api/MachineStandardPoints
        [HttpPost]
        public async Task<IActionResult> PostBMachineStandardPoint([FromBody] BMachineStandardPoint bMachineStandardPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachineStandardPoint.Add(bMachineStandardPoint);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BMachineStandardPointExists(bMachineStandardPoint.Id))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBMachineStandardPoint", new { id = bMachineStandardPoint.Id }, bMachineStandardPoint);
        }

        // DELETE: api/MachineStandardPoints/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachineStandardPoint([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineStandardPoint = await _context.BMachineStandardPoint.FindAsync(id);
            if (bMachineStandardPoint == null)
            {
                return NotFound();
            }

            _context.BMachineStandardPoint.Remove(bMachineStandardPoint);
            await _context.SaveChangesAsync();

            return Ok(bMachineStandardPoint);
        }

        private bool BMachineStandardPointExists(int id)
        {
            return _context.BMachineStandardPoint.Any(e => e.Id == id);
        }
    }
}
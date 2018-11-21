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
    public class MachinesController : ControllerBase
    {
        private readonly dbContext _context;

        public MachinesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Machines
        [HttpGet]
        public IEnumerable<BMachine> GetBMachine([FromQuery] string modelCode)
        {
            if (!String.IsNullOrEmpty(modelCode))
            {
                return _context.BMachine.Where(item => item.ModelCode.Equals(modelCode));
            }
            return _context.BMachine;
        }

        // GET: api/Machines/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachine = await _context.BMachine.FindAsync(id);

            if (bMachine == null)
            {
                return NotFound();
            }

            return Ok(bMachine);
        }

        // GET: api/Machines/Validate?machineCode=mCode
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string machineCode)
        {
            if (String.IsNullOrWhiteSpace(machineCode))
            {
                return false;
            }
            return !_context.BMachine.Any(e => e.MachineCode.Equals(machineCode));
        }

        // PUT: api/Machines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachine([FromRoute] int id, [FromBody] BMachine bMachine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachine.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMachine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineExists(id))
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

        // POST: api/Machines
        [HttpPost]
        public async Task<IActionResult> PostBMachine([FromBody] BMachine bMachine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachine.Add(bMachine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachine", new { id = bMachine.Id }, bMachine);
        }

        // DELETE: api/Machines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachine = await _context.BMachine.FindAsync(id);
            if (bMachine == null)
            {
                return NotFound();
            }

            _context.BMachine.Remove(bMachine);
            await _context.SaveChangesAsync();

            return Ok(bMachine);
        }

        private bool BMachineExists(int id)
        {
            return _context.BMachine.Any(e => e.Id == id);
        }
    }
}
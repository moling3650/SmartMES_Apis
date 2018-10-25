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
    public class MachineTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public MachineTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MachineTypes
        [HttpGet]
        public IEnumerable<BMachineType> GetBMachineType()
        {
            return _context.BMachineType;
        }

        // GET: api/MachineTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachineType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineType = await _context.BMachineType.FindAsync(id);

            if (bMachineType == null)
            {
                return NotFound();
            }

            return Ok(bMachineType);
        }

        // PUT: api/MachineTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachineType([FromRoute] int id, [FromBody] BMachineType bMachineType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachineType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bMachineType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineTypeExists(id))
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

        // POST: api/MachineTypes
        [HttpPost]
        public async Task<IActionResult> PostBMachineType([FromBody] BMachineType bMachineType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachineType.Add(bMachineType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachineType", new { id = bMachineType.TypeId }, bMachineType);
        }

        // DELETE: api/MachineTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachineType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineType = await _context.BMachineType.FindAsync(id);
            if (bMachineType == null)
            {
                return NotFound();
            }

            _context.BMachineType.Remove(bMachineType);
            await _context.SaveChangesAsync();

            return Ok(bMachineType);
        }

        private bool BMachineTypeExists(int id)
        {
            return _context.BMachineType.Any(e => e.TypeId == id);
        }
    }
}
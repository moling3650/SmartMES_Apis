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
    public class MachineKindsController : ControllerBase
    {
        private readonly dbContext _context;

        public MachineKindsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MachineKinds
        [HttpGet]
        public IEnumerable<BMachineKinds> GetBMachineKinds([FromQuery] int? typeId, [FromQuery] int? kindId)
        {
            if (typeId != null)
            {
                return _context.BMachineKinds.Where(item => item.TypeId == typeId);
            }
            if (kindId != null)
            {
                return _context.BMachineKinds.Where(item => item.KindId == kindId);
            }
            return _context.BMachineKinds;
        }

        // GET: api/MachineKinds/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachineKinds([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineKinds = await _context.BMachineKinds.FindAsync(id);

            if (bMachineKinds == null)
            {
                return NotFound();
            }

            return Ok(bMachineKinds);
        }

        // PUT: api/MachineKinds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachineKinds([FromRoute] int id, [FromBody] BMachineKinds bMachineKinds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachineKinds.KindId)
            {
                return BadRequest();
            }

            _context.Entry(bMachineKinds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineKindsExists(id))
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

        // POST: api/MachineKinds
        [HttpPost]
        public async Task<IActionResult> PostBMachineKinds([FromBody] BMachineKinds bMachineKinds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachineKinds.Add(bMachineKinds);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachineKinds", new { id = bMachineKinds.KindId }, bMachineKinds);
        }

        // DELETE: api/MachineKinds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachineKinds([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineKinds = await _context.BMachineKinds.FindAsync(id);
            if (bMachineKinds == null)
            {
                return NotFound();
            }

            _context.BMachineKinds.Remove(bMachineKinds);
            await _context.SaveChangesAsync();

            return Ok(bMachineKinds);
        }

        private bool BMachineKindsExists(int id)
        {
            return _context.BMachineKinds.Any(e => e.KindId == id);
        }
    }
}
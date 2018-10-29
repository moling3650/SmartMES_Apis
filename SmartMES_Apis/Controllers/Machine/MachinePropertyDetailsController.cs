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
    public class MachinePropertyDetailsController : ControllerBase
    {
        private readonly dbContext _context;

        public MachinePropertyDetailsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MachinePropertyDetails
        [HttpGet]
        public IEnumerable<BMachinePropertyDetail> GetBMachinePropertyDetail([FromQuery] string machineCode)
        {
            if (!String.IsNullOrWhiteSpace(machineCode))
            {
                return _context.BMachinePropertyDetail.Where(item => item.MachineCode.Equals(machineCode));
            }
            return _context.BMachinePropertyDetail;
        }

        // GET: api/MachinePropertyDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachinePropertyDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachinePropertyDetail = await _context.BMachinePropertyDetail.FindAsync(id);

            if (bMachinePropertyDetail == null)
            {
                return NotFound();
            }

            return Ok(bMachinePropertyDetail);
        }

        // PUT: api/MachinePropertyDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachinePropertyDetail([FromRoute] int id, [FromBody] BMachinePropertyDetail bMachinePropertyDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachinePropertyDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMachinePropertyDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachinePropertyDetailExists(id))
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

        // POST: api/MachinePropertyDetails
        [HttpPost]
        public async Task<IActionResult> PostBMachinePropertyDetail([FromBody] BMachinePropertyDetail bMachinePropertyDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachinePropertyDetail.Add(bMachinePropertyDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachinePropertyDetail", new { id = bMachinePropertyDetail.Id }, bMachinePropertyDetail);
        }

        // DELETE: api/MachinePropertyDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachinePropertyDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachinePropertyDetail = await _context.BMachinePropertyDetail.FindAsync(id);
            if (bMachinePropertyDetail == null)
            {
                return NotFound();
            }

            _context.BMachinePropertyDetail.Remove(bMachinePropertyDetail);
            await _context.SaveChangesAsync();

            return Ok(bMachinePropertyDetail);
        }

        private bool BMachinePropertyDetailExists(int id)
        {
            return _context.BMachinePropertyDetail.Any(e => e.Id == id);
        }
    }
}
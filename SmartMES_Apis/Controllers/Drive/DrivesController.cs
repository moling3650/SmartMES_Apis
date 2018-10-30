using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Drive
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class DrivesController : ControllerBase
    {
        private readonly dbContext _context;

        public DrivesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Drives
        [HttpGet]
        public IEnumerable<SDriveList> GetSDriveList([FromQuery] int? typeId)
        {
            if (typeId != null)
            {
                return _context.SDriveList.Where(item => item.TypeId == typeId);
            }
            return _context.SDriveList;
        }

        // GET: api/Drives/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSDriveList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sDriveList = await _context.SDriveList.FindAsync(id);

            if (sDriveList == null)
            {
                return NotFound();
            }

            return Ok(sDriveList);
        }

        // PUT: api/Drives/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSDriveList([FromRoute] int id, [FromBody] SDriveList sDriveList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sDriveList.DriveId)
            {
                return BadRequest();
            }

            _context.Entry(sDriveList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SDriveListExists(id))
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

        // POST: api/Drives
        [HttpPost]
        public async Task<IActionResult> PostSDriveList([FromBody] SDriveList sDriveList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SDriveList.Add(sDriveList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSDriveList", new { id = sDriveList.DriveId }, sDriveList);
        }

        // DELETE: api/Drives/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSDriveList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sDriveList = await _context.SDriveList.FindAsync(id);
            if (sDriveList == null)
            {
                return NotFound();
            }

            _context.SDriveList.Remove(sDriveList);
            await _context.SaveChangesAsync();

            return Ok(sDriveList);
        }

        private bool SDriveListExists(int id)
        {
            return _context.SDriveList.Any(e => e.DriveId == id);
        }
    }
}
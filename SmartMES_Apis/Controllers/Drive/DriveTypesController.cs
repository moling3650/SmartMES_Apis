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
    public class DriveTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public DriveTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/DriveTypes
        [HttpGet]
        public IEnumerable<BDriveType> GetBDriveType()
        {
            return _context.BDriveType;
        }

        // GET: api/DriveTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBDriveType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bDriveType = await _context.BDriveType.FindAsync(id);

            if (bDriveType == null)
            {
                return NotFound();
            }

            return Ok(bDriveType);
        }

        // PUT: api/DriveTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBDriveType([FromRoute] int id, [FromBody] BDriveType bDriveType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bDriveType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bDriveType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BDriveTypeExists(id))
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

        // POST: api/DriveTypes
        [HttpPost]
        public async Task<IActionResult> PostBDriveType([FromBody] BDriveType bDriveType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BDriveType.Add(bDriveType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBDriveType", new { id = bDriveType.TypeId }, bDriveType);
        }

        // DELETE: api/DriveTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBDriveType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bDriveType = await _context.BDriveType.FindAsync(id);
            if (bDriveType == null)
            {
                return NotFound();
            }

            _context.BDriveType.Remove(bDriveType);
            await _context.SaveChangesAsync();

            return Ok(bDriveType);
        }

        private bool BDriveTypeExists(int id)
        {
            return _context.BDriveType.Any(e => e.TypeId == id);
        }
    }
}
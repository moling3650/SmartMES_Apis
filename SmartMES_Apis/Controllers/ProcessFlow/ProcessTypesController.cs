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
    public class ProcessTypesController : ControllerBase
    {
        private readonly dbContext _context;

        public ProcessTypesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProcessTypes
        [HttpGet]
        public IEnumerable<BProcessType> GetBProcessType()
        {
            return _context.BProcessType;
        }

        // GET: api/ProcessTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProcessType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessType = await _context.BProcessType.FindAsync(id);

            if (bProcessType == null)
            {
                return NotFound();
            }

            return Ok(bProcessType);
        }

        // PUT: api/ProcessTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProcessType([FromRoute] int id, [FromBody] BProcessType bProcessType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProcessType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(bProcessType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProcessTypeExists(id))
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

        // POST: api/ProcessTypes
        [HttpPost]
        public async Task<IActionResult> PostBProcessType([FromBody] BProcessType bProcessType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProcessType.Add(bProcessType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProcessType", new { id = bProcessType.TypeId }, bProcessType);
        }

        // DELETE: api/ProcessTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProcessType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessType = await _context.BProcessType.FindAsync(id);
            if (bProcessType == null)
            {
                return NotFound();
            }

            _context.BProcessType.Remove(bProcessType);
            await _context.SaveChangesAsync();

            return Ok(bProcessType);
        }

        private bool BProcessTypeExists(int id)
        {
            return _context.BProcessType.Any(e => e.TypeId == id);
        }
    }
}
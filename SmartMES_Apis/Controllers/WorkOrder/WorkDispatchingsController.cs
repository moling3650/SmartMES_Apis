using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.WorkOrder
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class WorkDispatchingsController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkDispatchingsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkDispatchings
        [HttpGet]
        public IEnumerable<PWorkDispatching> GetPWorkDispatching([FromQuery] string processCode)
        {
            if (!String.IsNullOrWhiteSpace(processCode))
            {
                return _context.PWorkDispatching.Where(e => e.ProcessCode.Equals(processCode));
            }
            return _context.PWorkDispatching;
        }

        // GET: api/WorkDispatchings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPWorkDispatching([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pWorkDispatching = await _context.PWorkDispatching.FindAsync(id);

            if (pWorkDispatching == null)
            {
                return NotFound();
            }

            return Ok(pWorkDispatching);
        }

        // PUT: api/WorkDispatchings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPWorkDispatching([FromRoute] int id, [FromBody] PWorkDispatching pWorkDispatching)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pWorkDispatching.Id)
            {
                return BadRequest();
            }

            _context.Entry(pWorkDispatching).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PWorkDispatchingExists(id))
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

        // POST: api/WorkDispatchings
        [HttpPost]
        public async Task<IActionResult> PostPWorkDispatching([FromBody] PWorkDispatching pWorkDispatching)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PWorkDispatching.Add(pWorkDispatching);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPWorkDispatching", new { id = pWorkDispatching.Id }, pWorkDispatching);
        }

        // DELETE: api/WorkDispatchings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePWorkDispatching([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pWorkDispatching = await _context.PWorkDispatching.FindAsync(id);
            if (pWorkDispatching == null)
            {
                return NotFound();
            }

            _context.PWorkDispatching.Remove(pWorkDispatching);
            await _context.SaveChangesAsync();

            return Ok(pWorkDispatching);
        }

        private bool PWorkDispatchingExists(int id)
        {
            return _context.PWorkDispatching.Any(e => e.Id == id);
        }
    }
}
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
    public class DisposalProcessesController : ControllerBase
    {
        private readonly dbContext _context;

        public DisposalProcessesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/DisposalProcesses
        [HttpGet]
        public IEnumerable<BDisposalProcess> GetBDisposalProcess()
        {
            return _context.BDisposalProcess;
        }

        // GET: api/DisposalProcesses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBDisposalProcess([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bDisposalProcess = await _context.BDisposalProcess.FindAsync(id);

            if (bDisposalProcess == null)
            {
                return NotFound();
            }

            return Ok(bDisposalProcess);
        }

        // PUT: api/DisposalProcesses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBDisposalProcess([FromRoute] int id, [FromBody] BDisposalProcess bDisposalProcess)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bDisposalProcess.Id)
            {
                return BadRequest();
            }

            _context.Entry(bDisposalProcess).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BDisposalProcessExists(id))
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

        // POST: api/DisposalProcesses
        [HttpPost]
        public async Task<IActionResult> PostBDisposalProcess([FromBody] BDisposalProcess bDisposalProcess)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BDisposalProcess.Add(bDisposalProcess);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBDisposalProcess", new { id = bDisposalProcess.Id }, bDisposalProcess);
        }

        // DELETE: api/DisposalProcesses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBDisposalProcess([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bDisposalProcess = await _context.BDisposalProcess.FindAsync(id);
            if (bDisposalProcess == null)
            {
                return NotFound();
            }

            _context.BDisposalProcess.Remove(bDisposalProcess);
            await _context.SaveChangesAsync();

            return Ok(bDisposalProcess);
        }

        private bool BDisposalProcessExists(int id)
        {
            return _context.BDisposalProcess.Any(e => e.Id == id);
        }
    }
}
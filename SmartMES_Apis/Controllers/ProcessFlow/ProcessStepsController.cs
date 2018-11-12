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
    public class ProcessStepsController : ControllerBase
    {
        private readonly dbContext _context;

        public ProcessStepsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProcessSteps
        [HttpGet]
        public IEnumerable<BProcessStep> GetBProcessStep([FromQuery] int? pid) 
        {
            if (pid != null)
            {
                return _context.BProcessStep.AsNoTracking().Where(e => e.Pid == pid);
            }
            return _context.BProcessStep.AsNoTracking();
        }

        // GET: api/ProcessSteps/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProcessStep([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessStep = await _context.BProcessStep.FindAsync(id);

            if (bProcessStep == null)
            {
                return NotFound();
            }

            return Ok(bProcessStep);
        }

        // PUT: api/ProcessSteps/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProcessStep([FromRoute] int id, [FromBody] BProcessStep bProcessStep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProcessStep.StepId)
            {
                return BadRequest();
            }

            _context.Entry(bProcessStep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProcessStepExists(id))
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

        // POST: api/ProcessSteps
        [HttpPost]
        public async Task<IActionResult> PostBProcessStep([FromBody] BProcessStep bProcessStep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProcessStep.Add(bProcessStep);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProcessStep", new { id = bProcessStep.StepId }, bProcessStep);
        }

        // DELETE: api/ProcessSteps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProcessStep([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessStep = await _context.BProcessStep.FindAsync(id);
            if (bProcessStep == null)
            {
                return NotFound();
            }

            _context.BProcessStep.Remove(bProcessStep);
            await _context.SaveChangesAsync();

            return Ok(bProcessStep);
        }

        private bool BProcessStepExists(int id)
        {
            return _context.BProcessStep.Any(e => e.StepId == id);
        }
    }
}
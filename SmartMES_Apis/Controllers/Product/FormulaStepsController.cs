using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormulaStepsController : ControllerBase
    {
        private readonly dbContext _context;

        public FormulaStepsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/FormulaSteps
        [HttpGet]
        public IEnumerable<BFormulaStep> GetBFormulaStep([FromQuery] string formulaCode)
        {
            if (!String.IsNullOrWhiteSpace(formulaCode))
            {
                return _context.BFormulaStep.Where(e => e.FormulaCode.Equals(formulaCode));
            }
            return _context.BFormulaStep;
        }

        // GET: api/FormulaSteps/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBFormulaStep([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bFormulaStep = await _context.BFormulaStep.FindAsync(id);

            if (bFormulaStep == null)
            {
                return NotFound();
            }

            return Ok(bFormulaStep);
        }

        // api/FormulaSteps/Validate?StepCode=Code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string code)
        {
            if (String.IsNullOrWhiteSpace(code))
            {
                return false;
            }
            return !_context.BFormulaStep.Any(e => e.StepCode.Equals(code));
        }

        // PUT: api/FormulaSteps/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBFormulaStep([FromRoute] int id, [FromBody] BFormulaStep bFormulaStep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bFormulaStep.StepId)
            {
                return BadRequest();
            }

            _context.Entry(bFormulaStep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BFormulaStepExists(id))
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

        // POST: api/FormulaSteps
        [HttpPost]
        public async Task<IActionResult> PostBFormulaStep([FromBody] BFormulaStep bFormulaStep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BFormulaStep.Add(bFormulaStep);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBFormulaStep", new { id = bFormulaStep.StepId }, bFormulaStep);
        }

        // DELETE: api/FormulaSteps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBFormulaStep([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bFormulaStep = await _context.BFormulaStep.FindAsync(id);
            if (bFormulaStep == null)
            {
                return NotFound();
            }

            _context.BFormulaStep.Remove(bFormulaStep);
            await _context.SaveChangesAsync();

            return Ok(bFormulaStep);
        }

        private bool BFormulaStepExists(int id)
        {
            return _context.BFormulaStep.Any(e => e.StepId == id);
        }
    }
}
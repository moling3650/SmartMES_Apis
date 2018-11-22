using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class FormulasController : ControllerBase
    {
        private readonly dbContext _context;

        public FormulasController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Formulas
        [HttpGet]
        public IQueryable<BFormula> GetBFormula([FromQuery] string bomCode, [FromQuery] string flowCode)
        {
            if (!String.IsNullOrWhiteSpace(flowCode))
            {
                return from f in _context.BFormula
                       join b in _context.BBom on f.BomCode equals b.BomCode
                       join p in _context.BProcessFlow on b.BomId equals p.BomId
                       where p.FlowCode.Equals(flowCode)
                       select f;
            }
            if (!String.IsNullOrWhiteSpace(bomCode))
            {
                return _context.BFormula.AsNoTracking().Where(e => e.BomCode.Equals(bomCode));
            }
            return _context.BFormula.AsNoTracking();
        }

        // GET: api/Formulas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBFormula([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bFormula = await _context.BFormula.FindAsync(id);

            if (bFormula == null)
            {
                return NotFound();
            }

            return Ok(bFormula);
        }


        // api/Formulas/Validate?formulaCode=fCode
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string formulaCode)
        {
            if (String.IsNullOrWhiteSpace(formulaCode))
            {
                return false;
            }
            return !_context.BFormula.Any(e => e.FormulaCode.Equals(formulaCode));
        }

        // PUT: api/Formulas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBFormula([FromRoute] int id, [FromBody] BFormula bFormula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bFormula.Id)
            {
                return BadRequest();
            }

            _context.Entry(bFormula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BFormulaExists(id))
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

        // POST: api/Formulas
        [HttpPost]
        public async Task<IActionResult> PostBFormula([FromBody] BFormula bFormula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BFormula.Add(bFormula);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBFormula", new { id = bFormula.Id }, bFormula);
        }

        // DELETE: api/Formulas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBFormula([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bFormula = await _context.BFormula.FindAsync(id);
            if (bFormula == null)
            {
                return NotFound();
            }

            _context.BFormula.Remove(bFormula);
            await _context.SaveChangesAsync();

            return Ok(bFormula);
        }

        private bool BFormulaExists(int id)
        {
            return _context.BFormula.Any(e => e.Id == id);
        }
    }
}
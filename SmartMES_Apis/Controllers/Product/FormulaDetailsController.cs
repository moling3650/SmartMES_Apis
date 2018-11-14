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
    public class FormulaDetailsController : ControllerBase
    {
        private readonly dbContext _context;

        public FormulaDetailsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/FormulaDetails
        [HttpGet]
        public IEnumerable<BFormulaDetail> GetBFormulaDetail([FromQuery] string formulaCode)
        {
            if (!String.IsNullOrWhiteSpace(formulaCode))
            {
                return _context.BFormulaDetail.AsNoTracking().Where(e => e.FormulaCode.Equals(formulaCode));
            }
            return _context.BFormulaDetail;
        }

        // GET: api/FormulaDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBFormulaDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bFormulaDetail = await _context.BFormulaDetail.FindAsync(id);

            if (bFormulaDetail == null)
            {
                return NotFound();
            }

            return Ok(bFormulaDetail);
        }

        // PUT: api/FormulaDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBFormulaDetail([FromRoute] int id, [FromBody] BFormulaDetail bFormulaDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bFormulaDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(bFormulaDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BFormulaDetailExists(id))
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

        // POST: api/FormulaDetails
        [HttpPost]
        public async Task<IActionResult> PostBFormulaDetail([FromBody] BFormulaDetail bFormulaDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BFormulaDetail.Add(bFormulaDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBFormulaDetail", new { id = bFormulaDetail.Id }, bFormulaDetail);
        }

        // DELETE: api/FormulaDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBFormulaDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bFormulaDetail = await _context.BFormulaDetail.FindAsync(id);
            if (bFormulaDetail == null)
            {
                return NotFound();
            }

            _context.BFormulaDetail.Remove(bFormulaDetail);
            await _context.SaveChangesAsync();

            return Ok(bFormulaDetail);
        }

        private bool BFormulaDetailExists(int id)
        {
            return _context.BFormulaDetail.Any(e => e.Id == id);
        }
    }
}
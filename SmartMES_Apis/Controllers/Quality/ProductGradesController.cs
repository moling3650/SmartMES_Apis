using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Quality
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class ProductGradesController : ControllerBase
    {
        private readonly dbContext _context;

        public ProductGradesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProductGrades
        [HttpGet]
        public IEnumerable<BProductGrade> GetBProductGrade([FromQuery] string typeCode)
        {
            if (!String.IsNullOrWhiteSpace(typeCode))
            {
                return _context.BProductGrade.Where(e => e.TypeCode.Equals(typeCode));
            }
            return _context.BProductGrade;
        }

        // GET: api/ProductGrades/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProductGrade([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProductGrade = await _context.BProductGrade.FindAsync(id);

            if (bProductGrade == null)
            {
                return NotFound();
            }

            return Ok(bProductGrade);
        }

        // api/ProductGrades/Validate?gradeCode=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string gradeCode)
        {
            if (String.IsNullOrWhiteSpace(gradeCode))
            {
                return false;
            }
            return !_context.BProductGrade.Any(e => e.GradeCode.Equals(gradeCode));
        }

        // PUT: api/ProductGrades/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProductGrade([FromRoute] int id, [FromBody] BProductGrade bProductGrade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProductGrade.GradeId)
            {
                return BadRequest();
            }

            _context.Entry(bProductGrade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProductGradeExists(id))
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

        // POST: api/ProductGrades
        [HttpPost]
        public async Task<IActionResult> PostBProductGrade([FromBody] BProductGrade bProductGrade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProductGrade.Add(bProductGrade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProductGrade", new { id = bProductGrade.GradeId }, bProductGrade);
        }

        // DELETE: api/ProductGrades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProductGrade([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProductGrade = await _context.BProductGrade.FindAsync(id);
            if (bProductGrade == null)
            {
                return NotFound();
            }

            _context.BProductGrade.Remove(bProductGrade);
            await _context.SaveChangesAsync();

            return Ok(bProductGrade);
        }

        private bool BProductGradeExists(int id)
        {
            return _context.BProductGrade.Any(e => e.GradeId == id);
        }
    }
}
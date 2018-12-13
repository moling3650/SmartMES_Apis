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
    public class PedigreesController : ControllerBase
    {
        private readonly dbContext _context;

        public PedigreesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Pedigrees
        [HttpGet]
        public IEnumerable<BPedigree> GetBPedigree()
        {
            return _context.BPedigree;
        }

        // GET: api/Pedigrees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBPedigree([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bPedigree = await _context.BPedigree.FindAsync(id);

            if (bPedigree == null)
            {
                return NotFound();
            }

            return Ok(bPedigree);
        }

        // GET: api/Pedigrees/CascaderOptions
        [HttpGet("CascaderOptions")]
        public IQueryable GetBPedigreesCascaderOptions()
        {
            return from t in _context.BProductType
                   select new
                   {
                       value = t.TypeCode,
                       label = t.TypeName,
                       children = _context.BPedigree.Where(e => e.ProductTypeCode == t.TypeCode).Select(e => new
                       {
                           value = e.PedigreeCode,
                           label = e.PedigreeName
                       })
                   };
        }

        // PUT: api/Pedigrees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBPedigree([FromRoute] int id, [FromBody] BPedigree bPedigree)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bPedigree.Id)
            {
                return BadRequest();
            }

            _context.Entry(bPedigree).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BPedigreeExists(id))
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

        // POST: api/Pedigrees
        [HttpPost]
        public async Task<IActionResult> PostBPedigree([FromBody] BPedigree bPedigree)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BPedigree.Add(bPedigree);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBPedigree", new { id = bPedigree.Id }, bPedigree);
        }

        // DELETE: api/Pedigrees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBPedigree([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bPedigree = await _context.BPedigree.FindAsync(id);
            if (bPedigree == null)
            {
                return NotFound();
            }

            _context.BPedigree.Remove(bPedigree);
            await _context.SaveChangesAsync();

            return Ok(bPedigree);
        }

        private bool BPedigreeExists(int id)
        {
            return _context.BPedigree.Any(e => e.Id == id);
        }
    }
}
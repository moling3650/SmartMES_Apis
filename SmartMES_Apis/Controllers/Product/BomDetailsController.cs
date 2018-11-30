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
    public class BomDetailsController : ControllerBase
    {
        private readonly dbContext _context;

        public BomDetailsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/BomDetails
        [HttpGet]
        public IEnumerable<BBomDetail> GetBBomDetail([FromQuery] string bomCode, [FromQuery] string productCode)
        {
            if (!String.IsNullOrWhiteSpace(productCode))
            {
                bomCode = _context.BBom.Where(e => e.ProductCode.Equals(productCode)).FirstOrDefault()?.BomCode;
                if (bomCode  == null)
                {
                    return new List<BBomDetail>();
                }
            }
            if (!String.IsNullOrWhiteSpace(bomCode))
            {
                return _context.BBomDetail.Where(e => e.BomCode.Equals(bomCode)).OrderBy(e => e.MatType);
            }
            return _context.BBomDetail;
        }

        // GET: api/BomDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBBomDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bBomDetail = await _context.BBomDetail.FindAsync(id);

            if (bBomDetail == null)
            {
                return NotFound();
            }

            return Ok(bBomDetail);
        }

        // PUT: api/BomDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBBomDetail([FromRoute] int id, [FromBody] BBomDetail bBomDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bBomDetail.BomDetailId)
            {
                return BadRequest();
            }

            _context.Entry(bBomDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BBomDetailExists(id))
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

        // POST: api/BomDetails
        [HttpPost]
        public async Task<IActionResult> PostBBomDetail([FromBody] BBomDetail bBomDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BBomDetail.Add(bBomDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBBomDetail", new { id = bBomDetail.BomDetailId }, bBomDetail);
        }

        // DELETE: api/BomDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBBomDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bBomDetail = await _context.BBomDetail.FindAsync(id);
            if (bBomDetail == null)
            {
                return NotFound();
            }

            _context.BBomDetail.Remove(bBomDetail);
            await _context.SaveChangesAsync();

            return Ok(bBomDetail);
        }

        private bool BBomDetailExists(int id)
        {
            return _context.BBomDetail.Any(e => e.BomDetailId == id);
        }
    }
}
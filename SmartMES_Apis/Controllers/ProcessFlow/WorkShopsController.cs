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
    public class WorkShopsController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkShopsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkShops
        [HttpGet]
        public IEnumerable<BWorkShop> GetBWorkShop()
        {
            return _context.BWorkShop;
        }

        // GET: api/WorkShops/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkShop([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkShop = await _context.BWorkShop.FindAsync(id);

            if (bWorkShop == null)
            {
                return NotFound();
            }

            return Ok(bWorkShop);
        }

        // PUT: api/WorkShops/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkShop([FromRoute] int id, [FromBody] BWorkShop bWorkShop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkShop.Wsid)
            {
                return BadRequest();
            }

            _context.Entry(bWorkShop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkShopExists(id))
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

        // POST: api/WorkShops
        [HttpPost]
        public async Task<IActionResult> PostBWorkShop([FromBody] BWorkShop bWorkShop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkShop.Add(bWorkShop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkShop", new { id = bWorkShop.Wsid }, bWorkShop);
        }

        // DELETE: api/WorkShops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkShop([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkShop = await _context.BWorkShop.FindAsync(id);
            if (bWorkShop == null)
            {
                return NotFound();
            }

            _context.BWorkShop.Remove(bWorkShop);
            await _context.SaveChangesAsync();

            return Ok(bWorkShop);
        }

        private bool BWorkShopExists(int id)
        {
            return _context.BWorkShop.Any(e => e.Wsid == id);
        }
    }
}
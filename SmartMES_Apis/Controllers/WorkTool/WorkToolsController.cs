using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.WorkTool
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class WorkToolsController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkToolsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkTools
        [HttpGet]
        public IEnumerable<BWorkTool> GetBWorkTool([FromQuery] string modelCode)
        {
            if (!String.IsNullOrWhiteSpace(modelCode))
            {
                return _context.BWorkTool.Where(item => item.ModelCode.Equals(modelCode));
            }
            return _context.BWorkTool;
        }

        // GET: api/WorkTools/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBWorkTool([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkTool = await _context.BWorkTool.FindAsync(id);

            if (bWorkTool == null)
            {
                return NotFound();
            }

            return Ok(bWorkTool);
        }

        // PUT: api/WorkTools/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBWorkTool([FromRoute] int id, [FromBody] BWorkTool bWorkTool)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bWorkTool.Id)
            {
                return BadRequest();
            }

            _context.Entry(bWorkTool).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BWorkToolExists(id))
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

        // POST: api/WorkTools
        [HttpPost]
        public async Task<IActionResult> PostBWorkTool([FromBody] BWorkTool bWorkTool)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BWorkTool.Add(bWorkTool);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBWorkTool", new { id = bWorkTool.Id }, bWorkTool);
        }

        // DELETE: api/WorkTools/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBWorkTool([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bWorkTool = await _context.BWorkTool.FindAsync(id);
            if (bWorkTool == null)
            {
                return NotFound();
            }

            _context.BWorkTool.Remove(bWorkTool);
            await _context.SaveChangesAsync();

            return Ok(bWorkTool);
        }

        private bool BWorkToolExists(int id)
        {
            return _context.BWorkTool.Any(e => e.Id == id);
        }
    }
}
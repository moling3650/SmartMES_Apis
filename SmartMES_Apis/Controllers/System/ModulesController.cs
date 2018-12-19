using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.System
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class ModulesController : ControllerBase
    {
        private readonly dbContext _context;

        public ModulesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Modules
        [HttpGet]
        public IEnumerable<SModule> GetSModule()
        {
            return _context.SModule;
        }

        // GET: api/Modules/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSModule([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sModule = await _context.SModule.FindAsync(id);

            if (sModule == null)
            {
                return NotFound();
            }

            return Ok(sModule);
        }

        // PUT: api/Modules/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSModule([FromRoute] int id, [FromBody] SModule sModule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sModule.ModuleCode)
            {
                return BadRequest();
            }

            _context.Entry(sModule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SModuleExists(id))
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

        // POST: api/Modules
        [HttpPost]
        public async Task<IActionResult> PostSModule([FromBody] SModule sModule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SModule.Add(sModule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSModule", new { id = sModule.ModuleCode }, sModule);
        }

        // DELETE: api/Modules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSModule([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sModule = await _context.SModule.FindAsync(id);
            if (sModule == null)
            {
                return NotFound();
            }

            _context.SModule.Remove(sModule);
            await _context.SaveChangesAsync();

            return Ok(sModule);
        }

        private bool SModuleExists(int id)
        {
            return _context.SModule.Any(e => e.ModuleCode == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.System
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleInRolesController : ControllerBase
    {
        private readonly dbContext _context;

        public ModuleInRolesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ModuleInRoles
        [HttpGet]
        public IEnumerable<SModuleInRole> GetSModuleInRole([FromQuery] string roleId)
        {
            if (!String.IsNullOrWhiteSpace(roleId))
            {
                return _context.SModuleInRole.Where(e => e.RoleId.Equals(roleId));
            }
            return _context.SModuleInRole;
        }

        // GET: api/ModuleInRoles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSModuleInRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sModuleInRole = await _context.SModuleInRole.FindAsync(id);

            if (sModuleInRole == null)
            {
                return NotFound();
            }

            return Ok(sModuleInRole);
        }

        // PUT: api/ModuleInRoles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSModuleInRole([FromRoute] int id, [FromBody] SModuleInRole sModuleInRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sModuleInRole.Id)
            {
                return BadRequest();
            }

            _context.Entry(sModuleInRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SModuleInRoleExists(id))
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

        // PUT: api/ModuleInRoles
        [HttpPut]
        public async Task<IActionResult> PutSModuleInRole([FromBody] List<SModuleInRole> sModuleInRoleList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (sModuleInRoleList.Count == 0)
            {
                return NotFound();
            }
            var roleId = sModuleInRoleList.First().RoleId;
            var deleteList = _context.SModuleInRole.Where(e => e.RoleId.Equals(roleId));
            _context.SModuleInRole.RemoveRange(deleteList);
            _context.SModuleInRole.AddRange(sModuleInRoleList);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(sModuleInRoleList);
        }

        // POST: api/ModuleInRoles
        [HttpPost]
        public async Task<IActionResult> PostSModuleInRole([FromBody] SModuleInRole sModuleInRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SModuleInRole.Add(sModuleInRole);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSModuleInRole", new { id = sModuleInRole.Id }, sModuleInRole);
        }

        // DELETE: api/ModuleInRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSModuleInRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sModuleInRole = await _context.SModuleInRole.FindAsync(id);
            if (sModuleInRole == null)
            {
                return NotFound();
            }

            _context.SModuleInRole.Remove(sModuleInRole);
            await _context.SaveChangesAsync();

            return Ok(sModuleInRole);
        }

        private bool SModuleInRoleExists(int id)
        {
            return _context.SModuleInRole.Any(e => e.Id == id);
        }
    }
}
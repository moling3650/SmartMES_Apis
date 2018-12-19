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
    public class RolesController : ControllerBase
    {
        private readonly dbContext _context;

        public RolesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Roles
        [HttpGet]
        public IEnumerable<SRole> GetSRole()
        {
            return _context.SRole;
        }

        // GET: api/Roles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sRole = await _context.SRole.FindAsync(id);

            if (sRole == null)
            {
                return NotFound();
            }

            return Ok(sRole);
        }

        // api/Roles/Validate?roleId=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string roleId)
        {
            if (String.IsNullOrWhiteSpace(roleId))
            {
                return false;
            }
            return !_context.SRole.Any(e => e.RoleId.Equals(roleId));
        }

        // PUT: api/Roles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSRole([FromRoute] int id, [FromBody] SRole sRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sRole.Id)
            {
                return BadRequest();
            }

            _context.Entry(sRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SRoleExists(id))
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

        // POST: api/Roles
        [HttpPost]
        public async Task<IActionResult> PostSRole([FromBody] SRole sRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SRole.Add(sRole);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSRole", new { id = sRole.Id }, sRole);
        }

        // DELETE: api/Roles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sRole = await _context.SRole.FindAsync(id);
            if (sRole == null)
            {
                return NotFound();
            }

            _context.SRole.Remove(sRole);
            await _context.SaveChangesAsync();

            return Ok(sRole);
        }

        private bool SRoleExists(int id)
        {
            return _context.SRole.Any(e => e.Id == id);
        }
    }
}
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
    public class EmpInRolesController : ControllerBase
    {
        private readonly dbContext _context;

        public EmpInRolesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/EmpInRoles
        [HttpGet]
        public IEnumerable<SEmpInRole> GetSEmpInRole()
        {
            return _context.SEmpInRole;
        }

        // GET: api/EmpInRoles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSEmpInRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sEmpInRole = await _context.SEmpInRole.FindAsync(id);

            if (sEmpInRole == null)
            {
                return NotFound();
            }

            return Ok(sEmpInRole);
        }


        // POST: api/EmpInRoles
        [HttpPost]
        public async Task<IActionResult> PostSEmpInRole([FromBody] List<SEmpInRole> sEmpInRoleList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SEmpInRole.AddRange(sEmpInRoleList);
            await _context.SaveChangesAsync();

            return Ok(sEmpInRoleList);
        }

        // DELETE: api/EmpInRoles
        [HttpDelete]
        public async Task<IActionResult> DeleteSEmpInRole([FromBody] List<SEmpInRole> sEmpInRoleList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var list = from e in _context.SEmpInRole
                       join item in sEmpInRoleList on new { e.EmpCode, e.RoleId } equals new { item.EmpCode, item.RoleId }
                       select e;
            _context.SEmpInRole.RemoveRange(list);
            await _context.SaveChangesAsync();

            return Ok(sEmpInRoleList);
        }

        private bool SEmpInRoleExists(int id)
        {
            return _context.SEmpInRole.Any(e => e.Id == id);
        }
    }
}
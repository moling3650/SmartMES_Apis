using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Permission
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class EmployeesController : ControllerBase
    {
        private readonly dbContext _context;

        public EmployeesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public IEnumerable<SEmployee> GetSEmployees([FromQuery] string roleId)
        {
            if (!String.IsNullOrWhiteSpace(roleId))
            {
                if (roleId.Equals("null"))
                {
                    var emps = _context.SEmpInRole.Select(r => r.EmpCode).Distinct();
                    return _context.SEmployee.Where(e => !emps.Any(ec => ec.Equals(e.EmpCode)));
                }
                else
                {
                    return from e in _context.SEmployee
                           join r in _context.SEmpInRole on e.EmpCode equals r.EmpCode
                           where r.RoleId.Equals(roleId)
                           select e;
                }
            }
            else
            {
                return _context.SEmployee;
            }
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSEmployee([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sEmployee = await _context.SEmployee.FindAsync(id);

            if (sEmployee == null)
            {
                return NotFound();
            }

            return Ok(sEmployee);
        }

        // api/Employees/Validate?departCode=code
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string empCode)
        {
            if (String.IsNullOrWhiteSpace(empCode))
            {
                return false;
            }
            return !_context.SEmployee.Any(e => e.EmpCode.Equals(empCode));
        }

        // GET: api/Employees/Authorization
        [HttpGet("Authorization")]
        public bool Authorization([FromQuery] string empCode, [FromQuery] string password)
        {
            if (String.IsNullOrWhiteSpace(empCode))
            {
                return false;
            }
            var f = _context.SEmployee.Any(e => e.EmpCode.Equals(empCode) && e.Password.Equals(password));
            return f;
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSEmployee([FromRoute] string id, [FromBody] SEmployee sEmployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sEmployee.EmpCode)
            {
                return BadRequest();
            }

            _context.Entry(sEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SEmployeeExists(id))
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

        // POST: api/Employees
        [HttpPost]
        public async Task<IActionResult> PostSEmployee([FromBody] SEmployee sEmployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SEmployee.Add(sEmployee);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SEmployeeExists(sEmployee.EmpCode))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSEmployee", new { id = sEmployee.EmpCode }, sEmployee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSEmployee([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sEmployee = await _context.SEmployee.FindAsync(id);
            if (sEmployee == null)
            {
                return NotFound();
            }

            _context.SEmployee.Remove(sEmployee);
            await _context.SaveChangesAsync();

            return Ok(sEmployee);
        }

        private bool SEmployeeExists(string id)
        {
            return _context.SEmployee.Any(e => e.EmpCode == id);
        }
    }
}
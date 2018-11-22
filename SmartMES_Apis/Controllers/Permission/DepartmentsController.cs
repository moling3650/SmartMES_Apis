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
    public class DepartmentsController : ControllerBase
    {
        private readonly dbContext _context;

        public DepartmentsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Departments
        [HttpGet]
        public IEnumerable<SDepartment> GetSDepartment()
        {
            return _context.SDepartment;
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSDepartment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sDepartment = await _context.SDepartment.FindAsync(id);

            if (sDepartment == null)
            {
                return NotFound();
            }

            return Ok(sDepartment);
        }

        // PUT: api/Departments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSDepartment([FromRoute] int id, [FromBody] SDepartment sDepartment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sDepartment.Id)
            {
                return BadRequest();
            }

            _context.Entry(sDepartment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SDepartmentExists(id))
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

        // POST: api/Departments
        [HttpPost]
        public async Task<IActionResult> PostSDepartment([FromBody] SDepartment sDepartment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SDepartment.Add(sDepartment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSDepartment", new { id = sDepartment.Id }, sDepartment);
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSDepartment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sDepartment = await _context.SDepartment.FindAsync(id);
            if (sDepartment == null)
            {
                return NotFound();
            }

            _context.SDepartment.Remove(sDepartment);
            await _context.SaveChangesAsync();

            return Ok(sDepartment);
        }

        private bool SDepartmentExists(int id)
        {
            return _context.SDepartment.Any(e => e.Id == id);
        }
    }
}
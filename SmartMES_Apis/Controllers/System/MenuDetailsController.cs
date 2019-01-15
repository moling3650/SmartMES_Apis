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
    public class MenuDetailsController : ControllerBase
    {
        private readonly dbContext _context;

        public MenuDetailsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MenuDetails
        [HttpGet]
        public IEnumerable<SMenuDetail> GetSMenuDetail([FromQuery] String roleId)
        {
            if (!String.IsNullOrWhiteSpace(roleId))
            {
                return from m in _context.SMenuDetail
                       join i in _context.SModuleInRole on m.ModuleCode equals i.ModuleCode
                       where i.RoleId.Equals(roleId)
                       select m;
            }
            return _context.SMenuDetail;
        }

        // GET: api/MenuDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSMenuDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sMenuDetail = await _context.SMenuDetail.FindAsync(id);

            if (sMenuDetail == null)
            {
                return NotFound();
            }

            return Ok(sMenuDetail);
        }

        // GET: api/MenuDetails/TreeData
        [HttpGet("TreeData")]
        public IQueryable GetTreeData()
        {
            return _context.SMenuDetail.Where(e => e.IsRoot == 1).Select(e => new
            {
                value = e.Id,
                label = e.MenuName,
                data = e,
                children = from d in _context.SMenuDetail
                           where d.ParentId == e.Id
                           select new
                           {
                               value = d.Id,
                               label = d.MenuName,
                               data = d
                           }
            });
        }

        // PUT: api/MenuDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSMenuDetail([FromRoute] int id, [FromBody] SMenuDetail sMenuDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sMenuDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(sMenuDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SMenuDetailExists(id))
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

        // POST: api/MenuDetails
        [HttpPost]
        public async Task<IActionResult> PostSMenuDetail([FromBody] SMenuDetail sMenuDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SMenuDetail.Add(sMenuDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSMenuDetail", new { id = sMenuDetail.Id }, sMenuDetail);
        }

        // DELETE: api/MenuDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSMenuDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sMenuDetail = await _context.SMenuDetail.FindAsync(id);
            if (sMenuDetail == null)
            {
                return NotFound();
            }

            _context.SMenuDetail.Remove(sMenuDetail);
            await _context.SaveChangesAsync();

            return Ok(sMenuDetail);
        }

        private bool SMenuDetailExists(int id)
        {
            return _context.SMenuDetail.Any(e => e.Id == id);
        }
    }
}
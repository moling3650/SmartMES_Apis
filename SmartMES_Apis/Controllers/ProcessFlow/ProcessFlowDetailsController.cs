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
    public class ProcessFlowDetailsController : ControllerBase
    {
        private readonly dbContext _context;

        public ProcessFlowDetailsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProcessFlowDetails
        [HttpGet]
        public IEnumerable<BProcessFlowDetail> GetBProcessFlowDetail([FromQuery] string flowCode)
        {
            if (!String.IsNullOrWhiteSpace(flowCode))
            {
                return _context.BProcessFlowDetail.AsNoTracking().Where(e => e.FlowCode.Equals(flowCode));
            }
            return _context.BProcessFlowDetail.AsNoTracking();
        }

        // GET: api/ProcessFlowDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProcessFlowDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessFlowDetail = await _context.BProcessFlowDetail.FindAsync(id);

            if (bProcessFlowDetail == null)
            {
                return NotFound();
            }

            return Ok(bProcessFlowDetail);
        }

        // PUT: api/ProcessFlowDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProcessFlowDetail([FromRoute] int id, [FromBody] BProcessFlowDetail bProcessFlowDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProcessFlowDetail.Pid)
            {
                return BadRequest();
            }

            _context.Entry(bProcessFlowDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProcessFlowDetailExists(id))
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

        // POST: api/ProcessFlowDetails
        [HttpPost]
        public async Task<IActionResult> PostBProcessFlowDetail([FromBody] BProcessFlowDetail bProcessFlowDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProcessFlowDetail.Add(bProcessFlowDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProcessFlowDetail", new { id = bProcessFlowDetail.Pid }, bProcessFlowDetail);
        }

        // DELETE: api/ProcessFlowDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProcessFlowDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessFlowDetail = await _context.BProcessFlowDetail.FindAsync(id);
            if (bProcessFlowDetail == null)
            {
                return NotFound();
            }

            _context.BProcessFlowDetail.Remove(bProcessFlowDetail);
            await _context.SaveChangesAsync();

            return Ok(bProcessFlowDetail);
        }

        private bool BProcessFlowDetailExists(int id)
        {
            return _context.BProcessFlowDetail.Any(e => e.Pid == id);
        }
    }
}
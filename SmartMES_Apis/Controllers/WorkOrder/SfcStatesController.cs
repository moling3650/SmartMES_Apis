using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.WorkOrder
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class SfcStatesController : ControllerBase
    {
        private readonly dbContext _context;

        public SfcStatesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/SfcStates
        [HttpGet]
        public IEnumerable<PSfcState> GetPSfcState([FromQuery] string sfc)
        {
            if (!String.IsNullOrWhiteSpace(sfc))
            {
                return _context.PSfcState.Where(e => e.Sfc.Equals(sfc));
            }
            return _context.PSfcState;
        }

        // GET: api/SfcStates/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPSfcState([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pSfcState = await _context.PSfcState.FindAsync(id);

            if (pSfcState == null)
            {
                return NotFound();
            }

            return Ok(pSfcState);
        }

        // GET: api/SfcStates/detail
        [HttpGet("detail")]
        public IActionResult GetPSfcStateDetail([FromQuery] string sfc)
        {
            var failTimes = _context.PFailLog.Where(e => e.Sfc.Equals(sfc)).Count();
            return Ok((from w in _context.PWorkOrder
                     join p in _context.BProduct on w.ProductCode equals p.ProductCode
                     join s in _context.PSfcState on w.OrderNo equals s.OrderNo
                     where s.Sfc.Equals(sfc)
                     select new
                     {
                         s.Sfc,
                         s.OrderNo,
                         p.ProductCode,
                         p.ProductName,
                         productType = p.TypeCode,
                         failTimes
                     }).FirstOrDefault());
        }

        // PUT: api/SfcStates/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPSfcState([FromRoute] long id, [FromBody] PSfcState pSfcState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pSfcState.Id)
            {
                return BadRequest();
            }

            _context.Entry(pSfcState).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PSfcStateExists(id))
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

        // POST: api/SfcStates
        [HttpPost]
        public async Task<IActionResult> PostPSfcState([FromBody] PSfcState pSfcState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PSfcState.Add(pSfcState);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPSfcState", new { id = pSfcState.Id }, pSfcState);
        }

        // DELETE: api/SfcStates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePSfcState([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pSfcState = await _context.PSfcState.FindAsync(id);
            if (pSfcState == null)
            {
                return NotFound();
            }

            _context.PSfcState.Remove(pSfcState);
            await _context.SaveChangesAsync();

            return Ok(pSfcState);
        }

        private bool PSfcStateExists(long id)
        {
            return _context.PSfcState.Any(e => e.Id == id);
        }
    }
}
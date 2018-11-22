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
    public class WorkOrdersController : ControllerBase
    {
        private readonly dbContext _context;

        public WorkOrdersController(dbContext context)
        {
            _context = context;
        }

        // GET: api/WorkOrders
        [HttpGet]
        public IEnumerable<PWorkOrder> GetPWorkOrder()
        {
            return _context.PWorkOrder;
        }

        // GET: api/WorkOrders/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPWorkOrder([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pWorkOrder = await _context.PWorkOrder.FindAsync(id);

            if (pWorkOrder == null)
            {
                return NotFound();
            }

            return Ok(pWorkOrder);
        }

        // GET: api/WorkOrders/MainOrders?orderNo=xxx
        [HttpGet("MainOrders")]
        public IEnumerable<PWorkOrder> GetMainOrders([FromQuery] string orderNo)
        {
            var orders = _context.PWorkOrder.Where(e => e.OrderNo.Equals(e.MainOrder));
            if (!String.IsNullOrWhiteSpace(orderNo))
            {
                orders = orders.Where(e => e.OrderNo.Equals(orderNo));
            }
            return orders;
        }

        // api/WorkOrders/Validate?orderNo=xxx
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string orderNo)
        {
            if (String.IsNullOrWhiteSpace(orderNo))
            {
                return false;
            }
            return !_context.PWorkOrder.Any(e => e.OrderNo.Equals(orderNo));
        }

        // PUT: api/WorkOrders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPWorkOrder([FromRoute] int id, [FromBody] PWorkOrder pWorkOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pWorkOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(pWorkOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PWorkOrderExists(id))
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

        // POST: api/WorkOrders
        [HttpPost]
        public async Task<IActionResult> PostPWorkOrder([FromBody] PWorkOrder pWorkOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PWorkOrder.Add(pWorkOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPWorkOrder", new { id = pWorkOrder.Id }, pWorkOrder);
        }

        // DELETE: api/WorkOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePWorkOrder([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pWorkOrder = await _context.PWorkOrder.FindAsync(id);
            if (pWorkOrder == null)
            {
                return NotFound();
            }

            _context.PWorkOrder.Remove(pWorkOrder);
            await _context.SaveChangesAsync();

            return Ok(pWorkOrder);
        }

        private bool PWorkOrderExists(int id)
        {
            return _context.PWorkOrder.Any(e => e.Id == id);
        }
    }
}
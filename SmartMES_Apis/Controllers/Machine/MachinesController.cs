using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Machine
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class MachinesController : ControllerBase
    {
        private readonly dbContext _context;

        public MachinesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Machines
        [HttpGet]
        public IEnumerable<BMachine> GetBMachine([FromQuery] string modelCode, [FromQuery] string stationCode, [FromQuery] int? kindId)
        {
            if (kindId != null)
            {
                return from m in _context.BMachine
                       join mo in _context.BMachineModel on m.ModelCode equals mo.ModelCode
                       where mo.KindId == kindId
                       select m;
            }
            if (!String.IsNullOrEmpty(modelCode))
            {
                return _context.BMachine.Where(item => item.ModelCode.Equals(modelCode));
            }
            if (!String.IsNullOrWhiteSpace(stationCode))
            {
                return _context.BMachine.Where(e => e.StationCode.Equals(stationCode));
            }
            return _context.BMachine;
        }


        // GET: api/Machines/WithProcess
        [HttpGet("WithProcess")]
        public IQueryable GetBMachinesWithProcess([FromQuery] int? wsid)
        {
            return from m in _context.BMachine
                   join s in _context.BStationList on m.StationCode equals s.StationCode
                   join p in _context.BProcessList on s.ProcessCode equals p.ProcessCode
                   join w in _context.BWorkGroup on p.GroupCode equals w.GroupCode
                   group new
                   {
                       m.MachineCode,
                       m.MachineName,
                       m.Img
                   } by new { w.Wsid, p.ProcessCode, p.ProcessName, p.Idx } into g
                   orderby g.Key.Idx
                   select new
                   {
                       g.Key.Wsid,
                       g.Key.ProcessCode,
                       g.Key.ProcessName,
                       children = g
                   };
        }

        // GET: api/Machines/WithStatus
        [HttpGet("WithStatus")]
        public IDictionary GetBMachinesWithStatus()
        {

            return (from s in _context.PMachineStateRecord
                   where s.BeCurrent == 1
                   join o in _context.POrderMachine on s.MachineCode equals o.MachineCode into orders
                   from m in orders.DefaultIfEmpty()
                   select new
                   {
                       s.MachineCode,
                       s.State,
                       s.StopReason,
                       s.TroubleCode,
                       m.OrderNo,
                       m.EmpCode
                   }).ToDictionary(e => e.MachineCode);
        }

        // GET: api/Machines/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachine = await _context.BMachine.FindAsync(id);

            if (bMachine == null)
            {
                return NotFound();
            }

            return Ok(bMachine);
        }

        // GET: api/Machines/Validate?machineCode=mCode
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string machineCode)
        {
            if (String.IsNullOrWhiteSpace(machineCode))
            {
                return false;
            }
            return !_context.BMachine.Any(e => e.MachineCode.Equals(machineCode));
        }

        // PUT: api/Machines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachine([FromRoute] int id, [FromBody] BMachine bMachine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachine.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMachine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineExists(id))
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

        // POST: api/Machines
        [HttpPost]
        public async Task<IActionResult> PostBMachine([FromBody] BMachine bMachine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachine.Add(bMachine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachine", new { id = bMachine.Id }, bMachine);
        }

        // DELETE: api/Machines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachine = await _context.BMachine.FindAsync(id);
            if (bMachine == null)
            {
                return NotFound();
            }

            _context.BMachine.Remove(bMachine);
            await _context.SaveChangesAsync();

            return Ok(bMachine);
        }

        private bool BMachineExists(int id)
        {
            return _context.BMachine.Any(e => e.Id == id);
        }
    }
}
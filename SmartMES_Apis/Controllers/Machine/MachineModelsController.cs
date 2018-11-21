using System;
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
    public class MachineModelsController : ControllerBase
    {
        private readonly dbContext _context;

        public MachineModelsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MachineModels
        [HttpGet]
        public IEnumerable<BMachineModel> GetBMachineModel([FromQuery] int? kindId)
        {
            if (kindId != null)
            {
                return _context.BMachineModel.Where(item => item.KindId == kindId);
            }
            return _context.BMachineModel;
        }

        // GET: api/MachineModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachineModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineModel = await _context.BMachineModel.FindAsync(id);

            if (bMachineModel == null)
            {
                return NotFound();
            }

            return Ok(bMachineModel);
        }


        // GET: api/MachineModels/Validate?modelCode=mCode
        [HttpGet("Validate")]
        public bool Validate([FromQuery] string modelCode)
        {
            if (String.IsNullOrWhiteSpace(modelCode))
            {
                return false;
            }
            return !_context.BMachineModel.Any(e => e.ModelCode.Equals(modelCode));
        }

        // PUT: api/MachineModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachineModel([FromRoute] int id, [FromBody] BMachineModel bMachineModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachineModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(bMachineModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineModelExists(id))
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

        // POST: api/MachineModels
        [HttpPost]
        public async Task<IActionResult> PostBMachineModel([FromBody] BMachineModel bMachineModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachineModel.Add(bMachineModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachineModel", new { id = bMachineModel.Id }, bMachineModel);
        }

        // DELETE: api/MachineModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachineModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineModel = await _context.BMachineModel.FindAsync(id);
            if (bMachineModel == null)
            {
                return NotFound();
            }

            _context.BMachineModel.Remove(bMachineModel);
            await _context.SaveChangesAsync();

            return Ok(bMachineModel);
        }

        private bool BMachineModelExists(int id)
        {
            return _context.BMachineModel.Any(e => e.Id == id);
        }
    }
}
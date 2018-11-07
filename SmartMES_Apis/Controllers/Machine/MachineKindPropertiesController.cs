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
    public class MachineKindPropertiesController : ControllerBase
    {
        private readonly dbContext _context;

        public MachineKindPropertiesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/MachineKindProperties
        [HttpGet]
        public IEnumerable<BMachineKindProperty> GetBMachineKindProperty([FromQuery] string modelCode, [FromQuery] int? kindId)
        {
            if (String.IsNullOrWhiteSpace(modelCode) && kindId == null)
            {
                return _context.BMachineKindProperty;
            }
            if (!String.IsNullOrWhiteSpace(modelCode))
            {
                kindId = _context.BMachineModel.Where(item => item.ModelCode.Equals(modelCode)).FirstOrDefault()?.KindId;
            }
            if (kindId != null)
            {
                return _context.BMachineKindProperty.Where(item => item.KindId == kindId);
            }
            else
            {
                return new List<BMachineKindProperty>();
            }
        }

        // GET: api/MachineKindProperties/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBMachineKindProperty([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineKindProperty = await _context.BMachineKindProperty.FindAsync(id);

            if (bMachineKindProperty == null)
            {
                return NotFound();
            }

            return Ok(bMachineKindProperty);
        }

        // PUT: api/MachineKindProperties/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBMachineKindProperty([FromRoute] int id, [FromBody] BMachineKindProperty bMachineKindProperty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bMachineKindProperty.PptId)
            {
                return BadRequest();
            }

            var item = await _context.BMachineKindProperty.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            if (item.PptType != bMachineKindProperty.PptType)
            {
                var details = _context.BMachinePropertyDetail.Where(e => e.PptId == id);
                _context.BMachinePropertyDetail.RemoveRange(details);
            }
            item.PptName = bMachineKindProperty.PptName;
            item.PptType = bMachineKindProperty.PptType;
            item.Description = bMachineKindProperty.Description;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BMachineKindPropertyExists(id))
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

        // POST: api/MachineKindProperties
        [HttpPost]
        public async Task<IActionResult> PostBMachineKindProperty([FromBody] BMachineKindProperty bMachineKindProperty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BMachineKindProperty.Add(bMachineKindProperty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBMachineKindProperty", new { id = bMachineKindProperty.PptId }, bMachineKindProperty);
        }

        // DELETE: api/MachineKindProperties/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBMachineKindProperty([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bMachineKindProperty = await _context.BMachineKindProperty.FindAsync(id);
            if (bMachineKindProperty == null)
            {
                return NotFound();
            }
            var details = _context.BMachinePropertyDetail.Where(e => e.PptId == id);
            _context.BMachinePropertyDetail.RemoveRange(details);

            _context.BMachineKindProperty.Remove(bMachineKindProperty);
            await _context.SaveChangesAsync();

            return Ok(bMachineKindProperty);
        }

        private bool BMachineKindPropertyExists(int id)
        {
            return _context.BMachineKindProperty.Any(e => e.PptId == id);
        }
    }
}
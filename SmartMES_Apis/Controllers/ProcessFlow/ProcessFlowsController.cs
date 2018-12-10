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

namespace SmartMES_Apis.Controllers.ProcessFlow
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class ProcessFlowsController : ControllerBase
    {
        private readonly dbContext _context;

        public ProcessFlowsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/ProcessFlows
        [HttpGet]
        public IEnumerable<BProcessFlow> GetBProcessFlow([FromQuery] string productCode)
        {
            if (!String.IsNullOrWhiteSpace(productCode))
            {
                return _context.BProcessFlow.Where(e => e.ProductCode.Equals(productCode));
            }
            return _context.BProcessFlow;
        }

        // GET: api/ProcessFlows/CascaderOptions
        [HttpGet("CascaderOptions")]
        public IQueryable GetBProcessFlowCascaderOptions()
        {
            var products = _context.BProduct.AsNoTracking().GroupJoin(_context.BProcessFlow, p => p.ProductCode, pf => pf.ProductCode, 
                (p, pfList) => new { title = p.ProductName, typeCode = p.TypeCode, children = pfList.Select(pf => new { id = pf.FlowCode, title = pf.FlowName, data = pf }) });
            return _context.BProductType.AsNoTracking().GroupJoin(products, pt => pt.TypeCode, p => p.typeCode,
                (pt, pList) => new { title = pt.TypeName, children = pList });
        }

        // GET: api/ProcessFlows/SubProcessFlows
        [HttpGet("SubProcessFlows")]
        public IDictionary GetSubProcessFlows()
        {
            var productCodes = _context.BBomDetail.Where(e => e.MatType == 0).Select(e => e.MatCode).Distinct();
            var products = from c in productCodes
                           join f in _context.BProcessFlow on c equals f.ProductCode
                           group f by c into g
                           select new { productCode = g.Key, flows = g.Select(e => e.FlowCode) };

            return (from f in _context.BProcessFlow
                   join b in _context.BBom on f.BomId equals b.BomId
                    join d in _context.BBomDetail on b.BomCode equals d.BomCode
                    join p in products on d.MatCode equals p.productCode
                    where b.Enable == 1 && b.IsSplit == 1
                   group p by f.FlowCode into g
                   select new
                   {
                       parentFlowCode = g.Key,
                       products = g
                   }).ToDictionary(f => f.parentFlowCode, f => f.products);
        }

        // GET: api/ProcessFlows/SplitMap
        [HttpGet("SplitMap")]
        public IDictionary GetSplitMap()
        {
            var flowMap = from f in _context.BProcessFlow
                          join d in _context.BProcessFlowDetail on f.FlowCode equals d.FlowCode
                          join p in _context.BProcessList on d.ProcessFrom equals p.ProcessCode
                          group p by f.FlowCode into g
                          select new { flowCode = g.Key, enableSplit = g.Sum(p => p.TaskMode) > 0 };
            return flowMap.ToDictionary(f => f.flowCode, f => f.enableSplit);
        }


        // GET: api/ProcessFlows/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProcessFlow([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessFlow = await _context.BProcessFlow.FindAsync(id);

            if (bProcessFlow == null)
            {
                return NotFound();
            }

            return Ok(bProcessFlow);
        }

        // PUT: api/ProcessFlows/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProcessFlow([FromRoute] int id, [FromBody] BProcessFlow bProcessFlow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProcessFlow.Id)
            {
                return BadRequest();
            }

            _context.Entry(bProcessFlow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProcessFlowExists(id))
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

        // POST: api/ProcessFlows
        [HttpPost]
        public async Task<IActionResult> PostBProcessFlow([FromBody] BProcessFlow bProcessFlow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProcessFlow.Add(bProcessFlow);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProcessFlow", new { id = bProcessFlow.Id }, bProcessFlow);
        }

        // DELETE: api/ProcessFlows/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProcessFlow([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProcessFlow = await _context.BProcessFlow.FindAsync(id);
            if (bProcessFlow == null)
            {
                return NotFound();
            }

            _context.BProcessFlow.Remove(bProcessFlow);
            await _context.SaveChangesAsync();

            return Ok(bProcessFlow);
        }

        private bool BProcessFlowExists(int id)
        {
            return _context.BProcessFlow.Any(e => e.Id == id);
        }
    }
}
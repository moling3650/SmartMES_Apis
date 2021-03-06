﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartMES_Apis.Models;

namespace SmartMES_Apis.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class ProductsController : ControllerBase
    {
        private readonly dbContext _context;

        public ProductsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<BProduct> GetBProduct([FromQuery] string typeCode, [FromQuery] string pedigreeCode)
        {
            var products = _context.BProduct.AsNoTracking();
            if (!String.IsNullOrWhiteSpace(typeCode))
            {
                products = products.Where(e => e.TypeCode.Equals(typeCode));
            }
            if (!String.IsNullOrWhiteSpace(pedigreeCode))
            {
                products = products.Where(e => e.PedigreeCode.Equals(pedigreeCode));
            }
            return products;
        }

        // GET: api/Products/CascaderOptions
        [HttpGet("CascaderOptions")]
        public IQueryable GetBProductCascaderOptions()
        {
            return _context.BProductType.GroupJoin(_context.BProduct, 
                                              pt => pt.TypeCode,
                                              p => p.TypeCode,
                                              (pt, pList) => 
                                              new
                                              {
                                                  value = pt.TypeCode,
                                                  label = pt.TypeName,
                                                  children = pList.Select(p => new { value = p.ProductCode, label = p.ProductName })
                                              });
        }

        // GET: api/Products/Formulas
        [HttpGet("Formulas")]
        public IDictionary GetFormulas()
        {
            return (from f in
                       (from p in _context.BProduct
                        where p.ManageType == 1
                        join b in _context.BBom on p.ProductCode equals b.ProductCode
                        join f in _context.BFormula on b.BomCode equals f.BomCode into allFormulas
                        from d in allFormulas.DefaultIfEmpty()
                        select new
                        {
                            productCode = p.ProductCode,
                            formulaCode = d.FormulaCode,
                            formulaName = d.FormulaName
                        })
                    group f by f.productCode into g
                    select new
                    {
                        productCode = g.Key,
                        formulas = g.Where(e => e.formulaCode != null).Select(e => new { value = e.formulaCode, label = e.formulaName })
                    }).ToDictionary(e => e.productCode, e => e.formulas);

        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProduct = await _context.BProduct.FindAsync(id);

            if (bProduct == null)
            {
                return NotFound();
            }

            return Ok(bProduct);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBProduct([FromRoute] int id, [FromBody] BProduct bProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bProduct.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(bProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BProductExists(id))
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

        [HttpGet("Validate")]
        public bool Validate([FromQuery] string productCode)
        {
            if (String.IsNullOrWhiteSpace(productCode))
            {
                return false;
            }
            return !_context.BProduct.Any(e => e.ProductCode.Equals(productCode));
        }

        // POST: api/Products
        [HttpPost]
        public async Task<IActionResult> PostBProduct([FromBody] BProduct bProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BProduct.Add(bProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBProduct", new { id = bProduct.ProductId }, bProduct);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bProduct = await _context.BProduct.FindAsync(id);
            if (bProduct == null)
            {
                return NotFound();
            }

            _context.BProduct.Remove(bProduct);
            await _context.SaveChangesAsync();

            return Ok(bProduct);
        }

        private bool BProductExists(int id)
        {
            return _context.BProduct.Any(e => e.ProductId == id);
        }
    }
}
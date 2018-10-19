using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BFormula
    {
        public int Id { get; set; }
        public string BomCode { get; set; }
        public string FormulaCode { get; set; }
        public string FormulaName { get; set; }
        public decimal BaseQty { get; set; }
        public string Designator { get; set; }
        public string Description { get; set; }
        public int Enable { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

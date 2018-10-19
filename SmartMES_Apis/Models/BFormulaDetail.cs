using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BFormulaDetail
    {
        public int Id { get; set; }
        public string FormulaCode { get; set; }
        public string FormulaItem { get; set; }
        public string MaterialCode { get; set; }
        public int FeedIdx { get; set; }
        public decimal FeedQty { get; set; }
        public decimal Deviate { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

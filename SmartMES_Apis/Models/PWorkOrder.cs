using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PWorkOrder
    {
        public int Id { get; set; }
        public string MainOrder { get; set; }
        public string ParentOrder { get; set; }
        public string OrderNo { get; set; }
        public string ProductCode { get; set; }
        public string FlowCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? CpltQty { get; set; }
        public string Co { get; set; }
        public int? Urgency { get; set; }
        public int? State { get; set; }
        public DateTime InputTime { get; set; }
        public DateTime? PlannedTime { get; set; }
        public string Customer { get; set; }
        public int? Property { get; set; }
        public string EmpCode { get; set; }
        public string Remarks { get; set; }
        public string WorkshopCode { get; set; }
        public int? Lvl { get; set; }
        public string FormulaCode { get; set; }
    }
}

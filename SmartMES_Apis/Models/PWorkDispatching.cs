using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PWorkDispatching
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string DispatchingNo { get; set; }
        public string LinkNo { get; set; }
        public string ProductCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? CpltQty { get; set; }
        public decimal? NgQty { get; set; }
        public string ProcessCode { get; set; }
        public string StationCode { get; set; }
        public int? State { get; set; }
        public string MouldCode { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? PlannedStartTime { get; set; }
        public DateTime? PlannedCpltTime { get; set; }
        public string EmpCode { get; set; }
        public string Description { get; set; }
    }
}

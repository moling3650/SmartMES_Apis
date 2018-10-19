using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSswPrintList
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string TemplateId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Completed { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string State { get; set; }
        public string MainOrder { get; set; }
    }
}

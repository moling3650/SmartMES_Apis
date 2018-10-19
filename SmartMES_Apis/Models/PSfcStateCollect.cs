using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcStateCollect
    {
        public int Id { get; set; }
        public string WorkshopCode { get; set; }
        public int LineId { get; set; }
        public string ProductCode { get; set; }
        public string Years { get; set; }
        public string Months { get; set; }
        public string Days { get; set; }
        public string Weeks { get; set; }
        public decimal? OutputQty { get; set; }
        public string Remarks { get; set; }
        public int? PracticalEfficiency { get; set; }
    }
}

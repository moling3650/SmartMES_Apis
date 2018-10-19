using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PProductEfficiencyCollect
    {
        public int Id { get; set; }
        public string WorkshopCode { get; set; }
        public string ProductCode { get; set; }
        public string Years { get; set; }
        public string Months { get; set; }
        public string Days { get; set; }
        public string Weeks { get; set; }
        public int? Spt { get; set; }
        public int? CurrSpt { get; set; }
        public string Remarks { get; set; }
        public decimal? TotalQty { get; set; }
    }
}

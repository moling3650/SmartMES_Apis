using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcProcessIolog
    {
        public long Id { get; set; }
        public string OrderNo { get; set; }
        public string Sfc { get; set; }
        public decimal? Qty { get; set; }
        public int? FailTimes { get; set; }
        public string GroupCode { get; set; }
        public string ProcessCode { get; set; }
        public string StationCode { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? OutputTime { get; set; }
        public DateTime? PDate { get; set; }
        public int? Pass { get; set; }
        public string EmpCode { get; set; }
        public string ClassCode { get; set; }
        public string Workshop { get; set; }
        public DateTime? StartTime { get; set; }
        public decimal? Initqty { get; set; }
    }
}

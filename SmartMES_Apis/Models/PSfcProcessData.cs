using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcProcessData
    {
        public long Id { get; set; }
        public string OrderNo { get; set; }
        public int? Pid { get; set; }
        public string StationCode { get; set; }
        public int? StepId { get; set; }
        public string MatCode { get; set; }
        public string Sfc { get; set; }
        public int? FailTimes { get; set; }
        public int? Idx { get; set; }
        public string StepType { get; set; }
        public string Val { get; set; }
        public decimal? Qty { get; set; }
        public string Unit { get; set; }
        public DateTime? InputTime { get; set; }
        public int? Pass { get; set; }
        public string EmpCode { get; set; }
        public DateTime? PDate { get; set; }
        public string ClassCode { get; set; }
        public string Workshop { get; set; }
    }
}

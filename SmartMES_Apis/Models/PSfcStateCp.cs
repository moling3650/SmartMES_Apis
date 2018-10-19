using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcStateCp
    {
        public long Id { get; set; }
        public string OrderNo { get; set; }
        public string Sfc { get; set; }
        public decimal? Qty { get; set; }
        public int? IsTray { get; set; }
        public int? FailTimes { get; set; }
        public int? State { get; set; }
        public string InputStation { get; set; }
        public string FromProcess { get; set; }
        public string NowProcess { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? ProcessTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? GradeId { get; set; }
        public string GradeType { get; set; }
    }
}

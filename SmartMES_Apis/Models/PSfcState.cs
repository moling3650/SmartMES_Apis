using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcState
    {
        public long Id { get; set; }
        public string OrderNo { get; set; }
        public string Sfc { get; set; }
        public decimal? Initqty { get; set; }
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
        public string GradeId { get; set; }
        public string GradeType { get; set; }
        public DateTime? BeginDate { get; set; }
        public string BeginClasscode { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndClasscode { get; set; }
        public string Workshop { get; set; }
        public string ParentOrder { get; set; }
        public string MainOrder { get; set; }
        public string MatCode { get; set; }
    }
}

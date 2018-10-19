using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachinePropertyDetail
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public int? PptId { get; set; }
        public string PptVal { get; set; }
        public int? PptType { get; set; }
        public decimal? PptMax { get; set; }
        public decimal? PptMin { get; set; }
        public string PptCondition { get; set; }
        public int? Enable { get; set; }
    }
}

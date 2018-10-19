using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcessFlowDetail
    {
        public int Pid { get; set; }
        public string FlowCode { get; set; }
        public string Description { get; set; }
        public string ProcessFromGroup { get; set; }
        public string ProcessFrom { get; set; }
        public string ProcessResult { get; set; }
        public string ProcessNextGroup { get; set; }
        public string ProcessNext { get; set; }
        public string DisposalCode { get; set; }
        public int? ProcessMinTime { get; set; }
        public int? Idx { get; set; }
        public byte[] ImageUrl { get; set; }
        public int? Strict { get; set; }
        public decimal? StandardTime { get; set; }
    }
}

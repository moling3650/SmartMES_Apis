using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcRequirement
    {
        public int ReqId { get; set; }
        public string ProductCode { get; set; }
        public string ReqName { get; set; }
        public string Description { get; set; }
    }
}

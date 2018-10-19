using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PProcRequirementDetail
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string ProductCode { get; set; }
        public int ReqId { get; set; }
        public string Val1 { get; set; }
        public string Val2 { get; set; }
        public string Val3 { get; set; }
    }
}

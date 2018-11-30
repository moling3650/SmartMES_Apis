using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcessFlow
    {
        public int Id { get; set; }
        public string FlowCode { get; set; }
        public string FlowName { get; set; }
        public string VersionCode { get; set; }
        public string ProductCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? State { get; set; }
        public int? BomId { get; set; }
        public string BomCode { get; set; }
    }
}

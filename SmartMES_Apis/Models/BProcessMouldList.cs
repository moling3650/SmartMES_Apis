using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcessMouldList
    {
        public int Id { get; set; }
        public string FlowCode { get; set; }
        public int? Pid { get; set; }
        public string ModelCode { get; set; }
        public int? Qty { get; set; }
    }
}

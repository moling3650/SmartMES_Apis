using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PTrayDetail
    {
        public long Id { get; set; }
        public string TraySfc { get; set; }
        public string Sfc { get; set; }
        public DateTime? InputTime { get; set; }
    }
}

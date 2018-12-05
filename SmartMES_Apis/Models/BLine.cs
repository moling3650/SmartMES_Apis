using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BLine
    {
        public int LineId { get; set; }
        public string LineCode { get; set; }
        public string LineName { get; set; }
        public string Description { get; set; }
        public int Wsid { get; set; }
    }
}

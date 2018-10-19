using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcJude
    {
        public int Id { get; set; }
        public string JudeCode { get; set; }
        public string JudeName { get; set; }
        public string Sfc { get; set; }
        public int? State { get; set; }
    }
}

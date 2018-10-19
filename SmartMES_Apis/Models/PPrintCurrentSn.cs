using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PPrintCurrentSn
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int? CurrentSn { get; set; }
        public DateTime? InputTime { get; set; }
    }
}

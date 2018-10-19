using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcProcessSonData
    {
        public int Id { get; set; }
        public string Orderno { get; set; }
        public string Sfc { get; set; }
        public string Steppre { get; set; }
        public string Parentstepid { get; set; }
        public string Stepid { get; set; }
        public string Stepval { get; set; }
        public string Stepconclude { get; set; }
        public DateTime? Inputtime { get; set; }
        public int? Isfedbatch { get; set; }
        public int? Back1 { get; set; }
        public string Back2 { get; set; }
    }
}

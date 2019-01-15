using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BNgCode
    {
        public int NgId { get; set; }
        public int? Idx { get; set; }
        public string ProductType { get; set; }
        public string NgCode { get; set; }
        public string NgName { get; set; }
        public string TypeCode { get; set; }
        public string Decription { get; set; }
        public int ExecProc { get; set; }
    }
}

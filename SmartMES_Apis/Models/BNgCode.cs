using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BNgCode
    {
        public int NgId { get; set; }
        public int? Idx { get; set; }
        public string Typecode { get; set; }
        public string NgCode { get; set; }
        public string NgName { get; set; }
        public string TypeCode1 { get; set; }
        public string Decription { get; set; }
        public int ExecProc { get; set; }
    }
}

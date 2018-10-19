using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcMachine
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public string Sfc { get; set; }
        public DateTime? InputTime { get; set; }
        public string Remark { get; set; }
    }
}

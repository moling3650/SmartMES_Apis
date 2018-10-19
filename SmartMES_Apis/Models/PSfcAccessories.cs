using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcAccessories
    {
        public int Id { get; set; }
        public string AccessoriesCode { get; set; }
        public string MachineCode { get; set; }
        public string Sfc { get; set; }
        public DateTime? InputTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PIpqcData
    {
        public int QcId { get; set; }
        public string ProductCode { get; set; }
        public string FlowCode { get; set; }
        public string ProcessCode { get; set; }
        public string StationCode { get; set; }
        public string Sfc { get; set; }
        public string MachineNum { get; set; }
        public string CheckPerson { get; set; }
        public string ReviewPerson { get; set; }
        public string Shift { get; set; }
        public DateTime? Time { get; set; }
        public string Comment { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PAccessoryRecords
    {
        public int Id { get; set; }
        public string AccessoryCode { get; set; }
        public string MachineCode { get; set; }
        public int? State { get; set; }
        public int? Type { get; set; }
        public DateTime? Loadtime { get; set; }
        public DateTime? Downtime { get; set; }
        public DateTime? InputTime { get; set; }
        public string AccessoryPreson { get; set; }
        public string Remarks { get; set; }
    }
}

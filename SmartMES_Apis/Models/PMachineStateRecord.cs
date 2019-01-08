using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMachineStateRecord
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public int? BeCurrent { get; set; }
        public int? State { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? StopReason { get; set; }
        public string TroubleCode { get; set; }
        public string Remarks { get; set; }
    }
}

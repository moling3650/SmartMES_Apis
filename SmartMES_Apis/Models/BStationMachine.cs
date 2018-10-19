using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BStationMachine
    {
        public int Id { get; set; }
        public string StationCode { get; set; }
        public string MachineCode { get; set; }
        public int? MachineState { get; set; }
        public DateTime? MaintainCycle { get; set; }
        public DateTime? LastMaintaintime { get; set; }
        public DateTime? ExpectNexttime { get; set; }
        public string Remark { get; set; }
    }
}

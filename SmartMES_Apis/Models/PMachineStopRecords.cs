using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMachineStopRecords
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public string ProcessCode { get; set; }
        public string StationCode { get; set; }
        public string WsCode { get; set; }
        public int? Type { get; set; }
        public int? State { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public string StopReason { get; set; }
        public string OperatePerson { get; set; }
        public int? IsNew { get; set; }
    }
}

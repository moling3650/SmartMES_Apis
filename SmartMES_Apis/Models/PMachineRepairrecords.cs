using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMachineRepairrecords
    {
        public int Id { get; set; }
        public string RepairCode { get; set; }
        public string ExceptionCode { get; set; }
        public string MachineCode { get; set; }
        public string ExceptionReason { get; set; }
        public DateTime? RepairStarttime { get; set; }
        public DateTime? RepairEndtime { get; set; }
        public int? RepairResult { get; set; }
        public string RepairPerson { get; set; }
        public string RepairRemarks { get; set; }
    }
}

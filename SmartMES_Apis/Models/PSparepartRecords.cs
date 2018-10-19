using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSparepartRecords
    {
        public int Id { get; set; }
        public string SparepartCode { get; set; }
        public string MachineCode { get; set; }
        public int? State { get; set; }
        public int? Type { get; set; }
        public DateTime? Loadtime { get; set; }
        public DateTime? Downloadtime { get; set; }
        public string OperatePerson { get; set; }
        public string Remarks { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMachineMaintainrecords
    {
        public int Id { get; set; }
        public string MaintainCode { get; set; }
        public string MachineCode { get; set; }
        public string MaintainType { get; set; }
        public DateTime? MaintainStarttime { get; set; }
        public DateTime? MaintainEndtime { get; set; }
        public string MaintainPerson { get; set; }
    }
}

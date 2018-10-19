using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineMouldKinds
    {
        public int Id { get; set; }
        public int? MachineKindId { get; set; }
        public int? MouldKindId { get; set; }
        public int? Qty { get; set; }
        public string Parameter { get; set; }
        public string Description { get; set; }
        public DateTime? InputTime { get; set; }
    }
}

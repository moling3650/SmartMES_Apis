using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PProductionPlan
    {
        public int Id { get; set; }
        public string EmpCode { get; set; }
        public DateTime? PanlTime { get; set; }
        public DateTime? InputTime { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
    }
}

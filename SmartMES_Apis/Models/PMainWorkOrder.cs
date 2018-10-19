using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMainWorkOrder
    {
        public int Id { get; set; }
        public string MainOrder { get; set; }
        public int? PrintState { get; set; }
        public DateTime? PlanTime { get; set; }
        public string ProductCode { get; set; }
    }
}

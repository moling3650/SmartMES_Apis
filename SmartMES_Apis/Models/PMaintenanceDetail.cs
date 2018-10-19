using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMaintenanceDetail
    {
        public int Id { get; set; }
        public int? MaintenanceId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? OutputTime { get; set; }
        public int? UseTimes { get; set; }
        public DateTime? UserDate { get; set; }
        public string UserOrder { get; set; }
    }
}

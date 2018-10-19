using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMaintenance
    {
        public int Id { get; set; }
        public int MaintenanceId { get; set; }
        public string EquipmentCode { get; set; }
        public int? MaintenanceType { get; set; }
        public int? Val { get; set; }
        public string Unit { get; set; }
        public DateTime? FillingDate { get; set; }
        public DateTime? CloseDate { get; set; }
    }
}

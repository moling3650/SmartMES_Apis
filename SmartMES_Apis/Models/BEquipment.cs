using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BEquipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentCode { get; set; }
        public string EquipmentName { get; set; }
        public string TypeId { get; set; }
        public string Description { get; set; }
        public int? Enable { get; set; }
        public string EmpCode { get; set; }
    }
}

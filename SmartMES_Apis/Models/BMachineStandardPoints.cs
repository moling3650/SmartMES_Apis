using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineStandardPoints
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public string BusinessCode { get; set; }
        public string BusinessName { get; set; }
        public int? PointId { get; set; }
        public string DriveCode { get; set; }
        public int? TriggerCondition { get; set; }
        public string Parameter { get; set; }
    }
}

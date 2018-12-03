using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineAnalogPoint
    {
        public int Id { get; set; }
        public int ControlId { get; set; }
        public string MachineCode { get; set; }
        public string BusinessCode { get; set; }
        public string BusinessName { get; set; }
        public int PointId { get; set; }
        public int? TriggerType { get; set; }
        public int? TriggerCondition { get; set; }
        public string Parameter { get; set; }
        public string DriveCode { get; set; }
        public int? ToMonitor { get; set; }
        public int RunAt { get; set; }
    }
}

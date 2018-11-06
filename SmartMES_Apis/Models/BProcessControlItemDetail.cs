using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcessControlItemDetail
    {
        public int Id { get; set; }
        public int ControlId { get; set; }
        public int Pid { get; set; }
        public int TriggerType { get; set; }
        public int TriggerCondition { get; set; }
        public string Parameter { get; set; }
        public decimal Ucl { get; set; }
        public decimal Lcl { get; set; }
        public int GroupCount { get; set; }
        public string DriveCode { get; set; }
        public int ToMonitor { get; set; }
    }
}

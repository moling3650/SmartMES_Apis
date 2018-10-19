using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BPreStep
    {
        public int PreId { get; set; }
        public string ProcessCode { get; set; }
        public string StepCode { get; set; }
        public string StepName { get; set; }
        public string StepType { get; set; }
        public string FlowCode { get; set; }
        public int? TypeId { get; set; }
        public string DriveCode { get; set; }
        public string Parameter { get; set; }
        public string TimeOut { get; set; }
        public string Format { get; set; }
        public int? AllowReuse { get; set; }
        public int? Autorun { get; set; }
        public int? AutoRestart { get; set; }
        public int Idx { get; set; }
        public int IsRecord { get; set; }
        public string Triger { get; set; }
        public string Parameter2 { get; set; }
        public string Unit { get; set; }
        public int? IsKeySteps { get; set; }
    }
}

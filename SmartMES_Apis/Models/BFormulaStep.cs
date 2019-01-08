using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BFormulaStep
    {
        public int StepId { get; set; }
        public string FormulaCode { get; set; }
        public string StepCode { get; set; }
        public string StepName { get; set; }
        public string StepType { get; set; }
        public int Idx { get; set; }
        public int? TypeId { get; set; }
        public string DriveCode { get; set; }
        public string Parameter { get; set; }
        public string MatCode { get; set; }
        public int? CtrlType { get; set; }
        public string TimeOut { get; set; }
        public string Format { get; set; }
        public int? AllowReuse { get; set; }
        public int? Autorun { get; set; }
        public int? AutoRestart { get; set; }
        public int IsRecord { get; set; }
        public string Triger { get; set; }
        public string Parameter2 { get; set; }
        public string Unit { get; set; }
        public int? ConsumeType { get; set; }
        public float? ConsumePercent { get; set; }
    }
}

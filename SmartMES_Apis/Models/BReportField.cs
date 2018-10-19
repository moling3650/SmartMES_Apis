using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BReportField
    {
        public string ReportCode { get; set; }
        public string Prop { get; set; }
        public string Label { get; set; }
        public string Width { get; set; }
        public int Idx { get; set; }
        public string Align { get; set; }
        public int State { get; set; }
        public int IsCheck { get; set; }
        public string ControlCode { get; set; }
        public int? ControlSpan { get; set; }
        public int? Required { get; set; }
        public string OptionsApi { get; set; }
    }
}

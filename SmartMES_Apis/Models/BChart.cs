using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BChart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReportCode { get; set; }
        public string ChartTypeCode { get; set; }
        public int? State { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }
}

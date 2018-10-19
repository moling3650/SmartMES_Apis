using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PNgScrap
    {
        public int Id { get; set; }
        public string ScrapLot { get; set; }
        public string Model { get; set; }
        public string ProductType { get; set; }
        public string Workshop { get; set; }
        public string Process { get; set; }
        public int? Qty { get; set; }
        public string Reason { get; set; }
        public string ResponsibilityJudgment { get; set; }
        public string ResponsibleDepartment { get; set; }
        public string ImprovementMeasures { get; set; }
        public string Applicants { get; set; }
        public string Reviewer { get; set; }
        public DateTime? Date { get; set; }
    }
}

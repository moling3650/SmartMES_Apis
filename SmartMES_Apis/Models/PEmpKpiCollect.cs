using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PEmpKpiCollect
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public string ProcessCode { get; set; }
        public string Years { get; set; }
        public string Months { get; set; }
        public string Days { get; set; }
        public string Weeks { get; set; }
        public string ProductCode { get; set; }
        public decimal? WorkTime { get; set; }
        public decimal? Qty { get; set; }
        public decimal? FailQty { get; set; }
        public int? FailTimes { get; set; }
    }
}

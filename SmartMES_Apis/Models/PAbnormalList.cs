using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PAbnormalList
    {
        public int Id { get; set; }
        public string AbnormalNo { get; set; }
        public string AbnormalDesc { get; set; }
        public DateTime? InputTime { get; set; }
        public string DepartCode { get; set; }
        public string SendEmp { get; set; }
        public string ProcessCode { get; set; }
        public string MachineCode { get; set; }
        public string ProductCode { get; set; }
        public string Sfc { get; set; }
        public decimal? FailCount { get; set; }
        public decimal? ImpressionCount { get; set; }
        public int? State { get; set; }
        public DateTime? FinishTime { get; set; }
        public string ToEmp { get; set; }
        public string ToEmp2 { get; set; }
        public string EffectDesc { get; set; }
        public string EffectEmp { get; set; }
        public string DutyFrom { get; set; }
        public string DutyFrom2 { get; set; }
        public string DutyType { get; set; }
    }
}

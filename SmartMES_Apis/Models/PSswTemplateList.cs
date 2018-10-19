using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSswTemplateList
    {
        public string TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string RuleStr { get; set; }
        public DateTime? InputTime { get; set; }
        public int? CurrentSn { get; set; }
        public int? MaxSn { get; set; }
        public string SetZero { get; set; }
        public DateTime? ZeroDate { get; set; }
        public string TemplatePath { get; set; }
        public int? FaxType { get; set; }
        public int? CheckCode { get; set; }
        public int? PrintCopies { get; set; }
        public string Variable { get; set; }
    }
}

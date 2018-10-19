using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PIpqcTemplate
    {
        public int TemplateId { get; set; }
        public int ItemId { get; set; }
        public int? Idx { get; set; }
        public string FlowCode { get; set; }
        public string ProcessCode { get; set; }
        public string ProStds { get; set; }
        public string Allowable { get; set; }
        public string Description { get; set; }
    }
}

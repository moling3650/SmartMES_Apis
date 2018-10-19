using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PQcTemplate
    {
        public int TemplateId { get; set; }
        public string ProcessCode { get; set; }
        public string ItemCode { get; set; }
        public string Standard { get; set; }
        public string Description { get; set; }
    }
}

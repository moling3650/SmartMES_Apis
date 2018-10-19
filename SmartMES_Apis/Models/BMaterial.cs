using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMaterial
    {
        public int MatId { get; set; }
        public string MatCode { get; set; }
        public string MatName { get; set; }
        public string Description { get; set; }
        public int? TypeId { get; set; }
        public string CodeRule { get; set; }
        public string PackingStyle { get; set; }
        public string Unit { get; set; }
        public decimal? MaxQty { get; set; }
        public DateTime? InputDate { get; set; }
        public int? ValidDate { get; set; }
        public int? State { get; set; }
        public int? Enable { get; set; }
        public int? Mbm { get; set; }
        public decimal? Lvl { get; set; }
        public decimal? WipValid { get; set; }
        public decimal? StationValid { get; set; }
    }
}

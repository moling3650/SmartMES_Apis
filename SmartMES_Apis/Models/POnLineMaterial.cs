using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class POnLineMaterial
    {
        public string LotNo { get; set; }
        public string MatCode { get; set; }
        public decimal? Qty { get; set; }
        public string OrderNo { get; set; }
        public DateTime? InputTime { get; set; }
        public int? State { get; set; }
        public string StationCode { get; set; }
    }
}

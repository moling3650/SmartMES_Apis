using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMatWipSeed
    {
        public int Id { get; set; }
        public int? WipId { get; set; }
        public string MatCode { get; set; }
        public string OrderAbove { get; set; }
        public string OrderNo { get; set; }
        public string LotNo { get; set; }
        public decimal? LotQty { get; set; }
        public int? State { get; set; }
        public string StationCode { get; set; }
        public int? PointId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? UnloadTime { get; set; }
        public DateTime? FeelTime { get; set; }
        public string EmpCode { get; set; }
    }
}

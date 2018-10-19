using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMaterialWip
    {
        public long Id { get; set; }
        public string BillNo { get; set; }
        public string OrderNo { get; set; }
        public string ParentOrder { get; set; }
        public string MainOrder { get; set; }
        public string MatCodeFact { get; set; }
        public string MatCode { get; set; }
        public string LotNo { get; set; }
        public decimal? InputQty { get; set; }
        public decimal? LotQty { get; set; }
        public int? State { get; set; }
        public string StationCode { get; set; }
        public int? PointId { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? FeedTime { get; set; }
        public string ParentStation { get; set; }
        public string Workshop { get; set; }
    }
}

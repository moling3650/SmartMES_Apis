using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcRank
    {
        public long Id { get; set; }
        public int? LotType { get; set; }
        public string OrderNo { get; set; }
        public string MainSfc { get; set; }
        public string ParentSfc { get; set; }
        public decimal? ParentQty { get; set; }
        public string ChildSfc { get; set; }
        public decimal? ChildQty { get; set; }
        public DateTime? InputDate { get; set; }
        public int? Number { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BBomDetail
    {
        public int BomDetailId { get; set; }
        public string BomCode { get; set; }
        public string MatCode { get; set; }
        public int? MatType { get; set; }
        public decimal? Qty { get; set; }
        public int? BaseQty { get; set; }
        public decimal? Wastage { get; set; }
        public int? EnableSubstitute { get; set; }
        public int? EnableBeyond { get; set; }
        public int? BeCtrl { get; set; }
    }
}

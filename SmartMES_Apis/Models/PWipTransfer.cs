using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PWipTransfer
    {
        public int Id { get; set; }
        public string BillNo { get; set; }
        public string OrderNo { get; set; }
        public string ParentOrder { get; set; }
        public string MatCode { get; set; }
        public string LotNo { get; set; }
        public decimal? InputQty { get; set; }
        public decimal? LotQty { get; set; }
        public DateTime? InputTime { get; set; }
        public string EmpCode { get; set; }
        public string Workshop { get; set; }
    }
}

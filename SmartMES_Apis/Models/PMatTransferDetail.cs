using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMatTransferDetail
    {
        public long Id { get; set; }
        public string BillNo { get; set; }
        public string OrderNo { get; set; }
        public string TransferId { get; set; }
        public string LotNo { get; set; }
        public decimal? Qty { get; set; }
        public DateTime? InputTime { get; set; }
        public string Workshop { get; set; }
    }
}

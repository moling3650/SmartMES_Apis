using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PFailDetail
    {
        public int Id { get; set; }
        public string Fguid { get; set; }
        public string OrderNo { get; set; }
        public string Sfc { get; set; }
        public string NgCode { get; set; }
        public string ReasonCode { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public int? Pass { get; set; }
        public string ReasontypeCode { get; set; }
        public decimal? Qty { get; set; }
        public string WsCode { get; set; }
    }
}

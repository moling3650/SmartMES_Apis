using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PNphCollect
    {
        public int Id { get; set; }
        public decimal? Nph { get; set; }
        public DateTime? PDate { get; set; }
        public string PCode { get; set; }
        public string WsCode { get; set; }
    }
}

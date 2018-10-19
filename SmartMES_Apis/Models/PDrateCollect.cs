using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PDrateCollect
    {
        public int Id { get; set; }
        public DateTime? PDate { get; set; }
        public decimal? DRate { get; set; }
        public string PCode { get; set; }
        public string WsCode { get; set; }
    }
}

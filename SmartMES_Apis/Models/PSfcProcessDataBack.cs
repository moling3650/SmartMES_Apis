using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PSfcProcessDataBack
    {
        public int Id { get; set; }
        public string Fguid { get; set; }
        public string OrderNo { get; set; }
        public string Sfc { get; set; }
        public string MatCode { get; set; }
        public string Val { get; set; }
        public string NewVal { get; set; }
        public DateTime? PDate { get; set; }
        public string Remark { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class POrderStation
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string ParentOrder { get; set; }
        public string MainOrder { get; set; }
        public string Sfc { get; set; }
        public string StationCode { get; set; }
        public string EmpCode { get; set; }
        public DateTime? InputTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BBom
    {
        public int BomId { get; set; }
        public string BomCode { get; set; }
        public string VersionCode { get; set; }
        public string ProductCode { get; set; }
        public int? BaseQty { get; set; }
        public string Designator { get; set; }
        public string Discription { get; set; }
        public int? Enable { get; set; }
        public DateTime CreateTime { get; set; }
        public int? IsSplit { get; set; }
    }
}

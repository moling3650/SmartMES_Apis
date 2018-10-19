using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProduct
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Typecode { get; set; }
        public string VersionCode { get; set; }
        public string Cmn { get; set; }
        public string Description { get; set; }
        public string CodeRule { get; set; }
        public int? RouteType { get; set; }
        public decimal? MaxQty { get; set; }
        public string Unit { get; set; }
        public DateTime? InputTime { get; set; }
        public int? Mbm { get; set; }
        public int? PrintBind { get; set; }
        public decimal? Lvl { get; set; }
        public int? Spt { get; set; }
        public string ModelCode { get; set; }
        public decimal? WipValid { get; set; }
        public decimal? StationValid { get; set; }
        public int? ManageType { get; set; }
        public string PedigreeCode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BStationMatPoint
    {
        public int Id { get; set; }
        public int? PointId { get; set; }
        public string ProductCode { get; set; }
        public string MatCode { get; set; }
        public decimal? MaxQty { get; set; }
    }
}

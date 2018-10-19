using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BStationMountPoint
    {
        public int PointId { get; set; }
        public string StationCode { get; set; }
        public string PointCode { get; set; }
        public string Description { get; set; }
        public string CodeRule { get; set; }
    }
}

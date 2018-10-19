using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BStationList
    {
        public int Stationid { get; set; }
        public string StationCode { get; set; }
        public string StationName { get; set; }
        public string ProcessCode { get; set; }
        public int? LineId { get; set; }
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }
        public string Discription { get; set; }
        public int? IsFormal { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineDataPoint
    {
        public int PointId { get; set; }
        public string DataPointName { get; set; }
        public string MachineCode { get; set; }
        public int? PointType { get; set; }
        public string DriveCode { get; set; }
        public int? DcType { get; set; }
        public DateTime? InputTime { get; set; }
        public string Description { get; set; }
        public string Parameter { get; set; }
        public int? Rate { get; set; }
        public string TransCode { get; set; }
    }
}

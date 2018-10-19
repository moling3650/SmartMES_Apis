using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcessList
    {
        public int Processid { get; set; }
        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }
        public string GroupCode { get; set; }
        public int? TypeId { get; set; }
        public string SectionName { get; set; }
        public string RouteType { get; set; }
        public int? AllowPack { get; set; }
        public int? Idx { get; set; }
        public int TaskMode { get; set; }
        public int ProductionMode { get; set; }
    }
}

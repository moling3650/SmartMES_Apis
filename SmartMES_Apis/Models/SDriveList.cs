using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class SDriveList
    {
        public int DriveId { get; set; }
        public string DriveCode { get; set; }
        public string DriveName { get; set; }
        public string FileName { get; set; }
        public int? TypeId { get; set; }
        public string Description { get; set; }
        public int? IsPublic { get; set; }
        public int? Enable { get; set; }
        public int? Property { get; set; }
    }
}

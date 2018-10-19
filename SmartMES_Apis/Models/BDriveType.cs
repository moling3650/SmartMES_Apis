using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BDriveType
    {
        public int TypeId { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public int? DriveClass { get; set; }
    }
}

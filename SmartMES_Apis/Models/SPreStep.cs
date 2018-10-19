using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class SPreStep
    {
        public int Id { get; set; }
        public string ProcessCode { get; set; }
        public string DriveCode { get; set; }
        public string Parameter { get; set; }
        public int? SortVal { get; set; }
    }
}

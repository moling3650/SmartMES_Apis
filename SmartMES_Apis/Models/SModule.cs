using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class SModule
    {
        public int ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int? ModuleType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BWorkGroup
    {
        public int Id { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public int Wsid { get; set; }
        public string Description { get; set; }
        public int? Idx { get; set; }
        public int? TimeIncrement { get; set; }
    }
}

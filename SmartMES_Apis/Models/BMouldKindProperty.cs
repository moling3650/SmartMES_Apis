using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMouldKindProperty
    {
        public int PptId { get; set; }
        public int KindId { get; set; }
        public string PptName { get; set; }
        public int? PptType { get; set; }
        public string Description { get; set; }
    }
}

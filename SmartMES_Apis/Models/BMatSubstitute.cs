using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMatSubstitute
    {
        public int Id { get; set; }
        public string BomCode { get; set; }
        public string MatCode { get; set; }
        public string SubstituteMatCode { get; set; }
    }
}

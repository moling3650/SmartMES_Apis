using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMatAutoSend
    {
        public int Id { get; set; }
        public string ProcessCode { get; set; }
        public string MatCode { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcessControlItem
    {
        public int Id { get; set; }
        public string ControlName { get; set; }
        public string ProcessCode { get; set; }
        public DateTime InputTime { get; set; }
        public string Description { get; set; }
    }
}

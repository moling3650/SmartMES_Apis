using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BWorkGroupClassRest
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string Description { get; set; }
    }
}

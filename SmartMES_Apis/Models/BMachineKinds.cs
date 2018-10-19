using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineKinds
    {
        public int KindId { get; set; }
        public int TypeId { get; set; }
        public string KindName { get; set; }
        public string Description { get; set; }
    }
}

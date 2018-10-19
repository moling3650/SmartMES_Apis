using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineAccessories
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public int? AccessoryType { get; set; }
        public string AccessoryCode { get; set; }
        public int? AccessoryState { get; set; }
        public int? AccessoryIsload { get; set; }
        public int? AccessoryCount { get; set; }
        public string Description { get; set; }
    }
}

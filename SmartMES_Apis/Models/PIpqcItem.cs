using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PIpqcItem
    {
        public int ItemId { get; set; }
        public string CheckItemCode { get; set; }
        public string CheckItemName { get; set; }
        public string ProcessCode { get; set; }
        public int Type { get; set; }
        public string Comment { get; set; }
    }
}

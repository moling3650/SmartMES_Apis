using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PBarCodeBing
    {
        public int Id { get; set; }
        public string Order { get; set; }
        public string ParentOrder { get; set; }
        public string MainOrder { get; set; }
        public string Barcode { get; set; }
        public int? State { get; set; }
        public string ProductCode { get; set; }
        public DateTime? InputTime { get; set; }
    }
}

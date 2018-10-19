using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BNgReason
    {
        public int Id { get; set; }
        public string Typecode { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonName { get; set; }
        public string Description { get; set; }
    }
}

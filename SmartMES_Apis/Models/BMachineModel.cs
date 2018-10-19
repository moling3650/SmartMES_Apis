using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineModel
    {
        public int Id { get; set; }
        public string ModelCode { get; set; }
        public int? KindId { get; set; }
        public string Manufacturer { get; set; }
        public string MadeIn { get; set; }
        public string Description { get; set; }
    }
}

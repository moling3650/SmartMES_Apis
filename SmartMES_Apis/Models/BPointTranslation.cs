using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BPointTranslation
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public string Val { get; set; }
        public int? PointId { get; set; }
    }
}

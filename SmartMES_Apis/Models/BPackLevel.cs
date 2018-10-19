using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BPackLevel
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string LvlName { get; set; }
        public int? ParentId { get; set; }
        public int? CodeType { get; set; }
        public string PackRole { get; set; }
        public decimal? PackNum { get; set; }
        public int? WholePack { get; set; }
        public int? DoPrint { get; set; }
        public string PrintTempLate { get; set; }
        public DateTime? InputTime { get; set; }
    }
}

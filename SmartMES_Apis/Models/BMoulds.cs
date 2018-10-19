using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMoulds
    {
        public int Id { get; set; }
        public string MouldCode { get; set; }
        public string MouldName { get; set; }
        public string ModelCode { get; set; }
        public int? TypeId { get; set; }
        public string Supplier { get; set; }
        public int? State { get; set; }
        public DateTime? InputTime { get; set; }
        public string Description { get; set; }
        public string StationCode { get; set; }
        public string MachineCode { get; set; }
    }
}

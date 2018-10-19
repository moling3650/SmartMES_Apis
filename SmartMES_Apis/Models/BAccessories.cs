using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BAccessories
    {
        public int Id { get; set; }
        public string AccessoryCode { get; set; }
        public string AccessoryName { get; set; }
        public string Model { get; set; }
        public int? TypeId { get; set; }
        public int? MaintianType { get; set; }
        public int? MaintainCycle { get; set; }
        public DateTime? MaintainNexttime { get; set; }
        public decimal? Userqty { get; set; }
        public int? MaintainQuality { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? Arrivaldate { get; set; }
        public int? State { get; set; }
        public string WsCode { get; set; }
        public string Description { get; set; }
    }
}

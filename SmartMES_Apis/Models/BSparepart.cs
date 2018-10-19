using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BSparepart
    {
        public int Id { get; set; }
        public string SparepartCode { get; set; }
        public string SparepartName { get; set; }
        public int? TypeId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? Arrivaldate { get; set; }
        public string Ofmachine { get; set; }
        public string WsCode { get; set; }
        public string Description { get; set; }
    }
}

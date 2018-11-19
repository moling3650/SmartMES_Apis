using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachine
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public string ModelCode { get; set; }
        public string MachineName { get; set; }
        public string SimpleName { get; set; }
        public int? TypeId { get; set; }
        public int? State { get; set; }
        public string UseState { get; set; }
        public decimal? ProcessingQty { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? Arrivaldate { get; set; }
        public DateTime? ExpectNexttime { get; set; }
        public string Department { get; set; }
        public string WsCode { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}

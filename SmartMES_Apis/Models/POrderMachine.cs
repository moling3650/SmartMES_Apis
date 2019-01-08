using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class POrderMachine
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string FatherOrder { get; set; }
        public string MainOrder { get; set; }
        public string DiispatchingNo { get; set; }
        public string Sfc { get; set; }
        public string MachineCode { get; set; }
        public string ProductCode { get; set; }
        public DateTime? Inputdate { get; set; }
        public DateTime? InputTime { get; set; }
        public string EmpCode { get; set; }
    }
}

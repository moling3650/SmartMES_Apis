using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineFaultreason
    {
        public int Id { get; set; }
        public string FaultReasoncode { get; set; }
        public string FaultReasonname { get; set; }
        public string Model { get; set; }
        public string Remarks { get; set; }
    }
}

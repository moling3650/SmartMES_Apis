using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineStopreason
    {
        public int Id { get; set; }
        public string StopreasonCode { get; set; }
        public string StopreasonName { get; set; }
        public int? StopreasonType { get; set; }
        public int? StopState { get; set; }
        public string Remarks { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMachineFaultphenomenon
    {
        public int Id { get; set; }
        public string FaultphenomenonCode { get; set; }
        public string FaultphenomenonName { get; set; }
        public string Model { get; set; }
        public string Remarks { get; set; }
    }
}

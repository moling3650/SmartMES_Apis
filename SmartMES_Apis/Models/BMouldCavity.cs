using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMouldCavity
    {
        public int Id { get; set; }
        public string MouldCode { get; set; }
        public string PedigreeCode { get; set; }
        public decimal? ProductGrams { get; set; }
        public decimal? RunnerGrams { get; set; }
        public int? CavityNum { get; set; }
        public int? State { get; set; }
        public string Description { get; set; }
    }
}

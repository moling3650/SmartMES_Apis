using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcessSonStep
    {
        public int Id { get; set; }
        public string FlowCode { get; set; }
        public string Parentstepid { get; set; }
        public string Stepid { get; set; }
        public string Steppre { get; set; }
        public string Steperror { get; set; }
        public string Stepname { get; set; }
        public int Steptype { get; set; }
        public int Idx { get; set; }
        public int? Back1 { get; set; }
        public string Back2 { get; set; }
    }
}

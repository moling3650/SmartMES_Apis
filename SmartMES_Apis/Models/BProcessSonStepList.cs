using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProcessSonStepList
    {
        public int Id { get; set; }
        public int Parentstepid { get; set; }
        public int Stepid { get; set; }
        public string Stepname { get; set; }
        public int? Steptype { get; set; }
        public int? Idx { get; set; }
        public int? Back1 { get; set; }
        public string Back2 { get; set; }
    }
}

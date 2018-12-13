using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BPedigree
    {
        public int Id { get; set; }
        public string PedigreeCode { get; set; }
        public string PedigreeName { get; set; }
        public string ProductTypeCode { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BToolParameter
    {
        public int Id { get; set; }
        public string ParameterName { get; set; }
        public string Value { get; set; }
        public string ToolCode { get; set; }
        public string Description { get; set; }
    }
}

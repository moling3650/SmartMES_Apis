using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BTool
    {
        public int Id { get; set; }
        public string ToolCode { get; set; }
        public string ToolName { get; set; }
        public int? TypeId { get; set; }
        public string Model { get; set; }
        public int? WorkflowId { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? Arrivaldate { get; set; }
        public string Description { get; set; }
    }
}

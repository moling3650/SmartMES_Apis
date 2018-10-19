using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class SModuleInRole
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public int? ModuleCode { get; set; }
    }
}

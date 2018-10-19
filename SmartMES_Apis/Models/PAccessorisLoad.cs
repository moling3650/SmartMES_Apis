using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PAccessorisLoad
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public string AccessoryCode { get; set; }
        public string AccessoryName { get; set; }
        public int? AccessoryType { get; set; }
        public string Description { get; set; }

        public PAccessorisLoad IdNavigation { get; set; }
        public PAccessorisLoad InverseIdNavigation { get; set; }
    }
}

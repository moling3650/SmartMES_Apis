using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMachineMouldInstall
    {
        public int Id { get; set; }
        public string MachineCode { get; set; }
        public string MouldCode { get; set; }
        public DateTime? InstallTime { get; set; }
        public string EmpCode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BDisposalProcess
    {
        public int Id { get; set; }
        public string DisposalCode { get; set; }
        public string DisposalName { get; set; }
        public string ProcName { get; set; }
        public string Description { get; set; }
    }
}

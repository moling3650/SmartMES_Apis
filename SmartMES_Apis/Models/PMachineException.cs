using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMachineException
    {
        public int Id { get; set; }
        public Guid ExceptionCode { get; set; }
        public string FaultphenomenonCode { get; set; }
        public string MachineCode { get; set; }
        public int? State { get; set; }
        public string Grade { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string SubmitPerson { get; set; }
        public bool Isdelete { get; set; }
        public string Remarks { get; set; }
    }
}

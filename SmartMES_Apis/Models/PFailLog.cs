using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PFailLog
    {
        public int Fid { get; set; }
        public string Fguid { get; set; }
        public string OrderNo { get; set; }
        public string Sfc { get; set; }
        public string FromProcess { get; set; }
        public string FromStation { get; set; }
        public string FromEmp { get; set; }
        public string ProcessCode { get; set; }
        public string DisposalProcess { get; set; }
        public int? FailTimes { get; set; }
        public int? State { get; set; }
        public DateTime? InputTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string EmpCode { get; set; }
        public decimal? Qty { get; set; }
        public string NgRemark { get; set; }
        public string RepairRemark { get; set; }
        public DateTime? PDate { get; set; }
        public string WsCode { get; set; }
        public string EquipmentCode { get; set; }
        public string ClassCode { get; set; }
    }
}

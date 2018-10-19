using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BSopimage
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Url { get; set; }
        public string EmpCode { get; set; }
        public DateTime? InputTime { get; set; }
        public string Description { get; set; }
    }
}

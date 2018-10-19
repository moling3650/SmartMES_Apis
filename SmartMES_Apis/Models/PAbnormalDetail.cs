using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PAbnormalDetail
    {
        public int Id { get; set; }
        public int? AbnormalId { get; set; }
        public string Soluntion { get; set; }
        public string Reason { get; set; }
        public string Prevent { get; set; }
        public string PreventDepart { get; set; }
        public DateTime? PreventDate { get; set; }
        public DateTime? InputTime { get; set; }
    }
}

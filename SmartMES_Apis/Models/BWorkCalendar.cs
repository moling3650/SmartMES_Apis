using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BWorkCalendar
    {
        public int Id { get; set; }
        public string GroupCode { get; set; }
        public DateTime Day { get; set; }
        public string Classes { get; set; }
        public string WorkTime { get; set; }
    }
}

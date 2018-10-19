using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BMatManagement
    {
        public int Id { get; set; }
        public string MatCode { get; set; }
        public decimal? InputHour { get; set; }
        public decimal? FeedHour { get; set; }
    }
}

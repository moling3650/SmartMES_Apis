using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PMatManagementDetail
    {
        public int Id { get; set; }
        public string LotNo { get; set; }
        public string FeedOrder { get; set; }
        public string FeedStation { get; set; }
        public DateTime? FeedTime { get; set; }
        public DateTime? ShutTime { get; set; }
    }
}

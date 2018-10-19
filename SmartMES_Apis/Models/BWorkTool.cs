using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BWorkTool
    {
        public int Id { get; set; }
        public string WorkToolCode { get; set; }
        public string WorkToolName { get; set; }
        public string Supplier { get; set; }
        public int? State { get; set; }
        public string ModelCode { get; set; }
        public string StorageRoom { get; set; }
        public string StorePlace { get; set; }
        public string UsePlace { get; set; }
        public string Description { get; set; }
    }
}

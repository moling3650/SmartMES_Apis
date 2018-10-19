using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PRework
    {
        public int Id { get; set; }
        public string ReworkLot { get; set; }
        public string Model { get; set; }
        public string ProductType { get; set; }
        public string Workshop { get; set; }
        public string Process { get; set; }
        public int? Qty { get; set; }
        public string NgItem { get; set; }
        public string ReworkPerson { get; set; }
        public string Applicants { get; set; }
    }
}

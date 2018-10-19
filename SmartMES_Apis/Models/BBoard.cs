using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BBoard
    {
        public int Id { get; set; }
        public string BoardCode { get; set; }
        public string BoardName { get; set; }
        public string BoardIp { get; set; }
        public string WsCode { get; set; }
        public string ProcessCode { get; set; }
        public string Description { get; set; }
    }
}

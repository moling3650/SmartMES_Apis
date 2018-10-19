using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public string TransCode { get; set; }
        public string Description { get; set; }
    }
}

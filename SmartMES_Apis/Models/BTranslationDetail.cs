using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BTranslationDetail
    {
        public int Id { get; set; }
        public string TransCode { get; set; }
        public string FromValue { get; set; }
        public string ToValue { get; set; }
        public string Parameter { get; set; }
    }
}

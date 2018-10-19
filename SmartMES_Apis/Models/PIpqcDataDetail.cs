using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class PIpqcDataDetail
    {
        public int Id { get; set; }
        public int QcId { get; set; }
        public int TemplateId { get; set; }
        public string Value { get; set; }
        public int? Result { get; set; }
        public string Remarks { get; set; }
    }
}

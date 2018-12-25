using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BDataTranslation
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public int? Value { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
    }
}

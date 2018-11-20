using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class BProductGrade
    {
        public int GradeId { get; set; }
        public string TypeCode { get; set; }
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
        public string GradeType { get; set; }
        public string Idx { get; set; }
        public string Description { get; set; }
        public string Parameter { get; set; }
    }
}

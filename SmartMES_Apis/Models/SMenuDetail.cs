using System;
using System.Collections.Generic;

namespace SmartMES_Apis.Models
{
    public partial class SMenuDetail
    {
        public int Id { get; set; }
        public int? MenuId { get; set; }
        public string MenuName { get; set; }
        public int? ModuleCode { get; set; }
        public int? IsRoot { get; set; }
        public int? ParentId { get; set; }
        public string LevelCode { get; set; }
        public string Icon { get; set; }
        public int? Leaf { get; set; }
        public int? SortVal { get; set; }
        public int? MenuType { get; set; }
    }
}

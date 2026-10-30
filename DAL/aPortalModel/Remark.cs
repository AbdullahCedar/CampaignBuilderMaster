using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class Remark
    {
        public int RemarkId { get; set; }
        public string? RemarksDescription { get; set; }
        public string? OpId { get; set; }
        public int? TaskId { get; set; }
        public DateTime? RemarkDateTime { get; set; }
    }
}

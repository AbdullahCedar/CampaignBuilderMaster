using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyTotalCall
    {
        public int Id { get; set; }
        public TimeSpan? TcCtime { get; set; }
        public DateTime? TcCdate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public int? TotalCalls { get; set; }
    }
}

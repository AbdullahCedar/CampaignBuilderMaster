using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyRevenue
    {
        public int Id { get; set; }
        public TimeSpan? RevCtime { get; set; }
        public DateTime? RevDate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public decimal? OpRevenue { get; set; }
    }
}

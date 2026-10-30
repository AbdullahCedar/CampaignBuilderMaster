using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyPerToGoal
    {
        public int Id { get; set; }
        public TimeSpan? Ctime { get; set; }
        public DateTime? Cdate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public decimal? PerToGoal { get; set; }
    }
}

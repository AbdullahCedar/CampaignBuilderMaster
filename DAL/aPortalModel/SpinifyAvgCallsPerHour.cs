using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyAvgCallsPerHour
    {
        public int Id { get; set; }
        public TimeSpan? AcCtime { get; set; }
        public DateTime? AcDate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public decimal? AvgCallsPerHour { get; set; }
    }
}

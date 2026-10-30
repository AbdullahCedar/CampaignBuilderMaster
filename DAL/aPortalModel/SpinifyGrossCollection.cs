using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyGrossCollection
    {
        public int Id { get; set; }
        public long? GcRowid { get; set; }
        public DateTime? GcCdate { get; set; }
        public TimeSpan? GcCtime { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public decimal? OpGrossCollection { get; set; }
    }
}

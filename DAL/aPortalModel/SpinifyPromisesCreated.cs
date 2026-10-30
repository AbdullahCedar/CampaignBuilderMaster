using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyPromisesCreated
    {
        public int Id { get; set; }
        public TimeSpan? PcCtime { get; set; }
        public DateTime? PcCdate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public int? PromisesCreated { get; set; }
    }
}

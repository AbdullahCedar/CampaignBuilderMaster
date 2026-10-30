using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class ThrioCompainDispositionLog
    {
        public int Id { get; set; }
        public DateTime? DateD { get; set; }
        public string? Label { get; set; }
        public string? Campaign { get; set; }
        public string? Disposition { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Duration { get; set; }
    }
}

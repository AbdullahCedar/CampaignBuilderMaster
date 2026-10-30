using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class IbLog
    {
        public int Id { get; set; }
        public string IbId { get; set; } = null!;
        public string EventType { get; set; } = null!;
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
        public string? Status { get; set; }
    }
}

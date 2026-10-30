using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class ThrioCallDetail
    {
        public int Id { get; set; }
        public DateTime? Cdate { get; set; }
        public string? Label { get; set; }
        public string? Type { get; set; }
        public string? Agentname { get; set; }
        public string? Disposition { get; set; }
        public string? CallId { get; set; }
        public long? CreatedAt { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public long? IvrTime { get; set; }
        public long? HandleTime { get; set; }
        public long Duration { get; set; }
        public long? Minutes { get; set; }
        public long? Total { get; set; }
        public long? TotalQueueTime { get; set; }
        public long? TalkTime { get; set; }
        public long? WrapupTime { get; set; }
        public long? InReviewTime { get; set; }
        public long? RingTime { get; set; }
        public decimal? Cost { get; set; }
        public long? RecordingDuration { get; set; }
        public string? File { get; set; }
        public long? HoldTime { get; set; }
        public long? AbandonTime { get; set; }
        public long? Transferred { get; set; }
    }
}

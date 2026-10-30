using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class Test
    {
        public string? Name { get; set; }
        public string? CallId { get; set; }
        public string? Agent { get; set; }
        public string? CreatedAt { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Type { get; set; }
        public string? Total { get; set; }
        public string? Disposition { get; set; }
        public string? InReviewTime { get; set; }
        public string? RingTime { get; set; }
        public string? IvrTime { get; set; }
        public string? TotalQueueTime { get; set; }
        public string? TalkTime { get; set; }
        public string? HoldTime { get; set; }
        public string? AbandonTime { get; set; }
        public string? Transferred { get; set; }
        public string? Duration { get; set; }
        public string? Minutes { get; set; }
        public string? WrapupTime { get; set; }
        public string? HandleTime { get; set; }
        public string? Queue { get; set; }
        public string? FileNum { get; set; }
    }
}

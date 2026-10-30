using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class ThrioAgentRpcDetail
    {
        public int Id { get; set; }
        public DateTime? DateB { get; set; }
        public string? Label { get; set; }
        public int? Total { get; set; }
        public int? TotalRpccalls { get; set; }
        public int? TotalRpccloseCalls { get; set; }
        public decimal? PercentageRpccalls { get; set; }
        public decimal? PercentageRpccloseRate { get; set; }
        public decimal? AvgTalkTime { get; set; }
        public decimal? AvgWrapupTime { get; set; }
        public long? TalkTime { get; set; }
        public long? WrapupTime { get; set; }
        public decimal? TotalWorkinghours { get; set; }
        public decimal? AvgCallsPerHour { get; set; }
    }
}

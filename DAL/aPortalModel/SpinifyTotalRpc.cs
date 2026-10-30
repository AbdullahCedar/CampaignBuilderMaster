using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyTotalRpc
    {
        public int Id { get; set; }
        public TimeSpan? TrpcCtime { get; set; }
        public DateTime? TrpcCdate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public int? TotalRpc { get; set; }
    }
}

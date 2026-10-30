using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyRpcClosedRate
    {
        public int Id { get; set; }
        public TimeSpan? RcCtime { get; set; }
        public DateTime? RclrateCdate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public decimal? RpcClosedRate { get; set; }
    }
}

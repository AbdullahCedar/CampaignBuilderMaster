using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyRpcClosed
    {
        public int Id { get; set; }
        public TimeSpan? RclCtime { get; set; }
        public DateTime? RclCdate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public int? RpcClosed { get; set; }
    }
}

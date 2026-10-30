using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class PlacementTable
    {
        public int Id { get; set; }
        public long? DeRowidClient { get; set; }
        public DateTime? DeListedDate { get; set; }
        public DateTime? _2ndListedDate { get; set; }
        public int? ClNumber { get; set; }
        public string? ClOp2 { get; set; }
        public string? ClOp1 { get; set; }
        public string? ClName { get; set; }
        public int? ClOwnedbyNumber { get; set; }
        public int? ClNumOfActiveAccounts { get; set; }
        public int? TotalAccounts { get; set; }
        public DateTime? ClListedDate { get; set; }
    }
}

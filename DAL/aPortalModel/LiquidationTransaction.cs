using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class LiquidationTransaction
    {
        public int Id { get; set; }
        public decimal? WeeklyRcvrdAmnt { get; set; }
        public decimal? MnthlyRcvrdAmnt { get; set; }
        public int? ClientNumber { get; set; }
        public string? WeekDate { get; set; }
    }
}

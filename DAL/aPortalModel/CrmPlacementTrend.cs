using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class CrmPlacementTrend
    {
        public int Id { get; set; }
        public DateTime? Cdate { get; set; }
        public long? ClientRowId { get; set; }
        public int? ClientNumber { get; set; }
        public string? ClientName { get; set; }
        public string? CrmOperator { get; set; }
        public string? Ribbon { get; set; }
        public decimal? SuccessRate { get; set; }
        public string? Score { get; set; }
        public int? ActiveAcct { get; set; }
        public decimal? ActiveAcctPrincipal { get; set; }
        public int? TotalAcct { get; set; }
        public decimal? TotalAcctPrincipal { get; set; }
        public DateTime? FirstPlacement { get; set; }
        public DateTime? LastPlacement { get; set; }
        public int? TrendsAvg { get; set; }
        public int? PastDue { get; set; }
        public decimal? EcvOfPlacement { get; set; }
        public decimal? EcvPerAnum { get; set; }
        public decimal? EarnFeePerAnum { get; set; }
        public decimal? AvgAcctPerPlacement { get; set; }
        public decimal? AvgPrincipalPerPlacement { get; set; }
    }
}

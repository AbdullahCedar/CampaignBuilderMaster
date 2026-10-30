using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class ClientTrend
    {
        public DateTime? Cdate { get; set; }
        public double? ClientRowId { get; set; }
        public double? ClientNumber { get; set; }
        public string? ClientName { get; set; }
        public string? CrmOperator { get; set; }
        public string? Ribbon { get; set; }
        public double? SuccessRate { get; set; }
        public string? Score { get; set; }
        public double? ActiveAcct { get; set; }
        public double? TotalAcct { get; set; }
        public decimal? ActiveAcctPrincipal { get; set; }
        public decimal? TotalAcctPrincipal { get; set; }
        public decimal? EarnFeePerAnum { get; set; }
        public double? EcvOfPlacement { get; set; }
        public DateTime? FirstPlacement { get; set; }
        public DateTime? LastPlacement { get; set; }
        public double? TrendsAvg { get; set; }
        public double? PastDue { get; set; }
        public decimal? AvgPrincipalPerPlacement { get; set; }
        public double? AvgAcctPerPlacement { get; set; }
    }
}

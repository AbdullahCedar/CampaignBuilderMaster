using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class EcvOfPlacement
    {
        public int Id { get; set; }
        public DateTime? EcvCdate { get; set; }
        public DateTime? ClientCreatedDate { get; set; }
        public long? ClientRowId { get; set; }
        public int? ClientNumber { get; set; }
        public string? ClientName { get; set; }
        public decimal? ClientSuccesRate { get; set; }
        public int? ClientRibbon { get; set; }
        public int? ClientSector { get; set; }
        public decimal? ClientPaid { get; set; }
        public decimal? SectorSuccessRate { get; set; }
        public decimal? CommissionToDate { get; set; }
        public decimal? Fee { get; set; }
        public decimal? FeeA { get; set; }
        public int? TotalAcc { get; set; }
        public decimal TotalValue { get; set; }
        public decimal? CntractValue { get; set; }
        public decimal? EcvOfPlacmentPerAnum { get; set; }
        public decimal? EcvOfPlacment { get; set; }
        public decimal? Success { get; set; }
        public int? CountYear { get; set; }
        public decimal? Ecv { get; set; }
        public string? SalesOp { get; set; }
        public string? CrmOp { get; set; }
        public string? OpType { get; set; }
    }
}

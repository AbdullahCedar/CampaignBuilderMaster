using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class TransactionType
    {
        public long TtRowid { get; set; }
        public long? TtUid { get; set; }
        public DateTime? TtCdate { get; set; }
        public TimeSpan? TtCtime { get; set; }
        public string? TtCby { get; set; }
        public DateTime? TtMdate { get; set; }
        public TimeSpan? TtMtime { get; set; }
        public string? TtMby { get; set; }
        public int? TtUidm { get; set; }
        public string? TtCode { get; set; }
        public string? TtDescription { get; set; }
        public short? TtAccount { get; set; }
        public short? TtFlags { get; set; }
        public string? TtPlan { get; set; }
        public decimal? TtToAgency { get; set; }
        public decimal? TtDirect { get; set; }
        public decimal? TtCommission { get; set; }
        public decimal? TtCommissionRate1 { get; set; }
        public decimal? TtCommissionRate2 { get; set; }
        public decimal? TtCommissionRate3 { get; set; }
        public int? TtCommRateOptions { get; set; }
        public decimal? TtTax { get; set; }
        public decimal? TtTax1 { get; set; }
        public decimal? TtTax2 { get; set; }
        public decimal? TtTax3 { get; set; }
        public int? TtTaxOptions { get; set; }
        public decimal? TtAdjustment { get; set; }
        public decimal? TtFees { get; set; }
        public decimal? TtInterest { get; set; }
        public decimal? TtPrincipal { get; set; }
        public decimal? TtLegal { get; set; }
        public decimal? TtMisc { get; set; }
        public decimal? TtOther { get; set; }
        public decimal? TtCommissionRate { get; set; }
        public decimal? TtCommRatePrinc { get; set; }
        public decimal? TtCommRateInt { get; set; }
        public decimal? TtCommRateFees { get; set; }
        public decimal? TtCommRateLegal { get; set; }
        public decimal? TtCommRateMisc { get; set; }
        public decimal? TtCommRateOther { get; set; }
        public string? TtOperator { get; set; }
        public string? TtSales { get; set; }
        public short? TtOptions { get; set; }
        public short? TtAssignmentFlag { get; set; }
        public short? TtHideTousDirect { get; set; }
        public byte? TtCalcType { get; set; }
        public short? TtCategory { get; set; }
        public short? TtCategory1 { get; set; }
        public short? TtCategory2 { get; set; }
        public string? TtDepositTo { get; set; }
        public string? TtWithdrawFrom { get; set; }
        public decimal? TtPercent1 { get; set; }
        public decimal? TtPercent2 { get; set; }
        public int? TtNumber1 { get; set; }
        public int? TtNumber2 { get; set; }
        public DateTime? TtDate1 { get; set; }
        public DateTime? TtDate2 { get; set; }
        public short? TtFlags1 { get; set; }
        public short? TtFlags2 { get; set; }
        public string? TtOp1 { get; set; }
        public string? TtOp2 { get; set; }
    }
}

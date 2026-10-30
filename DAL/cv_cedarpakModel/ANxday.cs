using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class ANxday
    {
        public long DaRowid { get; set; }
        public long? DaUid { get; set; }
        public DateTime? DaCdate { get; set; }
        public TimeSpan? DaCtime { get; set; }
        public string? DaCby { get; set; }
        public DateTime? DaMdate { get; set; }
        public TimeSpan? DaMtime { get; set; }
        public string? DaMby { get; set; }
        public int? DaUidm { get; set; }
        public DateTime? DaDate { get; set; }
        public int? DaNumberOfListings { get; set; }
        public decimal? DaPaid { get; set; }
        public decimal? DaPromised { get; set; }
        public decimal? DaTotal { get; set; }
        public decimal? DaCommission { get; set; }
        public decimal? DaMonthToDate { get; set; }
        public decimal? DaClientPayments { get; set; }
        public decimal? DaTotalListed { get; set; }
        public short? DaContacts { get; set; }
        public short? DaMailings { get; set; }
        public short? DaCalls { get; set; }
        public short? DaReviews { get; set; }
        public short? DaOthers { get; set; }
        public short? DaCallsRemaining { get; set; }
        public short? DaReviewsRemaining { get; set; }
        public short? DaOthersRemaining { get; set; }
        public short? DaRemainingContacts { get; set; }
        public short? DaRemainingMailings { get; set; }
        public string? DaBuffer1 { get; set; }
        public string? DaBuffer2 { get; set; }
        public short? DaCategory { get; set; }
        public short? DaCategory1 { get; set; }
        public short? DaCategory2 { get; set; }
        public decimal? DaPrincipal { get; set; }
        public decimal? DaInterest { get; set; }
        public decimal? DaFees { get; set; }
        public decimal? DaLegal { get; set; }
        public decimal? DaMisc { get; set; }
        public decimal? DaOther { get; set; }
        public decimal? DaDebtPrincipal { get; set; }
        public decimal? DaDebtInterest { get; set; }
        public decimal? DaDebtFees { get; set; }
        public decimal? DaDebtLegal { get; set; }
        public decimal? DaDebtMisc { get; set; }
        public decimal? DaDebtOther { get; set; }
        public decimal? DaCommPrincipal { get; set; }
        public decimal? DaCommInterest { get; set; }
        public decimal? DaCommFees { get; set; }
        public short? DaCommLegal { get; set; }
        public decimal? DaCommMisc { get; set; }
        public decimal? DaCommOther { get; set; }
        public decimal? DaTaxPrincipal { get; set; }
        public decimal? DaTaxInterest { get; set; }
        public decimal? DaTaxFees { get; set; }
        public decimal? DaTaxLegal { get; set; }
        public decimal? DaTaxMisc { get; set; }
        public decimal? DaTaxOther { get; set; }
        public decimal? DaAmount1 { get; set; }
        public decimal? DaAmount2 { get; set; }
        public decimal? DaPercent1 { get; set; }
        public decimal? DaPercent2 { get; set; }
        public int? DaNumber1 { get; set; }
        public int? DaNumber2 { get; set; }
        public DateTime? DaDate1 { get; set; }
        public DateTime? DaDate2 { get; set; }
        public short? DaFlags1 { get; set; }
        public short? DaFlags2 { get; set; }
        public string? DaOp1 { get; set; }
        public string? DaOp2 { get; set; }
    }
}

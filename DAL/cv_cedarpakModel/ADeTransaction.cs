using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class ADeTransaction
    {
        public ADeTransaction()
        {
            AInvoiceLines = new HashSet<AInvoiceLine>();
        }

        public long TrRowid { get; set; }
        public long? TrRowidDebtor { get; set; }
        public long? TrUid { get; set; }
        public DateTime? TrCdate { get; set; }
        public TimeSpan? TrCtime { get; set; }
        public string? TrCby { get; set; }
        public DateTime? TrMdate { get; set; }
        public TimeSpan? TrMtime { get; set; }
        public string? TrMby { get; set; }
        public int? TrUidm { get; set; }
        public long? TrUido { get; set; }
        public short? TrId { get; set; }
        public short? TrPaymentTypeFlag { get; set; }
        public short? TrAccount { get; set; }
        public string? TrType { get; set; }
        public string? TrWho { get; set; }
        public string? TrSales { get; set; }
        public string? TrDescription { get; set; }
        public decimal? TrToAgency { get; set; }
        public decimal? TrToClient { get; set; }
        public decimal? TrCommissionRate { get; set; }
        public decimal? TrCommissionRate1 { get; set; }
        public decimal? TrCommissionRate2 { get; set; }
        public decimal? TrCommissionRate3 { get; set; }
        public int? TrCommRateOption { get; set; }
        public decimal? TrCommissionAmount { get; set; }
        public decimal? TrCommPrinc { get; set; }
        public decimal? TrCommInterest { get; set; }
        public decimal? TrCommFees { get; set; }
        public decimal? TrCommLegal { get; set; }
        public decimal? TrCommMisc { get; set; }
        public decimal? TrCommOther { get; set; }
        public decimal? TrTaxRate { get; set; }
        public decimal? TrTaxRate1 { get; set; }
        public decimal? TrTaxRate2 { get; set; }
        public decimal? TrTaxRate3 { get; set; }
        public int? TrTaxOptions { get; set; }
        public decimal? TrTaxAmount { get; set; }
        public decimal? TrTaxPrincipal { get; set; }
        public decimal? TrTaxInt { get; set; }
        public decimal? TrTaxFees { get; set; }
        public decimal? TrTaxLegal { get; set; }
        public decimal? TrTaxMisc { get; set; }
        public decimal? TrTaxOther { get; set; }
        public decimal? TrPrincipal { get; set; }
        public decimal? TrInterest { get; set; }
        public decimal? TrFee { get; set; }
        public decimal? TrLegal { get; set; }
        public decimal? TrMisc { get; set; }
        public decimal? TrOther { get; set; }
        public decimal? TrAdjustment { get; set; }
        public decimal? TrBucket5 { get; set; }
        public decimal? TrBucket6 { get; set; }
        public decimal? TrBucket7 { get; set; }
        public decimal? TrBucket8 { get; set; }
        public decimal? TrBucket9 { get; set; }
        public decimal? TrBucket10 { get; set; }
        public decimal? TrBucket11 { get; set; }
        public decimal? TrBucket12 { get; set; }
        public decimal? TrBucket13 { get; set; }
        public decimal? TrBucket14 { get; set; }
        public decimal? TrBucket15 { get; set; }
        public decimal? TrBucket16 { get; set; }
        public decimal? TrExchangeRate { get; set; }
        public short? TrFlags { get; set; }
        public int? TrSwitches { get; set; }
        public DateTime? TrPaymentDate { get; set; }
        public TimeSpan? TrPaymentTime { get; set; }
        public DateTime? TrPostedDate { get; set; }
        public TimeSpan? TrPostedTime { get; set; }
        public DateTime? TrPaymentDueDate { get; set; }
        public TimeSpan? TrPaymentDueTime { get; set; }
        public DateTime? TrConfirmationDate { get; set; }
        public TimeSpan? TrConfirmationTime { get; set; }
        public string? TrConfirmationNumber { get; set; }
        public DateTime? TrDepositedDate { get; set; }
        public TimeSpan? TrDepositedTime { get; set; }
        public string? TrDepositTo { get; set; }
        public string? TrWithdrawFrom { get; set; }
        public string? TrUser1 { get; set; }
        public string? TrUser2 { get; set; }
        public string? TrUser3 { get; set; }
        public string? TrUser4 { get; set; }
        public string? TrUser5 { get; set; }
        public string? TrUser6 { get; set; }
        public string? TrUser7 { get; set; }
        public string? TrAttachment { get; set; }
        public int? TrCurrency { get; set; }
        public int? TrToCurrency { get; set; }
        public int? TrReceiptNumber { get; set; }
        public int? TrInvoiceNumber { get; set; }
        public decimal? TrToCurrent { get; set; }
        public decimal? TrActual { get; set; }
        public decimal? TrReturn { get; set; }
        public decimal? TrDisbursement { get; set; }
        public short? TrCategory { get; set; }
        public short? TrCategory1 { get; set; }
        public short? TrCategory2 { get; set; }
        public decimal? TrPercent1 { get; set; }
        public decimal? TrPercent2 { get; set; }
        public int? TrNumber1 { get; set; }
        public int? TrNumber2 { get; set; }
        public DateTime? TrDate1 { get; set; }
        public DateTime? TrDate2 { get; set; }
        public short? TrFlags1 { get; set; }
        public short? TrFlags2 { get; set; }
        public string? TrOp1 { get; set; }
        public string? TrOp2 { get; set; }
        public decimal? TrAgencyExchangeRate { get; set; }
        public decimal? TrAgencyExchangeAmt { get; set; }
        public int? TrAgencyAcctCurrency { get; set; }
        public long? TrBlob { get; set; }
        public decimal? TrDeowingPrePayment { get; set; }
        public decimal? TrDeowingPostPayment { get; set; }

        public virtual Blob? TrBlobNavigation { get; set; }
        public virtual ADebtor? TrRowidDebtorNavigation { get; set; }
        public virtual ICollection<AInvoiceLine> AInvoiceLines { get; set; }
    }
}

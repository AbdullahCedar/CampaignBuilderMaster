using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
        }

        public long InRowid { get; set; }
        public long? InRowidClient { get; set; }
        public long? InUid { get; set; }
        public DateTime? InCdate { get; set; }
        public TimeSpan? InCtime { get; set; }
        public string? InCby { get; set; }
        public DateTime? InMdate { get; set; }
        public TimeSpan? InMtime { get; set; }
        public string? InMby { get; set; }
        public int? InUidm { get; set; }
        public long? InUido { get; set; }
        public int? InNumber { get; set; }
        public DateTime? InDate { get; set; }
        public decimal? InToUs { get; set; }
        public decimal? InDirect { get; set; }
        public decimal? InBalance { get; set; }
        public decimal? InCommissionRate { get; set; }
        public decimal? InCommission { get; set; }
        public decimal? InDue { get; set; }
        public decimal? InGst { get; set; }
        public decimal? InSubtotal { get; set; }
        public decimal? In30Days { get; set; }
        public decimal? In60Days { get; set; }
        public decimal? In90Days { get; set; }
        public decimal? In120Days { get; set; }
        public decimal? In150Days { get; set; }
        public decimal? InTotal { get; set; }
        public decimal? InReturned { get; set; }
        public int? InCheckNumber { get; set; }
        public int? InCurrency { get; set; }
        public short? InType { get; set; }
        public string? InGeneratedBy { get; set; }
        public DateTime? InFromDate { get; set; }
        public DateTime? InToDate { get; set; }
        public decimal? InTousComm { get; set; }
        public decimal? InTousTax { get; set; }
        public decimal? InDirectComm { get; set; }
        public decimal? InDirectTax { get; set; }
        public decimal? InAmount1 { get; set; }
        public decimal? InAmount2 { get; set; }
        public decimal? InPercent1 { get; set; }
        public decimal? InPercent2 { get; set; }
        public int? InNumber1 { get; set; }
        public int? InNumber2 { get; set; }
        public DateTime? InDate1 { get; set; }
        public DateTime? InDate2 { get; set; }
        public short? InFlags1 { get; set; }
        public short? InFlags2 { get; set; }
        public string? InOp1 { get; set; }
        public string? InOp2 { get; set; }

        public virtual Client? InRowidClientNavigation { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}

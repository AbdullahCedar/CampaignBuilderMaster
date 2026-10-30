using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class InvoiceLine
    {
        public long IlRowid { get; set; }
        public long? IlRowidInvoice { get; set; }
        public long? IlRowidDeTransaction { get; set; }
        public long? IlUid { get; set; }
        public DateTime? IlCdate { get; set; }
        public TimeSpan? IlCtime { get; set; }
        public string? IlCby { get; set; }
        public DateTime? IlMdate { get; set; }
        public TimeSpan? IlMtime { get; set; }
        public string? IlMby { get; set; }
        public int? IlUidm { get; set; }
        public long? IlUido { get; set; }
        public long? IlUido1 { get; set; }
        public int? IlNumber { get; set; }
        public int? IlDebtorNumber { get; set; }
        public string? IlDebtor { get; set; }
        public string? IlDescription { get; set; }
        public DateTime? IlDate { get; set; }
        public decimal? IlReturned { get; set; }
        public decimal? IlToUs { get; set; }
        public decimal? IlDirect { get; set; }
        public decimal? IlBalance { get; set; }
        public decimal? IlCommissionRate { get; set; }
        public decimal? IlCommission { get; set; }
        public decimal? IlTax { get; set; }

        public virtual DeTransaction? IlRowidDeTransactionNavigation { get; set; }
        public virtual Invoice? IlRowidInvoiceNavigation { get; set; }
    }
}

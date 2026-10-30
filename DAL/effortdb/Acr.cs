using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class Acr
    {
        public string? CustomerDebtorFile { get; set; }
        public string? TransactionType { get; set; }
        public string? CustomerCategory { get; set; }
        public DateTime? Date { get; set; }
        public string? InvoiceNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public int? Age { get; set; }
        public int? TotalAmount { get; set; }
        public int? AmountDue { get; set; }
        public string? ArUserNotes { get; set; }
    }
}

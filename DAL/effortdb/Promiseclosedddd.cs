using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class Promiseclosedddd
    {
        public string? By { get; set; }
        public string? ClientName { get; set; }
        public string? FileNumber { get; set; }
        public string? DebtorName { get; set; }
        public double? PromisedAmount { get; set; }
        public double? Paid { get; set; }
        public bool? Complete { get; set; }
        public bool? Broken { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? PromiseDate { get; set; }
        public int? Count { get; set; }
        public int Id { get; set; }
    }
}

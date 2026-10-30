using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class TransactionReport
    {
        public int Id { get; set; }
        public decimal? WeeklyRcvrdAmnt { get; set; }
        public decimal? MnthlyRcvrdAmnt { get; set; }
        public int? ClientNumber { get; set; }
        public DateTime? ListedDate { get; set; }
        public int? DirectPaymentCount { get; set; }
        public decimal? DirectPaymentSum { get; set; }
    }
}

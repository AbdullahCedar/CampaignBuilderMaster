using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class WaldenReport
    {
        public int Id { get; set; }
        public DateTime? ListedDate { get; set; }
        public int? NoOfActiveFiles { get; set; }
        public decimal? TotalActiveFilesAmount { get; set; }
        public int? NoOfPaidFiles { get; set; }
        public int? NoOfClosedFiles { get; set; }
        public int? NoOfDisputesFiles { get; set; }
        public int? ClientNumber { get; set; }
        public int? DirectPaymentCount { get; set; }
        public decimal? DirectPaymentSum { get; set; }
    }
}

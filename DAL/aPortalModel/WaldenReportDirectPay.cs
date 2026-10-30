using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class WaldenReportDirectPay
    {
        public int Id { get; set; }
        public DateTime? ListedDate { get; set; }
        public int? DirectPayCount { get; set; }
        public decimal? DirectPaySum { get; set; }
        public int? ClientNumber { get; set; }
    }
}

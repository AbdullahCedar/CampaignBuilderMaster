using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class Pending
    {
        public int Id { get; set; }
        public int? NoOfPendingPrmsFiles { get; set; }
        public decimal? PendingFilesAmnt { get; set; }
        public int? ClientNumber { get; set; }
        public DateTime? ListedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class LiquidatinDebtor
    {
        public int Id { get; set; }
        public string? WeekDate { get; set; }
        public int? NoOfActiveFiles { get; set; }
        public decimal? TotalActiveFilesAmount { get; set; }
        public int? NoOfPaidFiles { get; set; }
        public int? NoOfClosedFiles { get; set; }
        public int? NoOfDisputesFiles { get; set; }
        public int? ClientNumber { get; set; }
        public int? NewFiles { get; set; }
        public decimal? NewFilesBalance { get; set; }
        public int? OutPlacementsFiles { get; set; }
        public decimal? OutPlacementsBalance { get; set; }
    }
}

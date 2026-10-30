using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class Staffaug
    {
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public string? Crm { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? AvgAmount { get; set; }
        public int? ClentNumber { get; set; }
        public DateTime? Date { get; set; }
        public decimal? TotalAmountPkr { get; set; }
        public decimal? AvgAmountPkr { get; set; }
    }
}

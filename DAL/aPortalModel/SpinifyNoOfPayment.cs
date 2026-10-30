using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpinifyNoOfPayment
    {
        public int Id { get; set; }
        public TimeSpan? NpCtime { get; set; }
        public DateTime? NpCdate { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public string? OpEmail { get; set; }
        public int? NoOfPayment { get; set; }
    }
}

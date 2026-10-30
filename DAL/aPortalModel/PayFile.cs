using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class PayFile
    {
        public int Id { get; set; }
        public int? DeNumber { get; set; }
        public decimal? DePrincipal { get; set; }
        public string? DeStatus { get; set; }
        public string? DeName { get; set; }
        public decimal? DePaid { get; set; }
        public string? DeCountry { get; set; }
        public string? DeActive { get; set; }
        public string? DeCollector { get; set; }
        public DateTime? DeListedDate { get; set; }
        public DateTime? DeLastPaymentDate { get; set; }
        public DateTime? DeLastWorkedDate { get; set; }
        public decimal? CollectedAmnt { get; set; }
        public decimal? DeOwing { get; set; }
        public string? ClOp2 { get; set; }
        public int? ClNumber { get; set; }
        public string? ClName { get; set; }
    }
}

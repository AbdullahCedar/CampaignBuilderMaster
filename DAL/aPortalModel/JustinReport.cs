using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class JustinReport
    {
        public int Id { get; set; }
        public int? DeNumber { get; set; }
        public string? DeName { get; set; }
        public int? ClNumber { get; set; }
        public string? ClName { get; set; }
        public string? DeStatus { get; set; }
        public string? DeType { get; set; }
        public string? DeClAccount { get; set; }
        public DateTime? ListedDate { get; set; }
        public DateTime? DeChargeDate { get; set; }
        public DateTime? DeLastWorkedDate { get; set; }
        public string? DeHomePhone { get; set; }
        public string? DeWorkPhone { get; set; }
        public string? DeCellPhone { get; set; }
        public string? DeOtherPhone { get; set; }
        public string? DeEmail { get; set; }
        public decimal? DeOwing { get; set; }
        public int? PhType { get; set; }
        public string? State { get; set; }
    }
}

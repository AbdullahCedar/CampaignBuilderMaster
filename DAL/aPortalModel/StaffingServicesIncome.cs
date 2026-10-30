using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class StaffingServicesIncome
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public DateTime? Date { get; set; }
        public string? DocumentNumber { get; set; }
        public double? Amount { get; set; }
        public string? Name { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class Form1
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? JobTitle { get; set; }
        public string? Phone { get; set; }
        public string? DebtFrom { get; set; }
        public string? DebtLocation { get; set; }
        public string? TotalAccounts { get; set; }
        public string? Amount { get; set; }
        public string? Currency { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? HearOption { get; set; }
        public long? Notes { get; set; }
    }
}

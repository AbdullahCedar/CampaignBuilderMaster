using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class IbinvoiceLog
    {
        public int Id { get; set; }
        public string? AdminOrganizationId { get; set; }
        public string? AdminOrgName { get; set; }
        public string? EnterpriseName { get; set; }
        public string? EnterpriseId { get; set; }
        public string? PatientId { get; set; }
        public string? InvoiceId { get; set; }
        public string? SentToCollectionsAt { get; set; }
    }
}

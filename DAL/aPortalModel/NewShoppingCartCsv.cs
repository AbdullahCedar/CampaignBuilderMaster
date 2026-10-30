using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class NewShoppingCartCsv
    {
        public int Productid { get; set; }
        public string ServiceItem { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string? Type { get; set; }
        public string Description { get; set; } = null!;
        public decimal Cost { get; set; }
        public string? Requirements { get; set; }
        public string? CompletedBy { get; set; }
        public string NoitifyAccount { get; set; } = null!;
        public string NotifyMis { get; set; } = null!;
        public string NotifyDomestic { get; set; } = null!;
        public string NotifyCompliance { get; set; } = null!;
        public string NotifyCsm { get; set; } = null!;
        public string NotifyInternational { get; set; } = null!;
        public string InformationTech { get; set; } = null!;
        public string Column15 { get; set; } = null!;
    }
}

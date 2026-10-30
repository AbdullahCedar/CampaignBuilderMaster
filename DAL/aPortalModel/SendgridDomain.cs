using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SendgridDomain
    {
        public int SdId { get; set; }
        public string SdName { get; set; } = null!;
        public string SdDomains { get; set; } = null!;
    }
}

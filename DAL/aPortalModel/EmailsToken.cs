using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class EmailsToken
    {
        public long TokenId { get; set; }
        public string? FileNumber { get; set; }
        public string? DebtorEmail { get; set; }
        public string? EmailToken { get; set; }
    }
}

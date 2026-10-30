using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class TableCompAudit
    {
        public string? Date1 { get; set; }
        public string? TrType { get; set; }
        public string? Db { get; set; }
        public string? PayType { get; set; }
        public string? Amount { get; set; }
        public string? TrConfirmation { get; set; }
    }
}

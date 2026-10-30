using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class Note
    {
        public long NoRowid { get; set; }
        public long? NoRowidClient { get; set; }
        public long? NoRowidDebtor { get; set; }
        public string? NoText { get; set; }

        public virtual Client? NoRowidClientNavigation { get; set; }
        public virtual Debtor? NoRowidDebtorNavigation { get; set; }
    }
}

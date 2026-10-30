using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class ANote
    {
        public long NoRowid { get; set; }
        public long? NoRowidClient { get; set; }
        public long? NoRowidDebtor { get; set; }
        public string? NoText { get; set; }

        public virtual AClient? NoRowidClientNavigation { get; set; }
        public virtual ADebtor? NoRowidDebtorNavigation { get; set; }
    }
}

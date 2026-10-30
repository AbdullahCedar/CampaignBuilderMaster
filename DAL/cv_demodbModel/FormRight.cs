using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class FormRight
    {
        public long FrRowid { get; set; }
        public long? FrRowidApplicationForm { get; set; }
        public long? FrRowidOperatorLevel { get; set; }
        public long? FrUid { get; set; }
        public DateTime? FrCdate { get; set; }
        public TimeSpan? FrCtime { get; set; }
        public string? FrCby { get; set; }
        public DateTime? FrMdate { get; set; }
        public TimeSpan? FrMtime { get; set; }
        public string? FrMby { get; set; }
        public int? FrUidm { get; set; }
        public long? FrUido { get; set; }
        public long? FrUido1 { get; set; }
        public short? FrRights { get; set; }
        public string? FrAlias { get; set; }
        public string? FrMin { get; set; }
        public string? FrMax { get; set; }
        public string? FrPickListFile { get; set; }
        public short? FrUserlevel { get; set; }
        public int? FrFormnum { get; set; }

        public virtual ApplicationForm? FrRowidApplicationFormNavigation { get; set; }
        public virtual OperatorLevel? FrRowidOperatorLevelNavigation { get; set; }
    }
}

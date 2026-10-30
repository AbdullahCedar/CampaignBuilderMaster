using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class OperatorLevel
    {
        public OperatorLevel()
        {
            FormRights = new HashSet<FormRight>();
        }

        public long LeRowid { get; set; }
        public long? LeUid { get; set; }
        public DateTime? LeCdate { get; set; }
        public TimeSpan? LeCtime { get; set; }
        public string? LeCby { get; set; }
        public DateTime? LeMdate { get; set; }
        public TimeSpan? LeMtime { get; set; }
        public string? LeMby { get; set; }
        public int? LeUidm { get; set; }
        public long? LeUido { get; set; }
        public short? LeCode { get; set; }
        public string? LeDescription { get; set; }
        public short? LeDiarizationLimit { get; set; }

        public virtual ICollection<FormRight> FormRights { get; set; }
    }
}

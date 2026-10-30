using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class ContactPlan
    {
        public ContactPlan()
        {
            ContactEvents = new HashSet<ContactEvent>();
        }

        public long CpRowid { get; set; }
        public long? CpUid { get; set; }
        public DateTime? CpCdate { get; set; }
        public TimeSpan? CpCtime { get; set; }
        public string? CpCby { get; set; }
        public DateTime? CpMdate { get; set; }
        public TimeSpan? CpMtime { get; set; }
        public string? CpMby { get; set; }
        public int? CpUidm { get; set; }
        public string? CpCode { get; set; }
        public string? CpDescription { get; set; }
        public short? CpSwitches { get; set; }
        public int? CpProcessId { get; set; }
        public int? CpProcessStep { get; set; }
        public int? CpSetProcessId { get; set; }
        public short? CpClearPending { get; set; }
        public short? CpFlags { get; set; }
        public short? CpFrequency { get; set; }
        public short? CpDuration { get; set; }
        public short? CpMinRange1 { get; set; }
        public short? CpMaxRange1 { get; set; }
        public short? CpMinRange2 { get; set; }
        public short? CpMaxRange2 { get; set; }
        public short? CpMinRange3 { get; set; }
        public short? CpMaxRange3 { get; set; }
        public short? CpCategory { get; set; }
        public short? CpCategory1 { get; set; }
        public short? CpCategory2 { get; set; }

        public virtual ICollection<ContactEvent> ContactEvents { get; set; }
    }
}

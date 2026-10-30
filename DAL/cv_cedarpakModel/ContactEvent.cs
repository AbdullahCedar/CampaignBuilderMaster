using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class ContactEvent
    {
        public long CeRowid { get; set; }
        public long? CeRowidContactPlan { get; set; }
        public long? CeUid { get; set; }
        public DateTime? CeCdate { get; set; }
        public TimeSpan? CeCtime { get; set; }
        public string? CeCby { get; set; }
        public DateTime? CeMdate { get; set; }
        public TimeSpan? CeMtime { get; set; }
        public string? CeMby { get; set; }
        public int? CeUidm { get; set; }
        public long? CeUido { get; set; }
        public short? CeType { get; set; }
        public string? CeDescription { get; set; }
        public short? CeHolidaySwitch { get; set; }
        public int? CeSetProcessStep { get; set; }
        public short? CePriority { get; set; }
        public short? CeDelay { get; set; }
        public short? CeFlags { get; set; }
        public string? CeWho { get; set; }
        public string? CeIf { get; set; }
        public string? CeCompare { get; set; }
        public string? CeValue { get; set; }
        public short? CeOperatorFlag { get; set; }
        public TimeSpan? CeTime { get; set; }
        public short? CeDateFlag { get; set; }
        public short? CeTimeFlag { get; set; }
        public int? CeEstimatedTime { get; set; }
        public int? CeEstimatedDays { get; set; }
        public int? CeWarningTime { get; set; }
        public short? CeRepeat { get; set; }
        public short? CeCustomRepeat { get; set; }
        public decimal? CeAmount { get; set; }
        public string? CeTransactionType { get; set; }
        public string? CeAttachment { get; set; }
        public string? CeValue2 { get; set; }
        public byte? CeDummy { get; set; }
        public long? CeSeqContactPlan { get; set; }

        public virtual ContactPlan? CeRowidContactPlanNavigation { get; set; }
    }
}

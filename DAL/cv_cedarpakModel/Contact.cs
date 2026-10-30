using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class Contact
    {
        public long CoRowid { get; set; }
        public long? CoRowidDebtor { get; set; }
        public long? CoUid { get; set; }
        public DateTime? CoCdate { get; set; }
        public TimeSpan? CoCtime { get; set; }
        public string? CoCby { get; set; }
        public DateTime? CoMdate { get; set; }
        public TimeSpan? CoMtime { get; set; }
        public string? CoMby { get; set; }
        public int? CoUidm { get; set; }
        public long? CoUido { get; set; }
        public short? CoCompleted { get; set; }
        public short? CoClass { get; set; }
        public short? CoType { get; set; }
        public string? CoDescription { get; set; }
        public short? CoPriority { get; set; }
        public string? CoWho { get; set; }
        public DateTime? CoDate { get; set; }
        public TimeSpan? CoTime { get; set; }
        public DateTime? CoDoneDate { get; set; }
        public TimeSpan? CoDoneTime { get; set; }
        public string? CoOriginator { get; set; }
        public DateTime? CoCreationDate { get; set; }
        public TimeSpan? CoCreationTime { get; set; }
        public decimal? CoAmount { get; set; }
        public short? CoRepeat { get; set; }
        public short? CoCustomRepeat { get; set; }
        public string? CoWhoFrom { get; set; }
        public string? CoDoneBy { get; set; }
        public string? CoAttachment { get; set; }
        public int? CoEstimatedTime { get; set; }
        public int? CoElapsedTime { get; set; }
        public short? CoLock { get; set; }
        public short? CoCategory { get; set; }
        public short? CoCategory1 { get; set; }
        public short? CoCategory2 { get; set; }
        public string? CoUser1 { get; set; }
        public string? CoUser2 { get; set; }
        public string? CoUser3 { get; set; }
        public string? CoUser4 { get; set; }
        public long? CoAttachmentBlob { get; set; }
        public decimal? CoAmount1 { get; set; }
        public decimal? CoAmount2 { get; set; }
        public decimal? CoPercent1 { get; set; }
        public decimal? CoPercent2 { get; set; }
        public int? CoNumber1 { get; set; }
        public int? CoNumber2 { get; set; }
        public DateTime? CoDate1 { get; set; }
        public DateTime? CoDate2 { get; set; }
        public short? CoFlags1 { get; set; }
        public short? CoFlags2 { get; set; }
        public string? CoOp1 { get; set; }
        public string? CoOp2 { get; set; }

        public virtual Blob? CoAttachmentBlobNavigation { get; set; }
        public virtual Debtor? CoRowidDebtorNavigation { get; set; }
    }
}

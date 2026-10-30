using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class AClAttachment
    {
        public AClAttachment()
        {
            ACatContacts = new HashSet<ACatContact>();
        }

        public long ClAtRowid { get; set; }
        public long? ClAtRowidClient { get; set; }
        public long? ClAtUid { get; set; }
        public DateTime? ClAtCdate { get; set; }
        public TimeSpan? ClAtCtime { get; set; }
        public string? ClAtCby { get; set; }
        public DateTime? ClAtMdate { get; set; }
        public TimeSpan? ClAtMtime { get; set; }
        public string? ClAtMby { get; set; }
        public int? ClAtUidm { get; set; }
        public long? ClAtUido { get; set; }
        public DateTime? ClAtCreatedDate { get; set; }
        public DateTime? ClAtModifiedDate { get; set; }
        public short? ClAtClass { get; set; }
        public short? ClAtType { get; set; }
        public string? ClAtDescription { get; set; }
        public string? ClAtDetail1 { get; set; }
        public string? ClAtDetail2 { get; set; }
        public string? ClAtDetail3 { get; set; }
        public string? ClAtDetail4 { get; set; }
        public string? ClAtDetail5 { get; set; }
        public string? ClAtDetail6 { get; set; }
        public string? ClAtDetail7 { get; set; }
        public string? ClAtDetail8 { get; set; }
        public string? ClAtDetail9 { get; set; }
        public string? ClAtDetail10 { get; set; }
        public string? ClAtDetail11 { get; set; }
        public string? ClAtDetail12 { get; set; }
        public string? ClAtDetail13 { get; set; }
        public string? ClAtDetail14 { get; set; }
        public string? ClAtDetail15 { get; set; }
        public string? ClAtDetail16 { get; set; }
        public string? ClAtFile { get; set; }
        public short? ClAtValue { get; set; }
        public short? ClAtFactor { get; set; }
        public DateTime? ClAtDate3 { get; set; }
        public decimal? ClTotalCredits { get; set; }
        public decimal? ClAtTotalDebits { get; set; }
        public decimal? ClAtTotalResult { get; set; }
        public DateTime? ClAtDate1 { get; set; }
        public DateTime? ClAtDate2 { get; set; }
        public short? ClAtCategory { get; set; }
        public short? ClAtCategory1 { get; set; }
        public short? ClAtCategory2 { get; set; }
        public long? ClAtBlob { get; set; }

        public virtual Blob? ClAtBlobNavigation { get; set; }
        public virtual AClient? ClAtRowidClientNavigation { get; set; }
        public virtual ICollection<ACatContact> ACatContacts { get; set; }
    }
}

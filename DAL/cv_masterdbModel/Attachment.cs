using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class Attachment
    {
        public Attachment()
        {
            AtContacts = new HashSet<AtContact>();
        }

        public long AtRowid { get; set; }
        public long? AtRowidDebtor { get; set; }
        public long? AtUid { get; set; }
        public DateTime? AtCdate { get; set; }
        public TimeSpan? AtCtime { get; set; }
        public string? AtCby { get; set; }
        public DateTime? AtMdate { get; set; }
        public TimeSpan? AtMtime { get; set; }
        public string? AtMby { get; set; }
        public int? AtUidm { get; set; }
        public long? AtUido { get; set; }
        public DateTime? AtCreatedDate { get; set; }
        public DateTime? AtModifiedDate { get; set; }
        public string? AtCreatedBy { get; set; }
        public string? AtModifiedBy { get; set; }
        public short? AtClass { get; set; }
        public short? AtType { get; set; }
        public string? AtDescription { get; set; }
        public string? AtDetail1 { get; set; }
        public string? AtDetail2 { get; set; }
        public string? AtDetail3 { get; set; }
        public string? AtDetail4 { get; set; }
        public string? AtDetail5 { get; set; }
        public string? AtDetail6 { get; set; }
        public string? AtDetail7 { get; set; }
        public string? AtDetail8 { get; set; }
        public string? AtDetail9 { get; set; }
        public string? AtDetail10 { get; set; }
        public string? AtDetail11 { get; set; }
        public string? AtDetail12 { get; set; }
        public string? AtDetail13 { get; set; }
        public string? AtDetail14 { get; set; }
        public string? AtDetail15 { get; set; }
        public string? AtDetail16 { get; set; }
        public string? AtFile { get; set; }
        public short? AtValue { get; set; }
        public short? AtFactor { get; set; }
        public DateTime? AtDate3 { get; set; }
        public decimal? AtTotalCredits { get; set; }
        public decimal? AtTotalDebits { get; set; }
        public decimal? AtTotalResult { get; set; }
        public DateTime? AtDate1 { get; set; }
        public DateTime? AtDate2 { get; set; }
        public short? AtCategory { get; set; }
        public short? AtCategory1 { get; set; }
        public short? AtCategory2 { get; set; }
        public long? AtBlob { get; set; }
        public long? AtSeqDebtor { get; set; }

        public virtual Blob? AtBlobNavigation { get; set; }
        public virtual Debtor? AtRowidDebtorNavigation { get; set; }
        public virtual ICollection<AtContact> AtContacts { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class APhone
    {
        public long PhRowid { get; set; }
        public long? PhRowidBank { get; set; }
        public long? PhRowidClient { get; set; }
        public long? PhRowidDebtor { get; set; }
        public long? PhRowidCosigner { get; set; }
        public long? PhRowidAssociated { get; set; }
        public long? PhUid { get; set; }
        public DateTime? PhCdate { get; set; }
        public TimeSpan? PhCtime { get; set; }
        public string? PhCby { get; set; }
        public DateTime? PhMdate { get; set; }
        public TimeSpan? PhMtime { get; set; }
        public string? PhMby { get; set; }
        public int? PhUidm { get; set; }
        public long? PhUido { get; set; }
        public long? PhUido1 { get; set; }
        public long? PhUido2 { get; set; }
        public long? PhUido3 { get; set; }
        public long? PhUido4 { get; set; }
        public string? PhNumber { get; set; }
        public string? PhExtension { get; set; }
        public short? PhType { get; set; }
        public short? PhFlags { get; set; }
        public short? PhTimezone { get; set; }
        public short? PhSource { get; set; }
        public DateTime? PhDateReceived { get; set; }
        public TimeSpan? PhNisDate { get; set; }
        public short? PhNisId { get; set; }
        public short? PhNisReason { get; set; }
        public short? PhCategory { get; set; }
        public short? PhCategory1 { get; set; }
        public short? PhCategory2 { get; set; }
        public TimeSpan? PhTimeFrom { get; set; }
        public TimeSpan? PhTimeTo { get; set; }
        public string? PhUser1 { get; set; }
        public string? PhUser2 { get; set; }
        public short? PhNumber1 { get; set; }
        public short? PhNumber2 { get; set; }

        public virtual AAssociated? PhRowidAssociatedNavigation { get; set; }
        public virtual ABank? PhRowidBankNavigation { get; set; }
        public virtual AClient? PhRowidClientNavigation { get; set; }
        public virtual ACosigner? PhRowidCosignerNavigation { get; set; }
        public virtual ADebtor? PhRowidDebtorNavigation { get; set; }
    }
}

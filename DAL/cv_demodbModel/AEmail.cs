using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class AEmail
    {
        public long EmRowid { get; set; }
        public long? EmRowidBank { get; set; }
        public long? EmRowidClient { get; set; }
        public long? EmRowidDebtor { get; set; }
        public long? EmRowidCosigner { get; set; }
        public long? EmRowidAssociated { get; set; }
        public long? EmUid { get; set; }
        public DateTime? EmCdate { get; set; }
        public TimeSpan? EmCtime { get; set; }
        public string? EmCby { get; set; }
        public DateTime? EmMdate { get; set; }
        public TimeSpan? EmMtime { get; set; }
        public string? EmMby { get; set; }
        public int? EmUidm { get; set; }
        public long? EmUido { get; set; }
        public long? EmUido1 { get; set; }
        public long? EmUido2 { get; set; }
        public long? EmUido3 { get; set; }
        public long? EmUido4 { get; set; }
        public string? EmEmailAddress { get; set; }
        public short? EmType { get; set; }
        public short? EmFlags { get; set; }
        public short? EmFlags1 { get; set; }
        public DateTime? EmDate1 { get; set; }
        public DateTime? EmDate2 { get; set; }
        public string? EmOp1 { get; set; }
        public string? EmOp2 { get; set; }

        public virtual AAssociated? EmRowidAssociatedNavigation { get; set; }
        public virtual ABank? EmRowidBankNavigation { get; set; }
        public virtual AClient? EmRowidClientNavigation { get; set; }
        public virtual ACosigner? EmRowidCosignerNavigation { get; set; }
        public virtual ADebtor? EmRowidDebtorNavigation { get; set; }
    }
}

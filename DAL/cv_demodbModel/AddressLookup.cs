using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class AddressLookup
    {
        public long AddRowid { get; set; }
        public long? AddRowidBank { get; set; }
        public long? AddRowidClient { get; set; }
        public long? AddRowidDebtor { get; set; }
        public long? AddRowidCosigner { get; set; }
        public long? AddRowidAssociated { get; set; }
        public long? AddUid { get; set; }
        public DateTime? AddCdate { get; set; }
        public TimeSpan? AddCtime { get; set; }
        public string? AddCby { get; set; }
        public DateTime? AddMdate { get; set; }
        public TimeSpan? AddMtime { get; set; }
        public string? AddMby { get; set; }
        public int? AddUidm { get; set; }
        public long? AddUido { get; set; }
        public long? AddUido1 { get; set; }
        public long? AddUido2 { get; set; }
        public long? AddUido3 { get; set; }
        public long? AddUido4 { get; set; }
        public short? AddCategory { get; set; }
        public short? AddCategory1 { get; set; }
        public short? AddCategory2 { get; set; }
        public string? AddAddress { get; set; }
        public string? AddAddress1 { get; set; }
        public string? AddAddress2 { get; set; }
        public string? AddCity { get; set; }
        public string? AddState { get; set; }
        public string? AddZip { get; set; }
        public string? AddCountry { get; set; }
        public short? AddFlags { get; set; }
        public short? AddType { get; set; }
        public short? AddAddressSource { get; set; }
        public short? AddTimezone { get; set; }

        public virtual Associated? AddRowidAssociatedNavigation { get; set; }
        public virtual Bank? AddRowidBankNavigation { get; set; }
        public virtual Client? AddRowidClientNavigation { get; set; }
        public virtual Cosigner? AddRowidCosignerNavigation { get; set; }
        public virtual Debtor? AddRowidDebtorNavigation { get; set; }
    }
}

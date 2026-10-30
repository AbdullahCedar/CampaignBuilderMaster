using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class AAssociated
    {
        public AAssociated()
        {
            AAddressLookups = new HashSet<AAddressLookup>();
            AAsContacts = new HashSet<AAsContact>();
            ABankAccounts = new HashSet<ABankAccount>();
            AEmails = new HashSet<AEmail>();
            APhones = new HashSet<APhone>();
        }

        public long AsCosRowid { get; set; }
        public long? AsCosRowidClient { get; set; }
        public long? AsCosUid { get; set; }
        public DateTime? AsCosCdate { get; set; }
        public TimeSpan? AsCosCtime { get; set; }
        public string? AsCosCby { get; set; }
        public DateTime? AsCosMdate { get; set; }
        public TimeSpan? AsCosMtime { get; set; }
        public string? AsCosMby { get; set; }
        public int? AsCosUidm { get; set; }
        public long? AsCosUido { get; set; }
        public short? AsCosClass { get; set; }
        public short? AsCosType { get; set; }
        public int? AsCosCreated { get; set; }
        public string? AsCosCreatedBy { get; set; }
        public int? AsCosModified { get; set; }
        public string? AsCosModifiedBy { get; set; }
        public string? AsCosCinfoInd { get; set; }
        public decimal? AsCosPercent { get; set; }
        public decimal? AsCosAmount { get; set; }
        public string? AsCosName { get; set; }
        public short? AsCosEntity { get; set; }
        public string? AsCosigner { get; set; }
        public string? AsCosTitle { get; set; }
        public string? AsCosPhone { get; set; }
        public string? AsCosPhoneExt { get; set; }
        public string? AsCosBusinessPhone { get; set; }
        public string? AsCosBusinessExt { get; set; }
        public string? AsCosOtherPhone { get; set; }
        public string? AsCosOtherExt { get; set; }
        public string? AsCosCellPhone { get; set; }
        public string? AsCosCellExt { get; set; }
        public string? AsCosEmail { get; set; }
        public string? AsCosSin { get; set; }
        public string? AsCosDl { get; set; }
        public short? AsCosGroupFlags { get; set; }
        public int? AsCosDob { get; set; }
        public short? AsCosAddressFlags { get; set; }
        public string? AsCosAddress { get; set; }
        public string? AsCosAddress1 { get; set; }
        public string? AsCosAddress2 { get; set; }
        public string? AsCosStreetNumber { get; set; }
        public string? AsCosCity { get; set; }
        public string? AsCosState { get; set; }
        public string? AsCosZip { get; set; }
        public string? AsCosCountry { get; set; }
        public int? AsCosGroupId { get; set; }
        public short? AsCosGroupMember { get; set; }
        public string? AsCosCbrAssociation { get; set; }
        public string? AsCosEcoa { get; set; }
        public short? AsCosCategory { get; set; }
        public short? AsCosCategory1 { get; set; }
        public short? AsCosCategory2 { get; set; }
        public string? AsCosNote1 { get; set; }
        public string? AsCosNote2 { get; set; }
        public string? AsCosNote3 { get; set; }
        public string? AsCosNote4 { get; set; }
        public decimal? AsCosAmount1 { get; set; }
        public decimal? AsCosAmount2 { get; set; }
        public decimal? AsCosPercent1 { get; set; }
        public decimal? AsCosPercent2 { get; set; }
        public int? AsCosNumber1 { get; set; }
        public int? AsCosNumber2 { get; set; }
        public DateTime? AsCosDate1 { get; set; }
        public DateTime? AsCosDate2 { get; set; }
        public short? AsCosFlags1 { get; set; }
        public short? AsCosFlags2 { get; set; }
        public string? AsCosOp1 { get; set; }
        public string? AsCosOp2 { get; set; }
        public short? AsCosTimezone { get; set; }
        public short? AsCosLetterNum { get; set; }
        public short? AsCosAttachNum { get; set; }
        public short? AsCosEmailNum { get; set; }

        public virtual AClient? AsCosRowidClientNavigation { get; set; }
        public virtual ICollection<AAddressLookup> AAddressLookups { get; set; }
        public virtual ICollection<AAsContact> AAsContacts { get; set; }
        public virtual ICollection<ABankAccount> ABankAccounts { get; set; }
        public virtual ICollection<AEmail> AEmails { get; set; }
        public virtual ICollection<APhone> APhones { get; set; }
    }
}

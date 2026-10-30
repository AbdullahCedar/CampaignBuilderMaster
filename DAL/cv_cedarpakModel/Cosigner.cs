using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class Cosigner
    {
        public Cosigner()
        {
            AddressLookups = new HashSet<AddressLookup>();
            BankAccounts = new HashSet<BankAccount>();
            DcosContacts = new HashSet<DcosContact>();
            Emails = new HashSet<Email>();
            Phones = new HashSet<Phone>();
        }

        public long DeCosRowid { get; set; }
        public long? DeCosRowidDebtor { get; set; }
        public long? DeCosUid { get; set; }
        public DateTime? DeCosCdate { get; set; }
        public TimeSpan? DeCosCtime { get; set; }
        public string? DeCosCby { get; set; }
        public DateTime? DeCosMdate { get; set; }
        public TimeSpan? DeCosMtime { get; set; }
        public string? DeCosMby { get; set; }
        public int? DeCosUidm { get; set; }
        public long? DeCosUido { get; set; }
        public short? DeCosClass { get; set; }
        public short? DeCosType { get; set; }
        public int? DeCosCreated { get; set; }
        public string? DeCosCreatedBy { get; set; }
        public int? DeCosModified { get; set; }
        public string? DeCosModifiedBy { get; set; }
        public string? DeCosCinfoInd { get; set; }
        public decimal? DeCosPercent { get; set; }
        public decimal? DeCosAmount { get; set; }
        public string? DeCosName { get; set; }
        public short? DeCosEntity { get; set; }
        public string? DeCosigner { get; set; }
        public string? DeCosTitle { get; set; }
        public string? DeCosPhone { get; set; }
        public string? DeCosPhoneExt { get; set; }
        public string? DeCosBusinessPhone { get; set; }
        public string? DeCosBusinessExt { get; set; }
        public string? DeCosOtherPhone { get; set; }
        public string? DeCosOtherExt { get; set; }
        public string? DeCosCellPhone { get; set; }
        public string? DeCosCellExt { get; set; }
        public string? DeCosEmail { get; set; }
        public string? DeCosSin { get; set; }
        public string? DeCosDl { get; set; }
        public short? DeCosGroupFlags { get; set; }
        public DateTime? DeCosDob { get; set; }
        public short? DeCosAddressFlags { get; set; }
        public string? DeCosAddress { get; set; }
        public string? DeCosAddress1 { get; set; }
        public string? DeCosAddress2 { get; set; }
        public string? DeCosStreetNumber { get; set; }
        public string? DeCosCity { get; set; }
        public string? DeCosState { get; set; }
        public string? DeCosZip { get; set; }
        public string? DeCosCountry { get; set; }
        public int? DeCosGroupId { get; set; }
        public short? DeCosGroupMember { get; set; }
        public string? DeCosCbrAssociation { get; set; }
        public string? DeCosEcoa { get; set; }
        public short? DeCosCategory { get; set; }
        public short? DeCosCategory1 { get; set; }
        public short? DeCosCategory2 { get; set; }
        public string? DeCosNote1 { get; set; }
        public string? DeCosNote2 { get; set; }
        public string? DeCosNote3 { get; set; }
        public string? DeCosNote4 { get; set; }
        public decimal? DeCosAmount1 { get; set; }
        public decimal? DeCosAmount2 { get; set; }
        public decimal? DeCosPercent1 { get; set; }
        public decimal? DeCosPercent2 { get; set; }
        public int? DeCosNumber1 { get; set; }
        public int? DeCosNumber2 { get; set; }
        public DateTime? DeCosDate1 { get; set; }
        public DateTime? DeCosDate2 { get; set; }
        public short? DeCosFlags1 { get; set; }
        public short? DeCosFlags2 { get; set; }
        public string? DeCosOp1 { get; set; }
        public string? DeCosOp2 { get; set; }
        public short? DeCosTimezone { get; set; }
        public short? DeCosLetterNum { get; set; }
        public short? DeCosAttachNum { get; set; }
        public short? DeCosEmailNum { get; set; }

        public virtual Debtor? DeCosRowidDebtorNavigation { get; set; }
        public virtual ICollection<AddressLookup> AddressLookups { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<DcosContact> DcosContacts { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}

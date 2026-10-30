using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class ABank
    {
        public ABank()
        {
            AAddressLookups = new HashSet<AAddressLookup>();
            AEmails = new HashSet<AEmail>();
            APhones = new HashSet<APhone>();
        }

        public long BkRowid { get; set; }
        public long? BkRowidAccount { get; set; }
        public long? BkUid { get; set; }
        public DateTime? BkCdate { get; set; }
        public TimeSpan? BkCtime { get; set; }
        public string? BkCby { get; set; }
        public DateTime? BkMdate { get; set; }
        public TimeSpan? BkMtime { get; set; }
        public string? BkMby { get; set; }
        public int? BkUidm { get; set; }
        public long? BkUido { get; set; }
        public short? BkCategory { get; set; }
        public short? BkCategory1 { get; set; }
        public short? BkCategory2 { get; set; }
        public string? BkBank { get; set; }
        public string? BkBranch { get; set; }
        public string? BkRoutingNo { get; set; }
        public string? BkClerk { get; set; }
        public string? BkAccess { get; set; }
        public string? BkUser1 { get; set; }
        public string? BkUser2 { get; set; }
        public string? BkUser3 { get; set; }
        public string? BkUser4 { get; set; }
        public decimal? BkPercent1 { get; set; }
        public decimal? BkPercent2 { get; set; }
        public decimal? BkMoney1 { get; set; }
        public decimal? BkMoney2 { get; set; }
        public string? BkOp1 { get; set; }
        public string? BkOp2 { get; set; }
        public int? BkNumber1 { get; set; }
        public int? BkNumber2 { get; set; }
        public short? BkFlags1 { get; set; }
        public short? BkFlags2 { get; set; }
        public DateTime? BkDate1 { get; set; }
        public DateTime? BkDate2 { get; set; }
        public string? BkAddress { get; set; }
        public string? BkAddress1 { get; set; }
        public string? BkAddressStreetNo { get; set; }
        public string? BkAddressCity { get; set; }
        public string? BkAddressState { get; set; }
        public string? BkAddressZip { get; set; }
        public short? BkAddressFlags { get; set; }
        public string? BkAddressCountry { get; set; }
        public string? BkPhone { get; set; }
        public string? BkPhoneExtension { get; set; }
        public string? BkOther { get; set; }
        public string? BkFax { get; set; }
        public string? BkFaxExtension { get; set; }
        public string? BkOtherExtension { get; set; }
        public short? BkTimezone { get; set; }

        public virtual ABankAccount? BkRowidAccountNavigation { get; set; }
        public virtual ICollection<AAddressLookup> AAddressLookups { get; set; }
        public virtual ICollection<AEmail> AEmails { get; set; }
        public virtual ICollection<APhone> APhones { get; set; }
    }
}

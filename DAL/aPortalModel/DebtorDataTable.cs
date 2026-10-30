using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class DebtorDataTable
    {
        public decimal? InitialDebtAmount { get; set; }
        public string? ProductType { get; set; }
        public decimal? AmountPaid { get; set; }
        public string? PartialRepaymentStatus { get; set; }
        public string? PreviousCollectionSuccess { get; set; }
        public int? CustomerTenure { get; set; }
        public int DeRowid { get; set; }
        public string? CurrentSubstatus { get; set; }
        public int? DebtorAge { get; set; }
        public int? VerifiedPhone { get; set; }
        public int? VerifiedEmail { get; set; }
        public int? VerifiedAddress { get; set; }
        public int? Phones { get; set; }
        public int? Emails { get; set; }
        public int? ConsentedEmails { get; set; }
        public int? NonConsentedEmail { get; set; }
        public int? Calls { get; set; }
        public int? EmailSend { get; set; }
        public int? Letters { get; set; }
        public int? Sms { get; set; }
        public int? TotalContacts { get; set; }
        public int? Promises { get; set; }
        public int? LastPromise { get; set; }
        public int? Rpc { get; set; }
        public int? DaysSinceLastInteraction { get; set; }
        public int? DaysSinceLastPhoneCall { get; set; }
    }
}

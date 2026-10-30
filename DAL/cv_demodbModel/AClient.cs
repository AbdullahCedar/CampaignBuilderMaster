using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class AClient
    {
        public AClient()
        {
            AAddressLookups = new HashSet<AAddressLookup>();
            AAssociateds = new HashSet<AAssociated>();
            ABankAccounts = new HashSet<ABankAccount>();
            AClAttachments = new HashSet<AClAttachment>();
            AClContacts = new HashSet<AClContact>();
            AClTransactions = new HashSet<AClTransaction>();
            ADebtors = new HashSet<ADebtor>();
            AEmails = new HashSet<AEmail>();
            AInvoices = new HashSet<AInvoice>();
            ANotes = new HashSet<ANote>();
            APhones = new HashSet<APhone>();
            Blobs = new HashSet<Blob>();
        }

        public long ClRowid { get; set; }
        public long? ClUid { get; set; }
        public DateTime? ClCdate { get; set; }
        public TimeSpan? ClCtime { get; set; }
        public string? ClCby { get; set; }
        public DateTime? ClMdate { get; set; }
        public TimeSpan? ClMtime { get; set; }
        public string? ClMby { get; set; }
        public int? ClUidm { get; set; }
        public string? ClName { get; set; }
        public string? ClDoBusinessAs { get; set; }
        public short? ClArchive { get; set; }
        public int? ClNumber { get; set; }
        public string? ClAltNumber { get; set; }
        public int? ClOwnedbyNumber { get; set; }
        public DateTime? ClListedDate { get; set; }
        public DateTime? ClWorkedDate { get; set; }
        public int? ClNumberOfAccounts { get; set; }
        public int? ClNumOfClosedAccounts { get; set; }
        public int? ClNumOfActiveAccounts { get; set; }
        public int? ClNumOfOtherAccounts { get; set; }
        public decimal? ClFixFee { get; set; }
        public byte? ClFeeDisbursement { get; set; }
        public byte? ClTaxDisbursement { get; set; }
        public byte? ClSuccessCalc { get; set; }
        public string? ClSales { get; set; }
        public string? ClOperator { get; set; }
        public string? ClContactPlan { get; set; }
        public string? ClAddress { get; set; }
        public string? ClAddress1 { get; set; }
        public string? ClAddress2 { get; set; }
        public string? ClStreetNo { get; set; }
        public string? ClCity { get; set; }
        public string? ClState { get; set; }
        public string? ClZip { get; set; }
        public string? ClCountry { get; set; }
        public short? ClAddFlags { get; set; }
        public short? ClAddType { get; set; }
        public byte? ClBillingPeriod { get; set; }
        public int? ClTaxOptions { get; set; }
        public decimal? ClTaxRate { get; set; }
        public decimal? ClTaxRate1 { get; set; }
        public decimal? ClTaxRate2 { get; set; }
        public decimal? ClTaxRate3 { get; set; }
        public decimal? ClInterestRate { get; set; }
        public string? ClRatePlan { get; set; }
        public string? ClPhone { get; set; }
        public string? ClPhoneExtension { get; set; }
        public string? ClFax { get; set; }
        public string? ClCell { get; set; }
        public string? ClOther { get; set; }
        public string? ClEmail { get; set; }
        public string? ClContact { get; set; }
        public string? ClAltContact { get; set; }
        public short? ClInvoiceCode { get; set; }
        public decimal? ClListed { get; set; }
        public decimal? ClPrincipal { get; set; }
        public decimal? ClInterest { get; set; }
        public decimal? ClFees { get; set; }
        public decimal? ClLegal { get; set; }
        public decimal? ClMisc { get; set; }
        public decimal? ClOtherFee { get; set; }
        public decimal? ClJudgement { get; set; }
        public decimal? ClAdjustments { get; set; }
        public decimal? ClPaid { get; set; }
        public decimal? ClOwing { get; set; }
        public decimal? ClClosed { get; set; }
        public int? ClCommRateOptions { get; set; }
        public decimal? ClCommissionRate { get; set; }
        public decimal? ClCommissionRate1 { get; set; }
        public decimal? ClCommissionRate2 { get; set; }
        public decimal? ClCommissionRate3 { get; set; }
        public short? ClTaxExempt { get; set; }
        public short? ClFlags { get; set; }
        public short? CpPrecollectDelay { get; set; }
        public short? ClClass { get; set; }
        public short? ClCategory { get; set; }
        public short? ClCategory1 { get; set; }
        public short? ClCategory2 { get; set; }
        public decimal? ClSuccessRate { get; set; }
        public string? ClSuccessEquation { get; set; }
        public int? ClCurrency { get; set; }
        public int? ClStatementCurrency { get; set; }
        public short? ClType { get; set; }
        public string? ClReportListings { get; set; }
        public string? ClReportAcknowledgement { get; set; }
        public string? ClReportStatements { get; set; }
        public string? ClReportExtra { get; set; }
        public decimal? ClAmount1 { get; set; }
        public decimal? ClAmount2 { get; set; }
        public decimal? ClPercent1 { get; set; }
        public decimal? ClPercent2 { get; set; }
        public int? ClNumber1 { get; set; }
        public int? ClNumber2 { get; set; }
        public DateTime? ClDate1 { get; set; }
        public DateTime? ClDate2 { get; set; }
        public short? ClFlags1 { get; set; }
        public short? ClFlags2 { get; set; }
        public string? ClOp1 { get; set; }
        public string? ClOp2 { get; set; }
        public string? ClUser1 { get; set; }
        public string? ClUser2 { get; set; }
        public string? ClUser3 { get; set; }
        public string? ClUser4 { get; set; }
        public long? ClNoteblob { get; set; }
        public string? ClFaxExtension { get; set; }
        public string? ClCellExtension { get; set; }
        public string? ClOtherExtension { get; set; }
        public short? ClTimezone { get; set; }
        public int? ClCompFlags { get; set; }
        public int? ClCompFlags2 { get; set; }
        public string? ClCompGst { get; set; }
        public int? ClCompClDebtorThresh { get; set; }
        public int? ClCompClNumber { get; set; }
        public short? ClLetterNum { get; set; }
        public short? ClAttachNum { get; set; }
        public short? ClEmailNum { get; set; }
        public short? ClInterestFlags1 { get; set; }
        public short? ClInterestFlags2 { get; set; }
        public short? ClInterestFlags3 { get; set; }

        public virtual Blob? ClNoteblobNavigation { get; set; }
        public virtual ICollection<AAddressLookup> AAddressLookups { get; set; }
        public virtual ICollection<AAssociated> AAssociateds { get; set; }
        public virtual ICollection<ABankAccount> ABankAccounts { get; set; }
        public virtual ICollection<AClAttachment> AClAttachments { get; set; }
        public virtual ICollection<AClContact> AClContacts { get; set; }
        public virtual ICollection<AClTransaction> AClTransactions { get; set; }
        public virtual ICollection<ADebtor> ADebtors { get; set; }
        public virtual ICollection<AEmail> AEmails { get; set; }
        public virtual ICollection<AInvoice> AInvoices { get; set; }
        public virtual ICollection<ANote> ANotes { get; set; }
        public virtual ICollection<APhone> APhones { get; set; }
        public virtual ICollection<Blob> Blobs { get; set; }
    }
}

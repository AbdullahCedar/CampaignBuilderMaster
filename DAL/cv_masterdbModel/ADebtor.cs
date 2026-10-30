using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class ADebtor
    {
        public ADebtor()
        {
            AAddressLookups = new HashSet<AAddressLookup>();
            AAttachments = new HashSet<AAttachment>();
            ABankAccounts = new HashSet<ABankAccount>();
            AContacts = new HashSet<AContact>();
            ACosigners = new HashSet<ACosigner>();
            ADeTransactions = new HashSet<ADeTransaction>();
            AEmails = new HashSet<AEmail>();
            ANotes = new HashSet<ANote>();
            APhones = new HashSet<APhone>();
            Blobs = new HashSet<Blob>();
        }

        public long DeRowid { get; set; }
        public long? DeRowidClient { get; set; }
        public long? DeUid { get; set; }
        public DateTime? DeCdate { get; set; }
        public TimeSpan? DeCtime { get; set; }
        public string? DeCby { get; set; }
        public DateTime? DeMdate { get; set; }
        public TimeSpan? DeMtime { get; set; }
        public string? DeMby { get; set; }
        public int? DeUidm { get; set; }
        public long? DeUido { get; set; }
        public int? DeNumber { get; set; }
        public short? DeCategory { get; set; }
        public int? DeOwnedByDebtor { get; set; }
        public short? DeCategory1 { get; set; }
        public short? DeCategory2 { get; set; }
        public string? DeClAccount { get; set; }
        public string? DeClass { get; set; }
        public string? DeType { get; set; }
        public string? DeStatus { get; set; }
        public string? DeName { get; set; }
        public short? DeEntity { get; set; }
        public string? DeClerk { get; set; }
        public string? DeSalesman { get; set; }
        public string? DeCollector { get; set; }
        public string? DeModifiedBy { get; set; }
        public short? DeGroupFlags { get; set; }
        public DateTime? DeListedDate { get; set; }
        public DateTime? DeCloseDate { get; set; }
        public DateTime? DeChargeDate { get; set; }
        public DateTime? DeDelinquencyDate { get; set; }
        public DateTime? DePromiseDate { get; set; }
        public DateTime? DeLastPaymentDate { get; set; }
        public DateTime? DeLastWorkedDate { get; set; }
        public TimeSpan? DeLastWorkedTime { get; set; }
        public DateTime? DeEditDate { get; set; }
        public DateTime? DeArchiveDate { get; set; }
        public DateTime? DeModifiedDate { get; set; }
        public DateTime? DeDate1 { get; set; }
        public DateTime? DeDate2 { get; set; }
        public TimeSpan? DeModifiedTime { get; set; }
        public int? DeFromOffice { get; set; }
        public int? DeToOffice { get; set; }
        public DateTime? DeDob { get; set; }
        public short? DeFlags { get; set; }
        public short? DeArchive { get; set; }
        public string? DeActive { get; set; }
        public short? DeDisplayFlags { get; set; }
        public int? DeGroupId { get; set; }
        public short? DeGroupMember { get; set; }
        public string? DeContact { get; set; }
        public string? DeGeneration { get; set; }
        public string? DeSin { get; set; }
        public string? DeDl { get; set; }
        public string? DeAddress { get; set; }
        public string? DeAddress1 { get; set; }
        public string? DeAddress2 { get; set; }
        public string? DeStreetNumber { get; set; }
        public string? DeCity { get; set; }
        public string? DeState { get; set; }
        public string? DeZip { get; set; }
        public string? DeCountry { get; set; }
        public short? DeAddFlags { get; set; }
        public short? DeTimeZone { get; set; }
        public short? DeAddressSource { get; set; }
        public string? DeHomePhone { get; set; }
        public string? DeHomeExtension { get; set; }
        public string? DeWorkPhone { get; set; }
        public string? DeWorkExtension { get; set; }
        public string? DeCellPhone { get; set; }
        public string? DeCellExtension { get; set; }
        public string? DeOtherPhone { get; set; }
        public string? DeOtherExtension { get; set; }
        public short? DeOkToPhone { get; set; }
        public string? DeEmail { get; set; }
        public string? DeLastAction { get; set; }
        public int? DeProcessId { get; set; }
        public int? DeProcessStep { get; set; }
        public int? DeCurrency { get; set; }
        public decimal? DeFixFee { get; set; }
        public decimal? DePrincipal { get; set; }
        public decimal? DeInterest { get; set; }
        public decimal? DeLegalCosts { get; set; }
        public decimal? DeOriginalInterest { get; set; }
        public decimal? DeInterestRate { get; set; }
        public string? DeInterestTime { get; set; }
        public DateTime? DeInterestDate { get; set; }
        public decimal? DeAccruedInterest { get; set; }
        public decimal? DeFees { get; set; }
        public decimal? DeLegal { get; set; }
        public decimal? DeMisc { get; set; }
        public decimal? DeOther { get; set; }
        public decimal? DeAdjustments { get; set; }
        public decimal? DePaid { get; set; }
        public decimal? DeOwing { get; set; }
        public decimal? DeClSettlementAmt { get; set; }
        public decimal? De30Days { get; set; }
        public decimal? De60Days { get; set; }
        public decimal? De90Days { get; set; }
        public decimal? DeOver90 { get; set; }
        public decimal? DePreCharge { get; set; }
        public decimal? DePreRate { get; set; }
        public decimal? DeCommissionRate { get; set; }
        public decimal? DeCommissionToDate { get; set; }
        public decimal? DeCommPrincToDate { get; set; }
        public decimal? DeCommInterestToDate { get; set; }
        public decimal? DeCommFeesToDate { get; set; }
        public decimal? DeCommLegalToDate { get; set; }
        public decimal? DeCommMiscToDate { get; set; }
        public decimal? DeCommOtherToDate { get; set; }
        public string? DeRateIndex { get; set; }
        public decimal? DeReferralRate { get; set; }
        public decimal? DeTaxRate { get; set; }
        public short? DeTaxExempt { get; set; }
        public short? DeGracePeriod { get; set; }
        public DateTime? DeJudgementDate { get; set; }
        public decimal? DeJudgementPrincipal { get; set; }
        public decimal? DeJudgementInterest { get; set; }
        public decimal? DeJudgementFees { get; set; }
        public decimal? DeJudgementLegal { get; set; }
        public decimal? DeJudgementMisc { get; set; }
        public decimal? DeJudgementOther { get; set; }
        public decimal? DeJudgementBalance { get; set; }
        public decimal? DeJudgePrincPaidtodate { get; set; }
        public decimal? DeJudgeIntPaidtodate { get; set; }
        public decimal? DeJudgeFeePaidtodate { get; set; }
        public decimal? DeJudgeLegalPaidtodate { get; set; }
        public decimal? DeJudgeMiscPaidtodate { get; set; }
        public decimal? DeJudgeOtherPaidtodate { get; set; }
        public string? DeDescription { get; set; }
        public string? DePoe { get; set; }
        public string? DeBank { get; set; }
        public string? DeAccountNumber { get; set; }
        public string? DeBranch { get; set; }
        public string? DeTransitNumber { get; set; }
        public string? DeBusiness { get; set; }
        public string? DeBusinessAddress { get; set; }
        public string? DeUser1 { get; set; }
        public string? DeUser2 { get; set; }
        public string? DeUser3 { get; set; }
        public string? DeUser4 { get; set; }
        public string? DeUser5 { get; set; }
        public DateTime? LastClBillDate { get; set; }
        public DateTime? DeNextPaymentDate { get; set; }
        public decimal? DeActualPaymentAmount { get; set; }
        public decimal? DeAmountPastDue { get; set; }
        public decimal? DeLateFeeAmount { get; set; }
        public decimal? DeTotalPlanPayments { get; set; }
        public decimal? DeEarlyPayoffAmount { get; set; }
        public decimal? DeEarlyPayoffDiscount { get; set; }
        public decimal? DeEarlyPayoffSavings { get; set; }
        public short? DeInterestFlags1 { get; set; }
        public short? DeInterestFlags2 { get; set; }
        public short? DeInterestFlags3 { get; set; }
        public short? DeInterestPeriod { get; set; }
        public short? DeNumberOfPeriods { get; set; }
        public short? DePeriodDays { get; set; }
        public short? LastClPaymentDate { get; set; }
        public decimal? DePrincipalPaidToDate { get; set; }
        public decimal? DeInterestPaidToDate { get; set; }
        public decimal? DeFeesPaidToDate { get; set; }
        public decimal? DeLegalPaidToDate { get; set; }
        public decimal? DeMiscPaidToDate { get; set; }
        public decimal? DeOtherPaidToDate { get; set; }
        public decimal? DeAdjustPaidToDate { get; set; }
        public DateTime? DeFirstPaymentDate { get; set; }
        public decimal? DePaymentAmount { get; set; }
        public short? DeLateFeeFlags1 { get; set; }
        public short? DeLateFeeFlags2 { get; set; }
        public decimal? DeLateFeePercent { get; set; }
        public int? DeEstimatedTime { get; set; }
        public int? DeElapsedTime { get; set; }
        public short? DeRiskScore { get; set; }
        public short? DeSummaryFlags { get; set; }
        public string? DeDepositTo { get; set; }
        public string? DeWithdrawFrom { get; set; }
        public decimal? DeAmount1 { get; set; }
        public decimal? DeAmount2 { get; set; }
        public decimal? DePercent1 { get; set; }
        public decimal? DePercent2 { get; set; }
        public int? DeNumber1 { get; set; }
        public int? DeNumber2 { get; set; }
        public DateTime? DeDate11 { get; set; }
        public DateTime? DeDate21 { get; set; }
        public short? DeFlags1 { get; set; }
        public short? DeFlags2 { get; set; }
        public string? DeOp1 { get; set; }
        public string? DeOp2 { get; set; }
        public long? DeNoteblob { get; set; }
        public short? DeTimezone1 { get; set; }
        public decimal? DeTaxRate1 { get; set; }
        public decimal? DeTaxRate2 { get; set; }
        public decimal? DeTaxRate3 { get; set; }
        public int? DeTaxOptions { get; set; }
        public decimal? DeCommissionRate1 { get; set; }
        public decimal? DeCommissionRate2 { get; set; }
        public decimal? DeCommissionRate3 { get; set; }
        public int? DeCommRateOption { get; set; }
        public short? DeLetterNum { get; set; }
        public short? DeAttachNum { get; set; }
        public short? DeEmailNum { get; set; }
        public string? DeOrgCreditor { get; set; }
        public short? DeOrgCreditorType { get; set; }
        public string? DeAltNumber { get; set; }
        public string? DeFirstName { get; set; }
        public string? DeMiddleName { get; set; }
        public string? DeCompanyName { get; set; }

        public virtual Blob? DeNoteblobNavigation { get; set; }
        public virtual AClient? DeRowidClientNavigation { get; set; }
        public virtual ICollection<AAddressLookup> AAddressLookups { get; set; }
        public virtual ICollection<AAttachment> AAttachments { get; set; }
        public virtual ICollection<ABankAccount> ABankAccounts { get; set; }
        public virtual ICollection<AContact> AContacts { get; set; }
        public virtual ICollection<ACosigner> ACosigners { get; set; }
        public virtual ICollection<ADeTransaction> ADeTransactions { get; set; }
        public virtual ICollection<AEmail> AEmails { get; set; }
        public virtual ICollection<ANote> ANotes { get; set; }
        public virtual ICollection<APhone> APhones { get; set; }
        public virtual ICollection<Blob> Blobs { get; set; }
    }
}

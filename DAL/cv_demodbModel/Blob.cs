using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class Blob
    {
        public Blob()
        {
            AAsContacts = new HashSet<AAsContact>();
            AAtContacts = new HashSet<AAtContact>();
            AAttachments = new HashSet<AAttachment>();
            ACatContacts = new HashSet<ACatContact>();
            AClAttachments = new HashSet<AClAttachment>();
            AClContacts = new HashSet<AClContact>();
            AClTransactions = new HashSet<AClTransaction>();
            AClients = new HashSet<AClient>();
            AContacts = new HashSet<AContact>();
            ADcosContacts = new HashSet<ADcosContact>();
            ADeTransactions = new HashSet<ADeTransaction>();
            ADebtors = new HashSet<ADebtor>();
            AsContacts = new HashSet<AsContact>();
            AtContacts = new HashSet<AtContact>();
            Attachments = new HashSet<Attachment>();
            CatContacts = new HashSet<CatContact>();
            ClAttachments = new HashSet<ClAttachment>();
            ClContacts = new HashSet<ClContact>();
            ClTransactions = new HashSet<ClTransaction>();
            Clients = new HashSet<Client>();
            Contacts = new HashSet<Contact>();
            DcosContacts = new HashSet<DcosContact>();
            DeTransactions = new HashSet<DeTransaction>();
            Debtors = new HashSet<Debtor>();
        }

        public long BlRowid { get; set; }
        public int? BlType { get; set; }
        public byte[]? BlBlob { get; set; }
        public long? BlRowidDebtor { get; set; }
        public long? BlRowidADebtor { get; set; }
        public long? BlRowidClient { get; set; }
        public long? BlRowidAClient { get; set; }
        public DateTime? BlDate { get; set; }
        public TimeSpan? BlTime { get; set; }
        public string? BlStatus { get; set; }
        public string? BlOpid { get; set; }
        public string? BlText { get; set; }
        public byte? BlSticky { get; set; }

        public virtual AClient? BlRowidAClientNavigation { get; set; }
        public virtual ADebtor? BlRowidADebtorNavigation { get; set; }
        public virtual Client? BlRowidClientNavigation { get; set; }
        public virtual Debtor? BlRowidDebtorNavigation { get; set; }
        public virtual ICollection<AAsContact> AAsContacts { get; set; }
        public virtual ICollection<AAtContact> AAtContacts { get; set; }
        public virtual ICollection<AAttachment> AAttachments { get; set; }
        public virtual ICollection<ACatContact> ACatContacts { get; set; }
        public virtual ICollection<AClAttachment> AClAttachments { get; set; }
        public virtual ICollection<AClContact> AClContacts { get; set; }
        public virtual ICollection<AClTransaction> AClTransactions { get; set; }
        public virtual ICollection<AClient> AClients { get; set; }
        public virtual ICollection<AContact> AContacts { get; set; }
        public virtual ICollection<ADcosContact> ADcosContacts { get; set; }
        public virtual ICollection<ADeTransaction> ADeTransactions { get; set; }
        public virtual ICollection<ADebtor> ADebtors { get; set; }
        public virtual ICollection<AsContact> AsContacts { get; set; }
        public virtual ICollection<AtContact> AtContacts { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<CatContact> CatContacts { get; set; }
        public virtual ICollection<ClAttachment> ClAttachments { get; set; }
        public virtual ICollection<ClContact> ClContacts { get; set; }
        public virtual ICollection<ClTransaction> ClTransactions { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<DcosContact> DcosContacts { get; set; }
        public virtual ICollection<DeTransaction> DeTransactions { get; set; }
        public virtual ICollection<Debtor> Debtors { get; set; }
    }
}

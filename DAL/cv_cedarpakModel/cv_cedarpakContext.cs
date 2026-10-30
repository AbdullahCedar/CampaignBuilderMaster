using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.cv_cedarpakModel
{
    public partial class cv_cedarpakContext : DbContext
    {
        public cv_cedarpakContext()
        {
        }

        public cv_cedarpakContext(DbContextOptions<cv_cedarpakContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AAddressLookup> AAddressLookups { get; set; } = null!;
        public virtual DbSet<AAsContact> AAsContacts { get; set; } = null!;
        public virtual DbSet<AAssociated> AAssociateds { get; set; } = null!;
        public virtual DbSet<AAtContact> AAtContacts { get; set; } = null!;
        public virtual DbSet<AAttachment> AAttachments { get; set; } = null!;
        public virtual DbSet<ABank> ABanks { get; set; } = null!;
        public virtual DbSet<ABankAccount> ABankAccounts { get; set; } = null!;
        public virtual DbSet<ACatContact> ACatContacts { get; set; } = null!;
        public virtual DbSet<AClAttachment> AClAttachments { get; set; } = null!;
        public virtual DbSet<AClContact> AClContacts { get; set; } = null!;
        public virtual DbSet<AClTransaction> AClTransactions { get; set; } = null!;
        public virtual DbSet<AClient> AClients { get; set; } = null!;
        public virtual DbSet<AContact> AContacts { get; set; } = null!;
        public virtual DbSet<ACosigner> ACosigners { get; set; } = null!;
        public virtual DbSet<ADcosContact> ADcosContacts { get; set; } = null!;
        public virtual DbSet<ADeTransaction> ADeTransactions { get; set; } = null!;
        public virtual DbSet<ADebtor> ADebtors { get; set; } = null!;
        public virtual DbSet<AEmail> AEmails { get; set; } = null!;
        public virtual DbSet<AInvoice> AInvoices { get; set; } = null!;
        public virtual DbSet<AInvoiceLine> AInvoiceLines { get; set; } = null!;
        public virtual DbSet<ANote> ANotes { get; set; } = null!;
        public virtual DbSet<ANxday> ANxdays { get; set; } = null!;
        public virtual DbSet<APhone> APhones { get; set; } = null!;
        public virtual DbSet<AddressLookup> AddressLookups { get; set; } = null!;
        public virtual DbSet<ApplicationForm> ApplicationForms { get; set; } = null!;
        public virtual DbSet<AsContact> AsContacts { get; set; } = null!;
        public virtual DbSet<Associated> Associateds { get; set; } = null!;
        public virtual DbSet<AtContact> AtContacts { get; set; } = null!;
        public virtual DbSet<Attachment> Attachments { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BankAccount> BankAccounts { get; set; } = null!;
        public virtual DbSet<Blob> Blobs { get; set; } = null!;
        public virtual DbSet<CatContact> CatContacts { get; set; } = null!;
        public virtual DbSet<ClAttachment> ClAttachments { get; set; } = null!;
        public virtual DbSet<ClContact> ClContacts { get; set; } = null!;
        public virtual DbSet<ClTransaction> ClTransactions { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<ContactEvent> ContactEvents { get; set; } = null!;
        public virtual DbSet<ContactPlan> ContactPlans { get; set; } = null!;
        public virtual DbSet<Cosigner> Cosigners { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<CurrencyLookup> CurrencyLookups { get; set; } = null!;
        public virtual DbSet<Dbtag> Dbtags { get; set; } = null!;
        public virtual DbSet<DcosContact> DcosContacts { get; set; } = null!;
        public virtual DbSet<DeTransaction> DeTransactions { get; set; } = null!;
        public virtual DbSet<Debtor> Debtors { get; set; } = null!;
        public virtual DbSet<DebtorStatus> DebtorStatuses { get; set; } = null!;
        public virtual DbSet<Email> Emails { get; set; } = null!;
        public virtual DbSet<FormRight> FormRights { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceLine> InvoiceLines { get; set; } = null!;
        public virtual DbSet<Note> Notes { get; set; } = null!;
        public virtual DbSet<NxOperator> NxOperators { get; set; } = null!;
        public virtual DbSet<NxUser> NxUsers { get; set; } = null!;
        public virtual DbSet<Nxday> Nxdays { get; set; } = null!;
        public virtual DbSet<OperatorLevel> OperatorLevels { get; set; } = null!;
        public virtual DbSet<Phone> Phones { get; set; } = null!;
        public virtual DbSet<RateTable> RateTables { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<TransactionType> TransactionTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.20.93;Initial Catalog=cv_cedarpak;persist security info=True;User id=sa;Password=sa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AAddressLookup>(entity =>
            {
                entity.HasKey(e => e.AddRowid)
                    .HasName("PK__a_addres__2A1A3B5766DD4199");

                entity.ToTable("a_address_lookup");

                entity.HasIndex(e => e.AddRowidAssociated, "add_rowid_associated_key");

                entity.HasIndex(e => e.AddRowidBank, "add_rowid_bank_key");

                entity.HasIndex(e => e.AddRowidClient, "add_rowid_client_key");

                entity.HasIndex(e => e.AddRowidCosigner, "add_rowid_cosigner_key");

                entity.HasIndex(e => e.AddRowidDebtor, "add_rowid_debtor_key");

                entity.Property(e => e.AddRowid).HasColumnName("add_rowid");

                entity.Property(e => e.AddAddress)
                    .HasMaxLength(164)
                    .HasColumnName("add_address");

                entity.Property(e => e.AddAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("add_address_1");

                entity.Property(e => e.AddAddress2)
                    .HasMaxLength(144)
                    .HasColumnName("add_address_2");

                entity.Property(e => e.AddAddressSource).HasColumnName("add_address_source");

                entity.Property(e => e.AddCategory).HasColumnName("add_category");

                entity.Property(e => e.AddCategory1).HasColumnName("add_category_1");

                entity.Property(e => e.AddCategory2).HasColumnName("add_category_2");

                entity.Property(e => e.AddCby)
                    .HasMaxLength(16)
                    .HasColumnName("add_cby");

                entity.Property(e => e.AddCdate)
                    .HasColumnType("date")
                    .HasColumnName("add_cdate");

                entity.Property(e => e.AddCity)
                    .HasMaxLength(64)
                    .HasColumnName("add_city");

                entity.Property(e => e.AddCountry)
                    .HasMaxLength(64)
                    .HasColumnName("add_country");

                entity.Property(e => e.AddCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("add_ctime");

                entity.Property(e => e.AddFlags).HasColumnName("add_flags");

                entity.Property(e => e.AddMby)
                    .HasMaxLength(16)
                    .HasColumnName("add_mby");

                entity.Property(e => e.AddMdate)
                    .HasColumnType("date")
                    .HasColumnName("add_mdate");

                entity.Property(e => e.AddMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("add_mtime");

                entity.Property(e => e.AddRowidAssociated).HasColumnName("add_rowid_associated");

                entity.Property(e => e.AddRowidBank).HasColumnName("add_rowid_bank");

                entity.Property(e => e.AddRowidClient).HasColumnName("add_rowid_client");

                entity.Property(e => e.AddRowidCosigner).HasColumnName("add_rowid_cosigner");

                entity.Property(e => e.AddRowidDebtor).HasColumnName("add_rowid_debtor");

                entity.Property(e => e.AddState)
                    .HasMaxLength(64)
                    .HasColumnName("add_state");

                entity.Property(e => e.AddTimezone).HasColumnName("add_timezone");

                entity.Property(e => e.AddType).HasColumnName("add_type");

                entity.Property(e => e.AddUid).HasColumnName("add_uid");

                entity.Property(e => e.AddUidm).HasColumnName("add_uidm");

                entity.Property(e => e.AddUido).HasColumnName("add_uido");

                entity.Property(e => e.AddUido1).HasColumnName("add_uido_1");

                entity.Property(e => e.AddUido2).HasColumnName("add_uido_2");

                entity.Property(e => e.AddUido3).HasColumnName("add_uido_3");

                entity.Property(e => e.AddUido4).HasColumnName("add_uido_4");

                entity.Property(e => e.AddZip)
                    .HasMaxLength(48)
                    .HasColumnName("add_zip");

                entity.HasOne(d => d.AddRowidAssociatedNavigation)
                    .WithMany(p => p.AAddressLookups)
                    .HasForeignKey(d => d.AddRowidAssociated)
                    .HasConstraintName("FK__a_address__add_r__48CFD27E");

                entity.HasOne(d => d.AddRowidBankNavigation)
                    .WithMany(p => p.AAddressLookups)
                    .HasForeignKey(d => d.AddRowidBank)
                    .HasConstraintName("FK__a_address__add_r__44FF419A");

                entity.HasOne(d => d.AddRowidClientNavigation)
                    .WithMany(p => p.AAddressLookups)
                    .HasForeignKey(d => d.AddRowidClient)
                    .HasConstraintName("FK__a_address__add_r__45F365D3");

                entity.HasOne(d => d.AddRowidCosignerNavigation)
                    .WithMany(p => p.AAddressLookups)
                    .HasForeignKey(d => d.AddRowidCosigner)
                    .HasConstraintName("FK__a_address__add_r__47DBAE45");

                entity.HasOne(d => d.AddRowidDebtorNavigation)
                    .WithMany(p => p.AAddressLookups)
                    .HasForeignKey(d => d.AddRowidDebtor)
                    .HasConstraintName("FK__a_address__add_r__46E78A0C");
            });

            modelBuilder.Entity<AAsContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__a_as_con__91C3A18C0BD31697");

                entity.ToTable("a_as_contact");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidAssociated).HasColumnName("co_rowid_associated");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.AAsContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__a_as_cont__co_at__52593CB8");

                entity.HasOne(d => d.CoRowidAssociatedNavigation)
                    .WithMany(p => p.AAsContacts)
                    .HasForeignKey(d => d.CoRowidAssociated)
                    .HasConstraintName("FK__a_as_cont__co_ro__5165187F");
            });

            modelBuilder.Entity<AAssociated>(entity =>
            {
                entity.HasKey(e => e.AsCosRowid)
                    .HasName("PK__a_associ__62B199EB71065766");

                entity.ToTable("a_associated");

                entity.HasIndex(e => e.AsCosBusinessPhone, "as_cos_business_phone_key");

                entity.HasIndex(e => e.AsCosCategory1, "as_cos_category_1_key");

                entity.HasIndex(e => e.AsCosCategory, "as_cos_category_key");

                entity.HasIndex(e => e.AsCosCellPhone, "as_cos_cell_phone_key");

                entity.HasIndex(e => e.AsCosCity, "as_cos_city_key");

                entity.HasIndex(e => e.AsCosDl, "as_cos_dl_key");

                entity.HasIndex(e => e.AsCosDob, "as_cos_dob_key");

                entity.HasIndex(e => e.AsCosEmail, "as_cos_email_key");

                entity.HasIndex(e => e.AsCosName, "as_cos_name_key");

                entity.HasIndex(e => e.AsCosOtherPhone, "as_cos_other_phone_key");

                entity.HasIndex(e => e.AsCosPhone, "as_cos_phone_key");

                entity.HasIndex(e => e.AsCosRowidClient, "as_cos_rowid_client_key");

                entity.HasIndex(e => e.AsCosSin, "as_cos_sin_key");

                entity.HasIndex(e => e.AsCosState, "as_cos_state_key");

                entity.HasIndex(e => e.AsCosZip, "as_cos_zip_key");

                entity.HasIndex(e => e.AsCosigner, "as_cosigner_key");

                entity.Property(e => e.AsCosRowid).HasColumnName("as_cos_rowid");

                entity.Property(e => e.AsCosAddress)
                    .HasMaxLength(164)
                    .HasColumnName("as_cos_address");

                entity.Property(e => e.AsCosAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("as_cos_address_1");

                entity.Property(e => e.AsCosAddress2)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_address_2");

                entity.Property(e => e.AsCosAddressFlags).HasColumnName("as_cos_address_flags");

                entity.Property(e => e.AsCosAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_amount");

                entity.Property(e => e.AsCosAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_amount_1");

                entity.Property(e => e.AsCosAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_amount_2");

                entity.Property(e => e.AsCosAttachNum).HasColumnName("as_cos_attach_num");

                entity.Property(e => e.AsCosBusinessExt)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_business_ext");

                entity.Property(e => e.AsCosBusinessPhone)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_business_phone");

                entity.Property(e => e.AsCosCategory).HasColumnName("as_cos_category");

                entity.Property(e => e.AsCosCategory1).HasColumnName("as_cos_category_1");

                entity.Property(e => e.AsCosCategory2).HasColumnName("as_cos_category_2");

                entity.Property(e => e.AsCosCbrAssociation)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_cbr_association");

                entity.Property(e => e.AsCosCby)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_cby");

                entity.Property(e => e.AsCosCdate)
                    .HasColumnType("date")
                    .HasColumnName("as_cos_cdate");

                entity.Property(e => e.AsCosCellExt)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_cell_ext");

                entity.Property(e => e.AsCosCellPhone)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_cell_phone");

                entity.Property(e => e.AsCosCinfoInd)
                    .HasMaxLength(8)
                    .HasColumnName("as_cos_cinfo_ind");

                entity.Property(e => e.AsCosCity)
                    .HasMaxLength(64)
                    .HasColumnName("as_cos_city");

                entity.Property(e => e.AsCosClass).HasColumnName("as_cos_class");

                entity.Property(e => e.AsCosCountry)
                    .HasMaxLength(64)
                    .HasColumnName("as_cos_country");

                entity.Property(e => e.AsCosCreated).HasColumnName("as_cos_created");

                entity.Property(e => e.AsCosCreatedBy)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_created_by");

                entity.Property(e => e.AsCosCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("as_cos_ctime");

                entity.Property(e => e.AsCosDate1)
                    .HasColumnType("date")
                    .HasColumnName("as_cos_date_1");

                entity.Property(e => e.AsCosDate2)
                    .HasColumnType("date")
                    .HasColumnName("as_cos_date_2");

                entity.Property(e => e.AsCosDl)
                    .HasMaxLength(160)
                    .HasColumnName("as_cos_dl");

                entity.Property(e => e.AsCosDob).HasColumnName("as_cos_dob");

                entity.Property(e => e.AsCosEcoa)
                    .HasMaxLength(8)
                    .HasColumnName("as_cos_ecoa");

                entity.Property(e => e.AsCosEmail)
                    .HasMaxLength(256)
                    .HasColumnName("as_cos_email");

                entity.Property(e => e.AsCosEmailNum).HasColumnName("as_cos_email_num");

                entity.Property(e => e.AsCosEntity).HasColumnName("as_cos_entity");

                entity.Property(e => e.AsCosFlags1).HasColumnName("as_cos_flags_1");

                entity.Property(e => e.AsCosFlags2).HasColumnName("as_cos_flags_2");

                entity.Property(e => e.AsCosGroupFlags).HasColumnName("as_cos_group_flags");

                entity.Property(e => e.AsCosGroupId).HasColumnName("as_cos_group_id");

                entity.Property(e => e.AsCosGroupMember).HasColumnName("as_cos_group_member");

                entity.Property(e => e.AsCosLetterNum).HasColumnName("as_cos_letter_num");

                entity.Property(e => e.AsCosMby)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_mby");

                entity.Property(e => e.AsCosMdate)
                    .HasColumnType("date")
                    .HasColumnName("as_cos_mdate");

                entity.Property(e => e.AsCosModified).HasColumnName("as_cos_modified");

                entity.Property(e => e.AsCosModifiedBy)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_modified_by");

                entity.Property(e => e.AsCosMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("as_cos_mtime");

                entity.Property(e => e.AsCosName)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_name");

                entity.Property(e => e.AsCosNote1)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_note_1");

                entity.Property(e => e.AsCosNote2)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_note_2");

                entity.Property(e => e.AsCosNote3)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_note_3");

                entity.Property(e => e.AsCosNote4)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_note_4");

                entity.Property(e => e.AsCosNumber1).HasColumnName("as_cos_number_1");

                entity.Property(e => e.AsCosNumber2).HasColumnName("as_cos_number_2");

                entity.Property(e => e.AsCosOp1)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_op_1");

                entity.Property(e => e.AsCosOp2)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_op_2");

                entity.Property(e => e.AsCosOtherExt)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_other_ext");

                entity.Property(e => e.AsCosOtherPhone)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_other_phone");

                entity.Property(e => e.AsCosPercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_percent");

                entity.Property(e => e.AsCosPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_percent_1");

                entity.Property(e => e.AsCosPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_percent_2");

                entity.Property(e => e.AsCosPhone)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_phone");

                entity.Property(e => e.AsCosPhoneExt)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_phone_ext");

                entity.Property(e => e.AsCosRowidClient).HasColumnName("as_cos_rowid_client");

                entity.Property(e => e.AsCosSin)
                    .HasMaxLength(160)
                    .HasColumnName("as_cos_sin");

                entity.Property(e => e.AsCosState)
                    .HasMaxLength(64)
                    .HasColumnName("as_cos_state");

                entity.Property(e => e.AsCosStreetNumber)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_street_number");

                entity.Property(e => e.AsCosTimezone).HasColumnName("as_cos_timezone");

                entity.Property(e => e.AsCosTitle)
                    .HasMaxLength(64)
                    .HasColumnName("as_cos_title");

                entity.Property(e => e.AsCosType).HasColumnName("as_cos_type");

                entity.Property(e => e.AsCosUid).HasColumnName("as_cos_uid");

                entity.Property(e => e.AsCosUidm).HasColumnName("as_cos_uidm");

                entity.Property(e => e.AsCosUido).HasColumnName("as_cos_uido");

                entity.Property(e => e.AsCosZip)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_zip");

                entity.Property(e => e.AsCosigner)
                    .HasMaxLength(128)
                    .HasColumnName("as_cosigner");

                entity.HasOne(d => d.AsCosRowidClientNavigation)
                    .WithMany(p => p.AAssociateds)
                    .HasForeignKey(d => d.AsCosRowidClient)
                    .HasConstraintName("FK__a_associa__as_co__286302EC");
            });

            modelBuilder.Entity<AAtContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__a_at_con__91C3A18C7D4187C9");

                entity.ToTable("a_at_contact");

                entity.HasIndex(e => e.CoAttachmentBlob, "co_attachment_blob_key");

                entity.HasIndex(e => e.CoCategory1, "co_category_1_key");

                entity.HasIndex(e => e.CoCategory, "co_category_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoType, e.CoDate }, "co_completedtypedate_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoWho, e.CoDate }, "co_completedwhodate_key");

                entity.HasIndex(e => e.CoDate, "co_date_key");

                entity.HasIndex(e => e.CoDoneDate, "co_done_date_key");

                entity.HasIndex(e => new { e.CoOriginator, e.CoCreationDate }, "co_originatordate_key");

                entity.HasIndex(e => e.CoRowidAttachment, "co_rowid_attachment_key");

                entity.HasIndex(e => new { e.CoType, e.CoCompleted, e.CoWho, e.CoDate }, "co_typecompletedwhodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoDoneDate }, "co_whodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoType, e.CoDate }, "co_whotypedate_key");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidAttachment).HasColumnName("co_rowid_attachment");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.AAtContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__a_at_cont__co_at__619B8048");

                entity.HasOne(d => d.CoRowidAttachmentNavigation)
                    .WithMany(p => p.AAtContacts)
                    .HasForeignKey(d => d.CoRowidAttachment)
                    .HasConstraintName("FK__a_at_cont__co_ro__60A75C0F");
            });

            modelBuilder.Entity<AAttachment>(entity =>
            {
                entity.HasKey(e => e.AtRowid)
                    .HasName("PK__a_attach__39C176A46F3E37B8");

                entity.ToTable("a_attachment");

                entity.HasIndex(e => e.AtBlob, "at_blob_key");

                entity.HasIndex(e => e.AtDate1, "at_date_1_key");

                entity.HasIndex(e => e.AtDate2, "at_date_2_key");

                entity.HasIndex(e => e.AtDetail1, "at_detail_1_key");

                entity.HasIndex(e => e.AtDetail2, "at_detail_2_key");

                entity.HasIndex(e => e.AtRowidDebtor, "at_rowid_debtor_key");

                entity.Property(e => e.AtRowid).HasColumnName("at_rowid");

                entity.Property(e => e.AtBlob).HasColumnName("at_blob");

                entity.Property(e => e.AtCategory).HasColumnName("at_category");

                entity.Property(e => e.AtCategory1).HasColumnName("at_category_1");

                entity.Property(e => e.AtCategory2).HasColumnName("at_category_2");

                entity.Property(e => e.AtCby)
                    .HasMaxLength(16)
                    .HasColumnName("at_cby");

                entity.Property(e => e.AtCdate)
                    .HasColumnType("date")
                    .HasColumnName("at_cdate");

                entity.Property(e => e.AtClass).HasColumnName("at_class");

                entity.Property(e => e.AtCreatedBy)
                    .HasMaxLength(16)
                    .HasColumnName("at_created_by");

                entity.Property(e => e.AtCreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("at_created_date");

                entity.Property(e => e.AtCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("at_ctime");

                entity.Property(e => e.AtDate1)
                    .HasColumnType("date")
                    .HasColumnName("at_date_1");

                entity.Property(e => e.AtDate2)
                    .HasColumnType("date")
                    .HasColumnName("at_date_2");

                entity.Property(e => e.AtDate3)
                    .HasColumnType("date")
                    .HasColumnName("at_date_3");

                entity.Property(e => e.AtDescription)
                    .HasMaxLength(256)
                    .HasColumnName("at_description");

                entity.Property(e => e.AtDetail1)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_1");

                entity.Property(e => e.AtDetail10)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_10");

                entity.Property(e => e.AtDetail11)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_11");

                entity.Property(e => e.AtDetail12)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_12");

                entity.Property(e => e.AtDetail13)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_13");

                entity.Property(e => e.AtDetail14)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_14");

                entity.Property(e => e.AtDetail15)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_15");

                entity.Property(e => e.AtDetail16)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_16");

                entity.Property(e => e.AtDetail2)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_2");

                entity.Property(e => e.AtDetail3)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_3");

                entity.Property(e => e.AtDetail4)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_4");

                entity.Property(e => e.AtDetail5)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_5");

                entity.Property(e => e.AtDetail6)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_6");

                entity.Property(e => e.AtDetail7)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_7");

                entity.Property(e => e.AtDetail8)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_8");

                entity.Property(e => e.AtDetail9)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_9");

                entity.Property(e => e.AtFactor).HasColumnName("at_factor");

                entity.Property(e => e.AtFile)
                    .HasMaxLength(264)
                    .HasColumnName("at_file");

                entity.Property(e => e.AtMby)
                    .HasMaxLength(16)
                    .HasColumnName("at_mby");

                entity.Property(e => e.AtMdate)
                    .HasColumnType("date")
                    .HasColumnName("at_mdate");

                entity.Property(e => e.AtModifiedBy)
                    .HasMaxLength(16)
                    .HasColumnName("at_modified_by");

                entity.Property(e => e.AtModifiedDate)
                    .HasColumnType("date")
                    .HasColumnName("at_modified_date");

                entity.Property(e => e.AtMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("at_mtime");

                entity.Property(e => e.AtRowidDebtor).HasColumnName("at_rowid_debtor");

                entity.Property(e => e.AtSeqDebtor).HasColumnName("at_seq_debtor");

                entity.Property(e => e.AtTotalCredits)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("at_total_credits");

                entity.Property(e => e.AtTotalDebits)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("at_total_debits");

                entity.Property(e => e.AtTotalResult)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("at_total_result");

                entity.Property(e => e.AtType).HasColumnName("at_type");

                entity.Property(e => e.AtUid).HasColumnName("at_uid");

                entity.Property(e => e.AtUidm).HasColumnName("at_uidm");

                entity.Property(e => e.AtUido).HasColumnName("at_uido");

                entity.Property(e => e.AtValue).HasColumnName("at_value");

                entity.HasOne(d => d.AtBlobNavigation)
                    .WithMany(p => p.AAttachments)
                    .HasForeignKey(d => d.AtBlob)
                    .HasConstraintName("FK__a_attachm__at_bl__59FA5E80");

                entity.HasOne(d => d.AtRowidDebtorNavigation)
                    .WithMany(p => p.AAttachments)
                    .HasForeignKey(d => d.AtRowidDebtor)
                    .HasConstraintName("FK__a_attachm__at_ro__59063A47");
            });

            modelBuilder.Entity<ABank>(entity =>
            {
                entity.HasKey(e => e.BkRowid)
                    .HasName("PK__a_bank__8EA6D3623DABC8A5");

                entity.ToTable("a_bank");

                entity.HasIndex(e => e.BkCategory, "bk_category_key");

                entity.HasIndex(e => e.BkRoutingNo, "bk_routing_no_key");

                entity.HasIndex(e => e.BkRowidAccount, "bk_rowid_account_key");

                entity.Property(e => e.BkRowid).HasColumnName("bk_rowid");

                entity.Property(e => e.BkAccess)
                    .HasMaxLength(16)
                    .HasColumnName("bk_access");

                entity.Property(e => e.BkAddress)
                    .HasMaxLength(164)
                    .HasColumnName("bk_address");

                entity.Property(e => e.BkAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("bk_address_1");

                entity.Property(e => e.BkAddressCity)
                    .HasMaxLength(64)
                    .HasColumnName("bk_address_city");

                entity.Property(e => e.BkAddressCountry)
                    .HasMaxLength(64)
                    .HasColumnName("bk_address_country");

                entity.Property(e => e.BkAddressFlags).HasColumnName("bk_address_flags");

                entity.Property(e => e.BkAddressState)
                    .HasMaxLength(64)
                    .HasColumnName("bk_address_state");

                entity.Property(e => e.BkAddressStreetNo)
                    .HasMaxLength(48)
                    .HasColumnName("bk_address_street_no");

                entity.Property(e => e.BkAddressZip)
                    .HasMaxLength(48)
                    .HasColumnName("bk_address_zip");

                entity.Property(e => e.BkBank)
                    .HasMaxLength(256)
                    .HasColumnName("bk_bank");

                entity.Property(e => e.BkBranch)
                    .HasMaxLength(160)
                    .HasColumnName("bk_branch");

                entity.Property(e => e.BkCategory).HasColumnName("bk_category");

                entity.Property(e => e.BkCategory1).HasColumnName("bk_category_1");

                entity.Property(e => e.BkCategory2).HasColumnName("bk_category_2");

                entity.Property(e => e.BkCby)
                    .HasMaxLength(16)
                    .HasColumnName("bk_cby");

                entity.Property(e => e.BkCdate)
                    .HasColumnType("date")
                    .HasColumnName("bk_cdate");

                entity.Property(e => e.BkClerk)
                    .HasMaxLength(16)
                    .HasColumnName("bk_clerk");

                entity.Property(e => e.BkCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("bk_ctime");

                entity.Property(e => e.BkDate1)
                    .HasColumnType("date")
                    .HasColumnName("bk_date_1");

                entity.Property(e => e.BkDate2)
                    .HasColumnType("date")
                    .HasColumnName("bk_date_2");

                entity.Property(e => e.BkFax)
                    .HasMaxLength(48)
                    .HasColumnName("bk_fax");

                entity.Property(e => e.BkFaxExtension)
                    .HasMaxLength(16)
                    .HasColumnName("bk_fax_extension");

                entity.Property(e => e.BkFlags1).HasColumnName("bk_flags_1");

                entity.Property(e => e.BkFlags2).HasColumnName("bk_flags_2");

                entity.Property(e => e.BkMby)
                    .HasMaxLength(16)
                    .HasColumnName("bk_mby");

                entity.Property(e => e.BkMdate)
                    .HasColumnType("date")
                    .HasColumnName("bk_mdate");

                entity.Property(e => e.BkMoney1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bk_money_1");

                entity.Property(e => e.BkMoney2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bk_money_2");

                entity.Property(e => e.BkMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("bk_mtime");

                entity.Property(e => e.BkNumber1).HasColumnName("bk_number_1");

                entity.Property(e => e.BkNumber2).HasColumnName("bk_number_2");

                entity.Property(e => e.BkOp1)
                    .HasMaxLength(16)
                    .HasColumnName("bk_op_1");

                entity.Property(e => e.BkOp2)
                    .HasMaxLength(16)
                    .HasColumnName("bk_op_2");

                entity.Property(e => e.BkOther)
                    .HasMaxLength(48)
                    .HasColumnName("bk_other");

                entity.Property(e => e.BkOtherExtension)
                    .HasMaxLength(16)
                    .HasColumnName("bk_other_extension");

                entity.Property(e => e.BkPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bk_percent_1");

                entity.Property(e => e.BkPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bk_percent_2");

                entity.Property(e => e.BkPhone)
                    .HasMaxLength(48)
                    .HasColumnName("bk_phone");

                entity.Property(e => e.BkPhoneExtension)
                    .HasMaxLength(16)
                    .HasColumnName("bk_phone_extension");

                entity.Property(e => e.BkRoutingNo)
                    .HasMaxLength(64)
                    .HasColumnName("bk_routing_no");

                entity.Property(e => e.BkRowidAccount).HasColumnName("bk_rowid_account");

                entity.Property(e => e.BkTimezone).HasColumnName("bk_timezone");

                entity.Property(e => e.BkUid).HasColumnName("bk_uid");

                entity.Property(e => e.BkUidm).HasColumnName("bk_uidm");

                entity.Property(e => e.BkUido).HasColumnName("bk_uido");

                entity.Property(e => e.BkUser1)
                    .HasMaxLength(128)
                    .HasColumnName("bk_user_1");

                entity.Property(e => e.BkUser2)
                    .HasMaxLength(128)
                    .HasColumnName("bk_user_2");

                entity.Property(e => e.BkUser3)
                    .HasMaxLength(128)
                    .HasColumnName("bk_user_3");

                entity.Property(e => e.BkUser4)
                    .HasMaxLength(128)
                    .HasColumnName("bk_user_4");

                entity.HasOne(d => d.BkRowidAccountNavigation)
                    .WithMany(p => p.ABanks)
                    .HasForeignKey(d => d.BkRowidAccount)
                    .HasConstraintName("FK__a_bank__bk_rowid__3B75D760");
            });

            modelBuilder.Entity<ABankAccount>(entity =>
            {
                entity.HasKey(e => e.BkaccRowid)
                    .HasName("PK__a_bank_a__37A99D43A0E2625B");

                entity.ToTable("a_bank_account");

                entity.HasIndex(e => e.BkaccCategory, "bkacc_category_key");

                entity.HasIndex(e => e.BkaccRowidAssociated, "bkacc_rowid_associated_key");

                entity.HasIndex(e => e.BkaccRowidClient, "bkacc_rowid_client_key");

                entity.HasIndex(e => e.BkaccRowidCosigner, "bkacc_rowid_cosigner_key");

                entity.HasIndex(e => e.BkaccRowidDebtor, "bkacc_rowid_debtor_key");

                entity.Property(e => e.BkaccRowid).HasColumnName("bkacc_rowid");

                entity.Property(e => e.BkaccAccount)
                    .HasMaxLength(160)
                    .HasColumnName("bkacc_account");

                entity.Property(e => e.BkaccBankRoutingNo)
                    .HasMaxLength(64)
                    .HasColumnName("bkacc_bank_routing_no");

                entity.Property(e => e.BkaccCategory).HasColumnName("bkacc_category");

                entity.Property(e => e.BkaccCategory1).HasColumnName("bkacc_category_1");

                entity.Property(e => e.BkaccCategory2).HasColumnName("bkacc_category_2");

                entity.Property(e => e.BkaccCby)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_cby");

                entity.Property(e => e.BkaccCdate)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_cdate");

                entity.Property(e => e.BkaccCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("bkacc_ctime");

                entity.Property(e => e.BkaccCurrency).HasColumnName("bkacc_currency");

                entity.Property(e => e.BkaccDate1)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_date_1");

                entity.Property(e => e.BkaccDate2)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_date_2");

                entity.Property(e => e.BkaccExpDate)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_exp_date");

                entity.Property(e => e.BkaccFlags1).HasColumnName("bkacc_flags_1");

                entity.Property(e => e.BkaccFlags2).HasColumnName("bkacc_flags_2");

                entity.Property(e => e.BkaccId)
                    .HasMaxLength(20)
                    .HasColumnName("bkacc_id");

                entity.Property(e => e.BkaccMby)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_mby");

                entity.Property(e => e.BkaccMdate)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_mdate");

                entity.Property(e => e.BkaccMoney1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bkacc_money_1");

                entity.Property(e => e.BkaccMoney2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bkacc_money_2");

                entity.Property(e => e.BkaccMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("bkacc_mtime");

                entity.Property(e => e.BkaccNameOnAccount)
                    .HasMaxLength(164)
                    .HasColumnName("bkacc_name_on_account");

                entity.Property(e => e.BkaccNumber1).HasColumnName("bkacc_number_1");

                entity.Property(e => e.BkaccNumber2).HasColumnName("bkacc_number_2");

                entity.Property(e => e.BkaccOp1)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_op_1");

                entity.Property(e => e.BkaccOp2)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_op_2");

                entity.Property(e => e.BkaccPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bkacc_percent_1");

                entity.Property(e => e.BkaccPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bkacc_percent_2");

                entity.Property(e => e.BkaccPin)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_pin");

                entity.Property(e => e.BkaccRowidAssociated).HasColumnName("bkacc_rowid_associated");

                entity.Property(e => e.BkaccRowidClient).HasColumnName("bkacc_rowid_client");

                entity.Property(e => e.BkaccRowidCosigner).HasColumnName("bkacc_rowid_cosigner");

                entity.Property(e => e.BkaccRowidDebtor).HasColumnName("bkacc_rowid_debtor");

                entity.Property(e => e.BkaccUid).HasColumnName("bkacc_uid");

                entity.Property(e => e.BkaccUidm).HasColumnName("bkacc_uidm");

                entity.Property(e => e.BkaccUido).HasColumnName("bkacc_uido");

                entity.Property(e => e.BkaccUido1).HasColumnName("bkacc_uido_1");

                entity.Property(e => e.BkaccUido2).HasColumnName("bkacc_uido_2");

                entity.Property(e => e.BkaccUido3).HasColumnName("bkacc_uido_3");

                entity.Property(e => e.BkaccUser1)
                    .HasMaxLength(128)
                    .HasColumnName("bkacc_user_1");

                entity.Property(e => e.BkaccUser2)
                    .HasMaxLength(128)
                    .HasColumnName("bkacc_user_2");

                entity.Property(e => e.BkaccUser3)
                    .HasMaxLength(128)
                    .HasColumnName("bkacc_user_3");

                entity.Property(e => e.BkaccUser4)
                    .HasMaxLength(128)
                    .HasColumnName("bkacc_user_4");

                entity.HasOne(d => d.BkaccRowidAssociatedNavigation)
                    .WithMany(p => p.ABankAccounts)
                    .HasForeignKey(d => d.BkaccRowidAssociated)
                    .HasConstraintName("FK__a_bank_ac__bkacc__33D4B598");

                entity.HasOne(d => d.BkaccRowidClientNavigation)
                    .WithMany(p => p.ABankAccounts)
                    .HasForeignKey(d => d.BkaccRowidClient)
                    .HasConstraintName("FK__a_bank_ac__bkacc__31EC6D26");

                entity.HasOne(d => d.BkaccRowidCosignerNavigation)
                    .WithMany(p => p.ABankAccounts)
                    .HasForeignKey(d => d.BkaccRowidCosigner)
                    .HasConstraintName("FK__a_bank_ac__bkacc__32E0915F");

                entity.HasOne(d => d.BkaccRowidDebtorNavigation)
                    .WithMany(p => p.ABankAccounts)
                    .HasForeignKey(d => d.BkaccRowidDebtor)
                    .HasConstraintName("FK__a_bank_ac__bkacc__30F848ED");
            });

            modelBuilder.Entity<ACatContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__a_cat_co__91C3A18CC8B450FC");

                entity.ToTable("a_cat_contact");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidClAttachment).HasColumnName("co_rowid_cl_attachment");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.ACatContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__a_cat_con__co_at__70DDC3D8");

                entity.HasOne(d => d.CoRowidClAttachmentNavigation)
                    .WithMany(p => p.ACatContacts)
                    .HasForeignKey(d => d.CoRowidClAttachment)
                    .HasConstraintName("FK__a_cat_con__co_ro__6FE99F9F");
            });

            modelBuilder.Entity<AClAttachment>(entity =>
            {
                entity.HasKey(e => e.ClAtRowid)
                    .HasName("PK__a_cl_att__CFA34B45CBAEEF52");

                entity.ToTable("a_cl_attachment");

                entity.HasIndex(e => e.ClAtBlob, "cl_at_blob_key");

                entity.HasIndex(e => e.ClAtDate1, "cl_at_date_1_key");

                entity.HasIndex(e => e.ClAtDate2, "cl_at_date_2_key");

                entity.HasIndex(e => e.ClAtDetail1, "cl_at_detail_1_key");

                entity.HasIndex(e => e.ClAtDetail2, "cl_at_detail_2_key");

                entity.HasIndex(e => e.ClAtRowidClient, "cl_at_rowid_client_key");

                entity.Property(e => e.ClAtRowid).HasColumnName("cl_at_rowid");

                entity.Property(e => e.ClAtBlob).HasColumnName("cl_at_blob");

                entity.Property(e => e.ClAtCategory).HasColumnName("cl_at_category");

                entity.Property(e => e.ClAtCategory1).HasColumnName("cl_at_category_1");

                entity.Property(e => e.ClAtCategory2).HasColumnName("cl_at_category_2");

                entity.Property(e => e.ClAtCby)
                    .HasMaxLength(16)
                    .HasColumnName("cl_at_cby");

                entity.Property(e => e.ClAtCdate)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_cdate");

                entity.Property(e => e.ClAtClass).HasColumnName("cl_at_class");

                entity.Property(e => e.ClAtCreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_created_date");

                entity.Property(e => e.ClAtCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cl_at_ctime");

                entity.Property(e => e.ClAtDate1)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_date_1");

                entity.Property(e => e.ClAtDate2)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_date_2");

                entity.Property(e => e.ClAtDate3)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_date_3");

                entity.Property(e => e.ClAtDescription)
                    .HasMaxLength(256)
                    .HasColumnName("cl_at_description");

                entity.Property(e => e.ClAtDetail1)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_1");

                entity.Property(e => e.ClAtDetail10)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_10");

                entity.Property(e => e.ClAtDetail11)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_11");

                entity.Property(e => e.ClAtDetail12)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_12");

                entity.Property(e => e.ClAtDetail13)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_13");

                entity.Property(e => e.ClAtDetail14)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_14");

                entity.Property(e => e.ClAtDetail15)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_15");

                entity.Property(e => e.ClAtDetail16)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_16");

                entity.Property(e => e.ClAtDetail2)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_2");

                entity.Property(e => e.ClAtDetail3)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_3");

                entity.Property(e => e.ClAtDetail4)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_4");

                entity.Property(e => e.ClAtDetail5)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_5");

                entity.Property(e => e.ClAtDetail6)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_6");

                entity.Property(e => e.ClAtDetail7)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_7");

                entity.Property(e => e.ClAtDetail8)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_8");

                entity.Property(e => e.ClAtDetail9)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_9");

                entity.Property(e => e.ClAtFactor).HasColumnName("cl_at_factor");

                entity.Property(e => e.ClAtFile)
                    .HasMaxLength(264)
                    .HasColumnName("cl_at_file");

                entity.Property(e => e.ClAtMby)
                    .HasMaxLength(16)
                    .HasColumnName("cl_at_mby");

                entity.Property(e => e.ClAtMdate)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_mdate");

                entity.Property(e => e.ClAtModifiedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_modified_date");

                entity.Property(e => e.ClAtMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cl_at_mtime");

                entity.Property(e => e.ClAtRowidClient).HasColumnName("cl_at_rowid_client");

                entity.Property(e => e.ClAtTotalDebits)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_at_total_debits");

                entity.Property(e => e.ClAtTotalResult)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_at_total_result");

                entity.Property(e => e.ClAtType).HasColumnName("cl_at_type");

                entity.Property(e => e.ClAtUid).HasColumnName("cl_at_uid");

                entity.Property(e => e.ClAtUidm).HasColumnName("cl_at_uidm");

                entity.Property(e => e.ClAtUido).HasColumnName("cl_at_uido");

                entity.Property(e => e.ClAtValue).HasColumnName("cl_at_value");

                entity.Property(e => e.ClTotalCredits)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_total_credits");

                entity.HasOne(d => d.ClAtBlobNavigation)
                    .WithMany(p => p.AClAttachments)
                    .HasForeignKey(d => d.ClAtBlob)
                    .HasConstraintName("FK__a_cl_atta__cl_at__693CA210");

                entity.HasOne(d => d.ClAtRowidClientNavigation)
                    .WithMany(p => p.AClAttachments)
                    .HasForeignKey(d => d.ClAtRowidClient)
                    .HasConstraintName("FK__a_cl_atta__cl_at__68487DD7");
            });

            modelBuilder.Entity<AClContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__a_cl_con__91C3A18C4F3351E5");

                entity.ToTable("a_cl_contact");

                entity.HasIndex(e => e.CoAttachmentBlob, "co_attachment_blob_key");

                entity.HasIndex(e => e.CoCategory1, "co_category_1_key");

                entity.HasIndex(e => e.CoCategory, "co_category_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoType, e.CoDate }, "co_completedtypedate_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoWho, e.CoDate }, "co_completedwhodate_key");

                entity.HasIndex(e => e.CoDate, "co_date_key");

                entity.HasIndex(e => e.CoDoneDate, "co_done_date_key");

                entity.HasIndex(e => new { e.CoOriginator, e.CoCreationDate }, "co_originatordate_key");

                entity.HasIndex(e => e.CoRowidClient, "co_rowid_client_key");

                entity.HasIndex(e => new { e.CoType, e.CoCompleted, e.CoWho, e.CoDate }, "co_typecompletedwhodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoDoneDate }, "co_whodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoType, e.CoDate }, "co_whotypedate_key");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidClient).HasColumnName("co_rowid_client");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.AClContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__a_cl_cont__co_at__787EE5A0");

                entity.HasOne(d => d.CoRowidClientNavigation)
                    .WithMany(p => p.AClContacts)
                    .HasForeignKey(d => d.CoRowidClient)
                    .HasConstraintName("FK__a_cl_cont__co_ro__778AC167");
            });

            modelBuilder.Entity<AClTransaction>(entity =>
            {
                entity.HasKey(e => e.TrRowid)
                    .HasName("PK__a_cl_tra__C5AB8E9254D23D69");

                entity.ToTable("a_cl_transaction");

                entity.HasIndex(e => e.TrBlob, "tr_blob_key");

                entity.HasIndex(e => e.TrCategory1, "tr_category_1_key");

                entity.HasIndex(e => e.TrCategory2, "tr_category_2_key");

                entity.HasIndex(e => e.TrCategory, "tr_category_key");

                entity.HasIndex(e => e.TrPostedDate, "tr_posted_date_key");

                entity.HasIndex(e => e.TrRowidClient, "tr_rowid_client_key");

                entity.Property(e => e.TrRowid).HasColumnName("tr_rowid");

                entity.Property(e => e.TrAccount).HasColumnName("tr_account");

                entity.Property(e => e.TrActual)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_actual");

                entity.Property(e => e.TrAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_adjustment");

                entity.Property(e => e.TrAgencyAcctCurrency).HasColumnName("tr_agency_acct_currency");

                entity.Property(e => e.TrAgencyExchangeAmt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_agency_exchange_amt");

                entity.Property(e => e.TrAgencyExchangeRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_agency_exchange_rate");

                entity.Property(e => e.TrAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("tr_attachment");

                entity.Property(e => e.TrBlob).HasColumnName("tr_blob");

                entity.Property(e => e.TrBucket10)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_10");

                entity.Property(e => e.TrBucket11)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_11");

                entity.Property(e => e.TrBucket12)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_12");

                entity.Property(e => e.TrBucket13)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_13");

                entity.Property(e => e.TrBucket14)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_14");

                entity.Property(e => e.TrBucket15)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_15");

                entity.Property(e => e.TrBucket16)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_16");

                entity.Property(e => e.TrBucket5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_5");

                entity.Property(e => e.TrBucket6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_6");

                entity.Property(e => e.TrBucket7)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_7");

                entity.Property(e => e.TrBucket8)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_8");

                entity.Property(e => e.TrBucket9)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_9");

                entity.Property(e => e.TrCategory).HasColumnName("tr_category");

                entity.Property(e => e.TrCategory1).HasColumnName("tr_category_1");

                entity.Property(e => e.TrCategory2).HasColumnName("tr_category_2");

                entity.Property(e => e.TrCby)
                    .HasMaxLength(16)
                    .HasColumnName("tr_cby");

                entity.Property(e => e.TrCdate)
                    .HasColumnType("date")
                    .HasColumnName("tr_cdate");

                entity.Property(e => e.TrCommFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_fees");

                entity.Property(e => e.TrCommInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_interest");

                entity.Property(e => e.TrCommLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_legal");

                entity.Property(e => e.TrCommMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_misc");

                entity.Property(e => e.TrCommOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_other");

                entity.Property(e => e.TrCommPrinc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_princ");

                entity.Property(e => e.TrCommRateOption).HasColumnName("tr_comm_rate_option");

                entity.Property(e => e.TrCommissionAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_amount");

                entity.Property(e => e.TrCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate");

                entity.Property(e => e.TrCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_1");

                entity.Property(e => e.TrCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_2");

                entity.Property(e => e.TrCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_3");

                entity.Property(e => e.TrConfirmationDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_confirmation_date");

                entity.Property(e => e.TrConfirmationNumber)
                    .HasMaxLength(128)
                    .HasColumnName("tr_confirmation_number");

                entity.Property(e => e.TrConfirmationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_confirmation_time");

                entity.Property(e => e.TrCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_ctime");

                entity.Property(e => e.TrCurrency).HasColumnName("tr_currency");

                entity.Property(e => e.TrDate1)
                    .HasColumnType("date")
                    .HasColumnName("tr_date_1");

                entity.Property(e => e.TrDate2)
                    .HasColumnType("date")
                    .HasColumnName("tr_date_2");

                entity.Property(e => e.TrDeowingPostPayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_deowing_post_payment");

                entity.Property(e => e.TrDeowingPrePayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_deowing_pre_payment");

                entity.Property(e => e.TrDepositTo)
                    .HasMaxLength(16)
                    .HasColumnName("tr_deposit_to");

                entity.Property(e => e.TrDepositedDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_deposited_date");

                entity.Property(e => e.TrDepositedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_deposited_time");

                entity.Property(e => e.TrDescription)
                    .HasMaxLength(256)
                    .HasColumnName("tr_description");

                entity.Property(e => e.TrDisbursement)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_disbursement");

                entity.Property(e => e.TrExchangeRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_exchange_rate");

                entity.Property(e => e.TrFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_fee");

                entity.Property(e => e.TrFlags).HasColumnName("tr_flags");

                entity.Property(e => e.TrFlags1).HasColumnName("tr_flags_1");

                entity.Property(e => e.TrFlags2).HasColumnName("tr_flags_2");

                entity.Property(e => e.TrId).HasColumnName("tr_id");

                entity.Property(e => e.TrInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_interest");

                entity.Property(e => e.TrInvoiceNumber).HasColumnName("tr_invoice_number");

                entity.Property(e => e.TrLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_legal");

                entity.Property(e => e.TrMby)
                    .HasMaxLength(16)
                    .HasColumnName("tr_mby");

                entity.Property(e => e.TrMdate)
                    .HasColumnType("date")
                    .HasColumnName("tr_mdate");

                entity.Property(e => e.TrMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_misc");

                entity.Property(e => e.TrMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_mtime");

                entity.Property(e => e.TrNumber1).HasColumnName("tr_number_1");

                entity.Property(e => e.TrNumber2).HasColumnName("tr_number_2");

                entity.Property(e => e.TrOp1)
                    .HasMaxLength(16)
                    .HasColumnName("tr_op_1");

                entity.Property(e => e.TrOp2)
                    .HasMaxLength(16)
                    .HasColumnName("tr_op_2");

                entity.Property(e => e.TrOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_other");

                entity.Property(e => e.TrPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_payment_date");

                entity.Property(e => e.TrPaymentDueDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_payment_due_date");

                entity.Property(e => e.TrPaymentDueTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_payment_due_time");

                entity.Property(e => e.TrPaymentTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_payment_time");

                entity.Property(e => e.TrPaymentTypeFlag).HasColumnName("tr_payment_type_flag");

                entity.Property(e => e.TrPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_percent_1");

                entity.Property(e => e.TrPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_percent_2");

                entity.Property(e => e.TrPostedDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_posted_date");

                entity.Property(e => e.TrPostedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_posted_time");

                entity.Property(e => e.TrPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_principal");

                entity.Property(e => e.TrReceiptNumber).HasColumnName("tr_receipt_number");

                entity.Property(e => e.TrReturn)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_return");

                entity.Property(e => e.TrRowidClient).HasColumnName("tr_rowid_client");

                entity.Property(e => e.TrSales)
                    .HasMaxLength(16)
                    .HasColumnName("tr_sales");

                entity.Property(e => e.TrSwitches).HasColumnName("tr_switches");

                entity.Property(e => e.TrTaxAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_amount");

                entity.Property(e => e.TrTaxFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_fees");

                entity.Property(e => e.TrTaxInt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_int");

                entity.Property(e => e.TrTaxLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_legal");

                entity.Property(e => e.TrTaxMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_misc");

                entity.Property(e => e.TrTaxOptions).HasColumnName("tr_tax_options");

                entity.Property(e => e.TrTaxOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_other");

                entity.Property(e => e.TrTaxPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_principal");

                entity.Property(e => e.TrTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate");

                entity.Property(e => e.TrTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_1");

                entity.Property(e => e.TrTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_2");

                entity.Property(e => e.TrTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_3");

                entity.Property(e => e.TrToAgency)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_agency");

                entity.Property(e => e.TrToClient)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_client");

                entity.Property(e => e.TrToCurrency).HasColumnName("tr_to_currency");

                entity.Property(e => e.TrToCurrent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_current");

                entity.Property(e => e.TrType)
                    .HasMaxLength(20)
                    .HasColumnName("tr_type");

                entity.Property(e => e.TrUid).HasColumnName("tr_uid");

                entity.Property(e => e.TrUidm).HasColumnName("tr_uidm");

                entity.Property(e => e.TrUido).HasColumnName("tr_uido");

                entity.Property(e => e.TrUser1)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_1");

                entity.Property(e => e.TrUser2)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_2");

                entity.Property(e => e.TrUser3)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_3");

                entity.Property(e => e.TrUser4)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_4");

                entity.Property(e => e.TrUser5)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_5");

                entity.Property(e => e.TrUser6)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_6");

                entity.Property(e => e.TrUser7)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_7");

                entity.Property(e => e.TrWho)
                    .HasMaxLength(16)
                    .HasColumnName("tr_who");

                entity.Property(e => e.TrWithdrawFrom)
                    .HasMaxLength(16)
                    .HasColumnName("tr_withdraw_from");

                entity.HasOne(d => d.TrBlobNavigation)
                    .WithMany(p => p.AClTransactions)
                    .HasForeignKey(d => d.TrBlob)
                    .HasConstraintName("FK__a_cl_tran__tr_bl__00200768");

                entity.HasOne(d => d.TrRowidClientNavigation)
                    .WithMany(p => p.AClTransactions)
                    .HasForeignKey(d => d.TrRowidClient)
                    .HasConstraintName("FK__a_cl_tran__tr_ro__7F2BE32F");
            });

            modelBuilder.Entity<AClient>(entity =>
            {
                entity.HasKey(e => e.ClRowid)
                    .HasName("PK__a_client__53B86116200E2CE5");

                entity.ToTable("a_client");

                entity.HasIndex(e => e.ClAltNumber, "cl_alt_number_key");

                entity.HasIndex(e => e.ClCategory1, "cl_category_1_key");

                entity.HasIndex(e => e.ClCategory2, "cl_category_2_key");

                entity.HasIndex(e => e.ClCategory, "cl_category_key");

                entity.HasIndex(e => e.ClName, "cl_name_key");

                entity.HasIndex(e => e.ClNoteblob, "cl_noteblob_key");

                entity.HasIndex(e => e.ClNumber, "cl_number_key");

                entity.HasIndex(e => e.ClOwnedbyNumber, "cl_ownedby_number_key");

                entity.HasIndex(e => e.ClUser1, "cl_user_1_key");

                entity.Property(e => e.ClRowid).HasColumnName("cl_rowid");

                entity.Property(e => e.ClAddFlags).HasColumnName("cl_add_flags");

                entity.Property(e => e.ClAddType).HasColumnName("cl_add_type");

                entity.Property(e => e.ClAddress)
                    .HasMaxLength(160)
                    .HasColumnName("cl_address");

                entity.Property(e => e.ClAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("cl_address_1");

                entity.Property(e => e.ClAddress2)
                    .HasMaxLength(160)
                    .HasColumnName("cl_address_2");

                entity.Property(e => e.ClAdjustments)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_adjustments");

                entity.Property(e => e.ClAltContact)
                    .HasMaxLength(128)
                    .HasColumnName("cl_alt_contact");

                entity.Property(e => e.ClAltNumber)
                    .HasMaxLength(40)
                    .HasColumnName("cl_alt_number");

                entity.Property(e => e.ClAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_amount_1");

                entity.Property(e => e.ClAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_amount_2");

                entity.Property(e => e.ClArchive).HasColumnName("cl_archive");

                entity.Property(e => e.ClAttachNum).HasColumnName("cl_attach_num");

                entity.Property(e => e.ClBillingPeriod).HasColumnName("cl_billing_period");

                entity.Property(e => e.ClCategory).HasColumnName("cl_category");

                entity.Property(e => e.ClCategory1).HasColumnName("cl_category_1");

                entity.Property(e => e.ClCategory2).HasColumnName("cl_category_2");

                entity.Property(e => e.ClCby)
                    .HasMaxLength(16)
                    .HasColumnName("cl_cby");

                entity.Property(e => e.ClCdate)
                    .HasColumnType("date")
                    .HasColumnName("cl_cdate");

                entity.Property(e => e.ClCell)
                    .HasMaxLength(48)
                    .HasColumnName("cl_cell");

                entity.Property(e => e.ClCellExtension)
                    .HasMaxLength(16)
                    .HasColumnName("cl_cell_extension");

                entity.Property(e => e.ClCity)
                    .HasMaxLength(64)
                    .HasColumnName("cl_city");

                entity.Property(e => e.ClClass).HasColumnName("cl_class");

                entity.Property(e => e.ClClosed)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_closed");

                entity.Property(e => e.ClCommRateOptions).HasColumnName("cl_comm_rate_options");

                entity.Property(e => e.ClCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_commission_rate");

                entity.Property(e => e.ClCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_commission_rate_1");

                entity.Property(e => e.ClCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_commission_rate_2");

                entity.Property(e => e.ClCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_commission_rate_3");

                entity.Property(e => e.ClCompClDebtorThresh).HasColumnName("cl_comp_cl_debtor_thresh");

                entity.Property(e => e.ClCompClNumber).HasColumnName("cl_comp_cl_number");

                entity.Property(e => e.ClCompFlags).HasColumnName("cl_comp_flags");

                entity.Property(e => e.ClCompFlags2).HasColumnName("cl_comp_flags2");

                entity.Property(e => e.ClCompGst)
                    .HasMaxLength(124)
                    .HasColumnName("cl_comp_gst");

                entity.Property(e => e.ClContact)
                    .HasMaxLength(128)
                    .HasColumnName("cl_contact");

                entity.Property(e => e.ClContactPlan)
                    .HasMaxLength(16)
                    .HasColumnName("cl_contact_plan");

                entity.Property(e => e.ClCountry)
                    .HasMaxLength(64)
                    .HasColumnName("cl_country");

                entity.Property(e => e.ClCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cl_ctime");

                entity.Property(e => e.ClCurrency).HasColumnName("cl_currency");

                entity.Property(e => e.ClDate1)
                    .HasColumnType("date")
                    .HasColumnName("cl_date_1");

                entity.Property(e => e.ClDate2)
                    .HasColumnType("date")
                    .HasColumnName("cl_date_2");

                entity.Property(e => e.ClDoBusinessAs)
                    .HasMaxLength(128)
                    .HasColumnName("cl_do_business_as");

                entity.Property(e => e.ClEmail)
                    .HasMaxLength(160)
                    .HasColumnName("cl_email");

                entity.Property(e => e.ClEmailNum).HasColumnName("cl_email_num");

                entity.Property(e => e.ClFax)
                    .HasMaxLength(48)
                    .HasColumnName("cl_fax");

                entity.Property(e => e.ClFaxExtension)
                    .HasMaxLength(16)
                    .HasColumnName("cl_fax_extension");

                entity.Property(e => e.ClFeeDisbursement).HasColumnName("cl_fee_disbursement");

                entity.Property(e => e.ClFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_fees");

                entity.Property(e => e.ClFixFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_fix_fee");

                entity.Property(e => e.ClFlags).HasColumnName("cl_flags");

                entity.Property(e => e.ClFlags1).HasColumnName("cl_flags_1");

                entity.Property(e => e.ClFlags2).HasColumnName("cl_flags_2");

                entity.Property(e => e.ClInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_interest");

                entity.Property(e => e.ClInterestFlags1).HasColumnName("cl_interest_flags1");

                entity.Property(e => e.ClInterestFlags2).HasColumnName("cl_interest_flags2");

                entity.Property(e => e.ClInterestFlags3).HasColumnName("cl_interest_flags3");

                entity.Property(e => e.ClInterestRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_interest_rate");

                entity.Property(e => e.ClInvoiceCode).HasColumnName("cl_invoice_code");

                entity.Property(e => e.ClJudgement)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_judgement");

                entity.Property(e => e.ClLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_legal");

                entity.Property(e => e.ClLetterNum).HasColumnName("cl_letter_num");

                entity.Property(e => e.ClListed)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_listed");

                entity.Property(e => e.ClListedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_listed_date");

                entity.Property(e => e.ClMby)
                    .HasMaxLength(16)
                    .HasColumnName("cl_mby");

                entity.Property(e => e.ClMdate)
                    .HasColumnType("date")
                    .HasColumnName("cl_mdate");

                entity.Property(e => e.ClMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_misc");

                entity.Property(e => e.ClMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cl_mtime");

                entity.Property(e => e.ClName)
                    .HasMaxLength(128)
                    .HasColumnName("cl_name");

                entity.Property(e => e.ClNoteblob).HasColumnName("cl_noteblob");

                entity.Property(e => e.ClNumOfActiveAccounts).HasColumnName("cl_num_of_active_accounts");

                entity.Property(e => e.ClNumOfClosedAccounts).HasColumnName("cl_num_of_closed_accounts");

                entity.Property(e => e.ClNumOfOtherAccounts).HasColumnName("cl_num_of_other_accounts");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.ClNumber1).HasColumnName("cl_number_1");

                entity.Property(e => e.ClNumber2).HasColumnName("cl_number_2");

                entity.Property(e => e.ClNumberOfAccounts).HasColumnName("cl_number_of_accounts");

                entity.Property(e => e.ClOp1)
                    .HasMaxLength(16)
                    .HasColumnName("cl_op_1");

                entity.Property(e => e.ClOp2)
                    .HasMaxLength(16)
                    .HasColumnName("cl_op_2");

                entity.Property(e => e.ClOperator)
                    .HasMaxLength(16)
                    .HasColumnName("cl_operator");

                entity.Property(e => e.ClOther)
                    .HasMaxLength(48)
                    .HasColumnName("cl_other");

                entity.Property(e => e.ClOtherExtension)
                    .HasMaxLength(16)
                    .HasColumnName("cl_other_extension");

                entity.Property(e => e.ClOtherFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_other_fee");

                entity.Property(e => e.ClOwing)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_owing");

                entity.Property(e => e.ClOwnedbyNumber).HasColumnName("cl_ownedby_number");

                entity.Property(e => e.ClPaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_paid");

                entity.Property(e => e.ClPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_percent_1");

                entity.Property(e => e.ClPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_percent_2");

                entity.Property(e => e.ClPhone)
                    .HasMaxLength(48)
                    .HasColumnName("cl_phone");

                entity.Property(e => e.ClPhoneExtension)
                    .HasMaxLength(16)
                    .HasColumnName("cl_phone_extension");

                entity.Property(e => e.ClPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_principal");

                entity.Property(e => e.ClRatePlan)
                    .HasMaxLength(16)
                    .HasColumnName("cl_rate_plan");

                entity.Property(e => e.ClReportAcknowledgement)
                    .HasMaxLength(160)
                    .HasColumnName("cl_report_acknowledgement");

                entity.Property(e => e.ClReportExtra)
                    .HasMaxLength(160)
                    .HasColumnName("cl_report_extra");

                entity.Property(e => e.ClReportListings)
                    .HasMaxLength(160)
                    .HasColumnName("cl_report_listings");

                entity.Property(e => e.ClReportStatements)
                    .HasMaxLength(160)
                    .HasColumnName("cl_report_statements");

                entity.Property(e => e.ClSales)
                    .HasMaxLength(16)
                    .HasColumnName("cl_sales");

                entity.Property(e => e.ClState)
                    .HasMaxLength(64)
                    .HasColumnName("cl_state");

                entity.Property(e => e.ClStatementCurrency).HasColumnName("cl_statement_currency");

                entity.Property(e => e.ClStreetNo)
                    .HasMaxLength(48)
                    .HasColumnName("cl_street_no");

                entity.Property(e => e.ClSuccessCalc).HasColumnName("cl_success_calc");

                entity.Property(e => e.ClSuccessEquation)
                    .HasMaxLength(256)
                    .HasColumnName("cl_success_equation");

                entity.Property(e => e.ClSuccessRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_success_rate");

                entity.Property(e => e.ClTaxDisbursement).HasColumnName("cl_tax_disbursement");

                entity.Property(e => e.ClTaxExempt).HasColumnName("cl_tax_exempt");

                entity.Property(e => e.ClTaxOptions).HasColumnName("cl_tax_options");

                entity.Property(e => e.ClTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_tax_rate");

                entity.Property(e => e.ClTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_tax_rate_1");

                entity.Property(e => e.ClTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_tax_rate_2");

                entity.Property(e => e.ClTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_tax_rate_3");

                entity.Property(e => e.ClTimezone).HasColumnName("cl_timezone");

                entity.Property(e => e.ClType).HasColumnName("cl_type");

                entity.Property(e => e.ClUid).HasColumnName("cl_uid");

                entity.Property(e => e.ClUidm).HasColumnName("cl_uidm");

                entity.Property(e => e.ClUser1)
                    .HasMaxLength(128)
                    .HasColumnName("cl_user_1");

                entity.Property(e => e.ClUser2)
                    .HasMaxLength(128)
                    .HasColumnName("cl_user_2");

                entity.Property(e => e.ClUser3)
                    .HasMaxLength(128)
                    .HasColumnName("cl_user_3");

                entity.Property(e => e.ClUser4)
                    .HasMaxLength(128)
                    .HasColumnName("cl_user_4");

                entity.Property(e => e.ClWorkedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_worked_date");

                entity.Property(e => e.ClZip)
                    .HasMaxLength(48)
                    .HasColumnName("cl_zip");

                entity.Property(e => e.CpPrecollectDelay).HasColumnName("cp_precollect_delay");

                entity.HasOne(d => d.ClNoteblobNavigation)
                    .WithMany(p => p.AClients)
                    .HasForeignKey(d => d.ClNoteblob)
                    .HasConstraintName("FK__a_client__cl_not__15502E78");
            });

            modelBuilder.Entity<AContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__a_contac__91C3A18CE1A451CB");

                entity.ToTable("a_contact");

                entity.HasIndex(e => e.CoAttachmentBlob, "co_attachment_blob_key");

                entity.HasIndex(e => e.CoCategory1, "co_category_1_key");

                entity.HasIndex(e => e.CoCategory, "co_category_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoType, e.CoDate }, "co_completedtypedate_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoWho, e.CoDate }, "co_completedwhodate_key");

                entity.HasIndex(e => e.CoDate, "co_date_key");

                entity.HasIndex(e => e.CoDoneDate, "co_done_date_key");

                entity.HasIndex(e => new { e.CoOriginator, e.CoCreationDate }, "co_originatordate_key");

                entity.HasIndex(e => e.CoRowidDebtor, "co_rowid_debtor_key");

                entity.HasIndex(e => new { e.CoType, e.CoCompleted, e.CoWho, e.CoDate }, "co_typecompletedwhodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoDoneDate }, "co_whodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoType, e.CoDate }, "co_whotypedate_key");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidDebtor).HasColumnName("co_rowid_debtor");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.AContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__a_contact__co_at__07C12930");

                entity.HasOne(d => d.CoRowidDebtorNavigation)
                    .WithMany(p => p.AContacts)
                    .HasForeignKey(d => d.CoRowidDebtor)
                    .HasConstraintName("FK__a_contact__co_ro__06CD04F7");
            });

            modelBuilder.Entity<ACosigner>(entity =>
            {
                entity.HasKey(e => e.DeCosRowid)
                    .HasName("PK__a_cosign__6B4F30D455B69D27");

                entity.ToTable("a_cosigner");

                entity.HasIndex(e => e.DeCosBusinessPhone, "de_cos_business_phone_key");

                entity.HasIndex(e => e.DeCosCategory1, "de_cos_category_1_key");

                entity.HasIndex(e => e.DeCosCategory2, "de_cos_category_2_key");

                entity.HasIndex(e => e.DeCosCategory, "de_cos_category_key");

                entity.HasIndex(e => e.DeCosCellPhone, "de_cos_cell_phone_key");

                entity.HasIndex(e => e.DeCosCity, "de_cos_city_key");

                entity.HasIndex(e => e.DeCosDl, "de_cos_dl_key");

                entity.HasIndex(e => e.DeCosDob, "de_cos_dob_key");

                entity.HasIndex(e => e.DeCosEmail, "de_cos_email_key");

                entity.HasIndex(e => e.DeCosName, "de_cos_name_key");

                entity.HasIndex(e => e.DeCosOtherPhone, "de_cos_other_phone_key");

                entity.HasIndex(e => e.DeCosPhone, "de_cos_phone_key");

                entity.HasIndex(e => e.DeCosRowidDebtor, "de_cos_rowid_debtor_key");

                entity.HasIndex(e => e.DeCosSin, "de_cos_sin_key");

                entity.HasIndex(e => e.DeCosState, "de_cos_state_key");

                entity.HasIndex(e => e.DeCosZip, "de_cos_zip_key");

                entity.HasIndex(e => e.DeCosigner, "de_cosigner_key");

                entity.Property(e => e.DeCosRowid).HasColumnName("de_cos_rowid");

                entity.Property(e => e.DeCosAddress)
                    .HasMaxLength(164)
                    .HasColumnName("de_cos_address");

                entity.Property(e => e.DeCosAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("de_cos_address_1");

                entity.Property(e => e.DeCosAddress2)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_address_2");

                entity.Property(e => e.DeCosAddressFlags).HasColumnName("de_cos_address_flags");

                entity.Property(e => e.DeCosAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_amount");

                entity.Property(e => e.DeCosAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_amount_1");

                entity.Property(e => e.DeCosAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_amount_2");

                entity.Property(e => e.DeCosAttachNum).HasColumnName("de_cos_attach_num");

                entity.Property(e => e.DeCosBusinessExt)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_business_ext");

                entity.Property(e => e.DeCosBusinessPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_business_phone");

                entity.Property(e => e.DeCosCategory).HasColumnName("de_cos_category");

                entity.Property(e => e.DeCosCategory1).HasColumnName("de_cos_category_1");

                entity.Property(e => e.DeCosCategory2).HasColumnName("de_cos_category_2");

                entity.Property(e => e.DeCosCbrAssociation)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_cbr_association");

                entity.Property(e => e.DeCosCby)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_cby");

                entity.Property(e => e.DeCosCdate)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_cdate");

                entity.Property(e => e.DeCosCellExt)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_cell_ext");

                entity.Property(e => e.DeCosCellPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_cell_phone");

                entity.Property(e => e.DeCosCinfoInd)
                    .HasMaxLength(8)
                    .HasColumnName("de_cos_cinfo_ind");

                entity.Property(e => e.DeCosCity)
                    .HasMaxLength(64)
                    .HasColumnName("de_cos_city");

                entity.Property(e => e.DeCosClass).HasColumnName("de_cos_class");

                entity.Property(e => e.DeCosCountry)
                    .HasMaxLength(64)
                    .HasColumnName("de_cos_country");

                entity.Property(e => e.DeCosCreated).HasColumnName("de_cos_created");

                entity.Property(e => e.DeCosCreatedBy)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_created_by");

                entity.Property(e => e.DeCosCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_cos_ctime");

                entity.Property(e => e.DeCosDate1)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_date_1");

                entity.Property(e => e.DeCosDate2)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_date_2");

                entity.Property(e => e.DeCosDl)
                    .HasMaxLength(160)
                    .HasColumnName("de_cos_dl");

                entity.Property(e => e.DeCosDob)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_dob");

                entity.Property(e => e.DeCosEcoa)
                    .HasMaxLength(8)
                    .HasColumnName("de_cos_ecoa");

                entity.Property(e => e.DeCosEmail)
                    .HasMaxLength(256)
                    .HasColumnName("de_cos_email");

                entity.Property(e => e.DeCosEmailNum).HasColumnName("de_cos_email_num");

                entity.Property(e => e.DeCosEntity).HasColumnName("de_cos_entity");

                entity.Property(e => e.DeCosFlags1).HasColumnName("de_cos_flags_1");

                entity.Property(e => e.DeCosFlags2).HasColumnName("de_cos_flags_2");

                entity.Property(e => e.DeCosGroupFlags).HasColumnName("de_cos_group_flags");

                entity.Property(e => e.DeCosGroupId).HasColumnName("de_cos_group_id");

                entity.Property(e => e.DeCosGroupMember).HasColumnName("de_cos_group_member");

                entity.Property(e => e.DeCosLetterNum).HasColumnName("de_cos_letter_num");

                entity.Property(e => e.DeCosMby)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_mby");

                entity.Property(e => e.DeCosMdate)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_mdate");

                entity.Property(e => e.DeCosModified).HasColumnName("de_cos_modified");

                entity.Property(e => e.DeCosModifiedBy)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_modified_by");

                entity.Property(e => e.DeCosMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_cos_mtime");

                entity.Property(e => e.DeCosName)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_name");

                entity.Property(e => e.DeCosNote1)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_note_1");

                entity.Property(e => e.DeCosNote2)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_note_2");

                entity.Property(e => e.DeCosNote3)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_note_3");

                entity.Property(e => e.DeCosNote4)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_note_4");

                entity.Property(e => e.DeCosNumber1).HasColumnName("de_cos_number_1");

                entity.Property(e => e.DeCosNumber2).HasColumnName("de_cos_number_2");

                entity.Property(e => e.DeCosOp1)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_op_1");

                entity.Property(e => e.DeCosOp2)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_op_2");

                entity.Property(e => e.DeCosOtherExt)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_other_ext");

                entity.Property(e => e.DeCosOtherPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_other_phone");

                entity.Property(e => e.DeCosPercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_percent");

                entity.Property(e => e.DeCosPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_percent_1");

                entity.Property(e => e.DeCosPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_percent_2");

                entity.Property(e => e.DeCosPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_phone");

                entity.Property(e => e.DeCosPhoneExt)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_phone_ext");

                entity.Property(e => e.DeCosRowidDebtor).HasColumnName("de_cos_rowid_debtor");

                entity.Property(e => e.DeCosSin)
                    .HasMaxLength(160)
                    .HasColumnName("de_cos_sin");

                entity.Property(e => e.DeCosState)
                    .HasMaxLength(64)
                    .HasColumnName("de_cos_state");

                entity.Property(e => e.DeCosStreetNumber)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_street_number");

                entity.Property(e => e.DeCosTimezone).HasColumnName("de_cos_timezone");

                entity.Property(e => e.DeCosTitle)
                    .HasMaxLength(64)
                    .HasColumnName("de_cos_title");

                entity.Property(e => e.DeCosType).HasColumnName("de_cos_type");

                entity.Property(e => e.DeCosUid).HasColumnName("de_cos_uid");

                entity.Property(e => e.DeCosUidm).HasColumnName("de_cos_uidm");

                entity.Property(e => e.DeCosUido).HasColumnName("de_cos_uido");

                entity.Property(e => e.DeCosZip)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_zip");

                entity.Property(e => e.DeCosigner)
                    .HasMaxLength(128)
                    .HasColumnName("de_cosigner");

                entity.HasOne(d => d.DeCosRowidDebtorNavigation)
                    .WithMany(p => p.ACosigners)
                    .HasForeignKey(d => d.DeCosRowidDebtor)
                    .HasConstraintName("FK__a_cosigne__de_co__22AA2996");
            });

            modelBuilder.Entity<ADcosContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__a_dcos_c__91C3A18C74B8A818");

                entity.ToTable("a_dcos_contact");

                entity.HasIndex(e => e.CoAttachmentBlob, "co_attachment_blob_key");

                entity.HasIndex(e => e.CoCategory1, "co_category_1_key");

                entity.HasIndex(e => e.CoCategory, "co_category_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoType, e.CoDate }, "co_completedtypedate_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoWho, e.CoDate }, "co_completedwhodate_key");

                entity.HasIndex(e => e.CoDate, "co_date_key");

                entity.HasIndex(e => e.CoDoneDate, "co_done_date_key");

                entity.HasIndex(e => new { e.CoOriginator, e.CoCreationDate }, "co_originatordate_key");

                entity.HasIndex(e => e.CoRowidCosigner, "co_rowid_cosigner_key");

                entity.HasIndex(e => new { e.CoType, e.CoCompleted, e.CoWho, e.CoDate }, "co_typecompletedwhodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoDoneDate }, "co_whodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoType, e.CoDate }, "co_whotypedate_key");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidCosigner).HasColumnName("co_rowid_cosigner");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.ADcosContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__a_dcos_co__co_at__17F790F9");

                entity.HasOne(d => d.CoRowidCosignerNavigation)
                    .WithMany(p => p.ADcosContacts)
                    .HasForeignKey(d => d.CoRowidCosigner)
                    .HasConstraintName("FK__a_dcos_co__co_ro__17036CC0");
            });

            modelBuilder.Entity<ADeTransaction>(entity =>
            {
                entity.HasKey(e => e.TrRowid)
                    .HasName("PK__a_de_tra__C5AB8E92A7723D64");

                entity.ToTable("a_de_transaction");

                entity.HasIndex(e => e.TrBlob, "tr_blob_key");

                entity.HasIndex(e => e.TrCategory1, "tr_category_1_key");

                entity.HasIndex(e => e.TrCategory2, "tr_category_2_key");

                entity.HasIndex(e => e.TrCategory, "tr_category_key");

                entity.HasIndex(e => e.TrInvoiceNumber, "tr_invoice_number_key");

                entity.HasIndex(e => e.TrPaymentDate, "tr_payment_date_key");

                entity.HasIndex(e => e.TrPostedDate, "tr_posted_date_key");

                entity.HasIndex(e => e.TrReceiptNumber, "tr_receipt_number_key");

                entity.HasIndex(e => e.TrRowidDebtor, "tr_rowid_debtor_key");

                entity.Property(e => e.TrRowid).HasColumnName("tr_rowid");

                entity.Property(e => e.TrAccount).HasColumnName("tr_account");

                entity.Property(e => e.TrActual)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_actual");

                entity.Property(e => e.TrAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_adjustment");

                entity.Property(e => e.TrAgencyAcctCurrency).HasColumnName("tr_agency_acct_currency");

                entity.Property(e => e.TrAgencyExchangeAmt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_agency_exchange_amt");

                entity.Property(e => e.TrAgencyExchangeRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_agency_exchange_rate");

                entity.Property(e => e.TrAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("tr_attachment");

                entity.Property(e => e.TrBlob).HasColumnName("tr_blob");

                entity.Property(e => e.TrBucket10)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_10");

                entity.Property(e => e.TrBucket11)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_11");

                entity.Property(e => e.TrBucket12)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_12");

                entity.Property(e => e.TrBucket13)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_13");

                entity.Property(e => e.TrBucket14)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_14");

                entity.Property(e => e.TrBucket15)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_15");

                entity.Property(e => e.TrBucket16)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_16");

                entity.Property(e => e.TrBucket5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_5");

                entity.Property(e => e.TrBucket6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_6");

                entity.Property(e => e.TrBucket7)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_7");

                entity.Property(e => e.TrBucket8)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_8");

                entity.Property(e => e.TrBucket9)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_9");

                entity.Property(e => e.TrCategory).HasColumnName("tr_category");

                entity.Property(e => e.TrCategory1).HasColumnName("tr_category_1");

                entity.Property(e => e.TrCategory2).HasColumnName("tr_category_2");

                entity.Property(e => e.TrCby)
                    .HasMaxLength(16)
                    .HasColumnName("tr_cby");

                entity.Property(e => e.TrCdate)
                    .HasColumnType("date")
                    .HasColumnName("tr_cdate");

                entity.Property(e => e.TrCommFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_fees");

                entity.Property(e => e.TrCommInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_interest");

                entity.Property(e => e.TrCommLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_legal");

                entity.Property(e => e.TrCommMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_misc");

                entity.Property(e => e.TrCommOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_other");

                entity.Property(e => e.TrCommPrinc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_princ");

                entity.Property(e => e.TrCommRateOption).HasColumnName("tr_comm_rate_option");

                entity.Property(e => e.TrCommissionAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_amount");

                entity.Property(e => e.TrCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate");

                entity.Property(e => e.TrCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_1");

                entity.Property(e => e.TrCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_2");

                entity.Property(e => e.TrCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_3");

                entity.Property(e => e.TrConfirmationDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_confirmation_date");

                entity.Property(e => e.TrConfirmationNumber)
                    .HasMaxLength(128)
                    .HasColumnName("tr_confirmation_number");

                entity.Property(e => e.TrConfirmationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_confirmation_time");

                entity.Property(e => e.TrCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_ctime");

                entity.Property(e => e.TrCurrency).HasColumnName("tr_currency");

                entity.Property(e => e.TrDate1)
                    .HasColumnType("date")
                    .HasColumnName("tr_date_1");

                entity.Property(e => e.TrDate2)
                    .HasColumnType("date")
                    .HasColumnName("tr_date_2");

                entity.Property(e => e.TrDeowingPostPayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_deowing_post_payment");

                entity.Property(e => e.TrDeowingPrePayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_deowing_pre_payment");

                entity.Property(e => e.TrDepositTo)
                    .HasMaxLength(16)
                    .HasColumnName("tr_deposit_to");

                entity.Property(e => e.TrDepositedDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_deposited_date");

                entity.Property(e => e.TrDepositedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_deposited_time");

                entity.Property(e => e.TrDescription)
                    .HasMaxLength(256)
                    .HasColumnName("tr_description");

                entity.Property(e => e.TrDisbursement)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_disbursement");

                entity.Property(e => e.TrExchangeRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_exchange_rate");

                entity.Property(e => e.TrFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_fee");

                entity.Property(e => e.TrFlags).HasColumnName("tr_flags");

                entity.Property(e => e.TrFlags1).HasColumnName("tr_flags_1");

                entity.Property(e => e.TrFlags2).HasColumnName("tr_flags_2");

                entity.Property(e => e.TrId).HasColumnName("tr_id");

                entity.Property(e => e.TrInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_interest");

                entity.Property(e => e.TrInvoiceNumber).HasColumnName("tr_invoice_number");

                entity.Property(e => e.TrLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_legal");

                entity.Property(e => e.TrMby)
                    .HasMaxLength(16)
                    .HasColumnName("tr_mby");

                entity.Property(e => e.TrMdate)
                    .HasColumnType("date")
                    .HasColumnName("tr_mdate");

                entity.Property(e => e.TrMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_misc");

                entity.Property(e => e.TrMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_mtime");

                entity.Property(e => e.TrNumber1).HasColumnName("tr_number_1");

                entity.Property(e => e.TrNumber2).HasColumnName("tr_number_2");

                entity.Property(e => e.TrOp1)
                    .HasMaxLength(16)
                    .HasColumnName("tr_op_1");

                entity.Property(e => e.TrOp2)
                    .HasMaxLength(16)
                    .HasColumnName("tr_op_2");

                entity.Property(e => e.TrOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_other");

                entity.Property(e => e.TrPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_payment_date");

                entity.Property(e => e.TrPaymentDueDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_payment_due_date");

                entity.Property(e => e.TrPaymentDueTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_payment_due_time");

                entity.Property(e => e.TrPaymentTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_payment_time");

                entity.Property(e => e.TrPaymentTypeFlag).HasColumnName("tr_payment_type_flag");

                entity.Property(e => e.TrPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_percent_1");

                entity.Property(e => e.TrPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_percent_2");

                entity.Property(e => e.TrPostedDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_posted_date");

                entity.Property(e => e.TrPostedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_posted_time");

                entity.Property(e => e.TrPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_principal");

                entity.Property(e => e.TrReceiptNumber).HasColumnName("tr_receipt_number");

                entity.Property(e => e.TrReturn)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_return");

                entity.Property(e => e.TrRowidDebtor).HasColumnName("tr_rowid_debtor");

                entity.Property(e => e.TrSales)
                    .HasMaxLength(16)
                    .HasColumnName("tr_sales");

                entity.Property(e => e.TrSwitches).HasColumnName("tr_switches");

                entity.Property(e => e.TrTaxAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_amount");

                entity.Property(e => e.TrTaxFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_fees");

                entity.Property(e => e.TrTaxInt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_int");

                entity.Property(e => e.TrTaxLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_legal");

                entity.Property(e => e.TrTaxMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_misc");

                entity.Property(e => e.TrTaxOptions).HasColumnName("tr_tax_options");

                entity.Property(e => e.TrTaxOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_other");

                entity.Property(e => e.TrTaxPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_principal");

                entity.Property(e => e.TrTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate");

                entity.Property(e => e.TrTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_1");

                entity.Property(e => e.TrTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_2");

                entity.Property(e => e.TrTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_3");

                entity.Property(e => e.TrToAgency)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_agency");

                entity.Property(e => e.TrToClient)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_client");

                entity.Property(e => e.TrToCurrency).HasColumnName("tr_to_currency");

                entity.Property(e => e.TrToCurrent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_current");

                entity.Property(e => e.TrType)
                    .HasMaxLength(20)
                    .HasColumnName("tr_type");

                entity.Property(e => e.TrUid).HasColumnName("tr_uid");

                entity.Property(e => e.TrUidm).HasColumnName("tr_uidm");

                entity.Property(e => e.TrUido).HasColumnName("tr_uido");

                entity.Property(e => e.TrUser1)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_1");

                entity.Property(e => e.TrUser2)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_2");

                entity.Property(e => e.TrUser3)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_3");

                entity.Property(e => e.TrUser4)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_4");

                entity.Property(e => e.TrUser5)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_5");

                entity.Property(e => e.TrUser6)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_6");

                entity.Property(e => e.TrUser7)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_7");

                entity.Property(e => e.TrWho)
                    .HasMaxLength(16)
                    .HasColumnName("tr_who");

                entity.Property(e => e.TrWithdrawFrom)
                    .HasMaxLength(16)
                    .HasColumnName("tr_withdraw_from");

                entity.HasOne(d => d.TrBlobNavigation)
                    .WithMany(p => p.ADeTransactions)
                    .HasForeignKey(d => d.TrBlob)
                    .HasConstraintName("FK__a_de_tran__tr_bl__1F98B2C1");

                entity.HasOne(d => d.TrRowidDebtorNavigation)
                    .WithMany(p => p.ADeTransactions)
                    .HasForeignKey(d => d.TrRowidDebtor)
                    .HasConstraintName("FK__a_de_tran__tr_ro__1EA48E88");
            });

            modelBuilder.Entity<ADebtor>(entity =>
            {
                entity.HasKey(e => e.DeRowid)
                    .HasName("PK__a_debtor__D042D9C7A39F3D2E");

                entity.ToTable("a_debtor");

                entity.HasIndex(e => new { e.DeActive, e.DeName }, "de_activename_key");

                entity.HasIndex(e => e.DeCategory1, "de_category_1_key");

                entity.HasIndex(e => e.DeCategory2, "de_category_2_key");

                entity.HasIndex(e => e.DeCategory, "de_category_key");

                entity.HasIndex(e => e.DeCellPhone, "de_cell_phone_key");

                entity.HasIndex(e => e.DeCity, "de_city_key");

                entity.HasIndex(e => e.DeClAccount, "de_cl_account_key");

                entity.HasIndex(e => e.DeClerk, "de_clerk_key");

                entity.HasIndex(e => e.DeCloseDate, "de_close_date_key");

                entity.HasIndex(e => e.DeCollector, "de_collector_key");

                entity.HasIndex(e => e.DeContact, "de_contact_key");

                entity.HasIndex(e => e.DeCountry, "de_country_key");

                entity.HasIndex(e => e.DeDl, "de_dl_key");

                entity.HasIndex(e => e.DeDob, "de_dob_key");

                entity.HasIndex(e => e.DeEmail, "de_email_key");

                entity.HasIndex(e => new { e.DeGroupId, e.DeGroupMember, e.DeGroupFlags }, "de_group_idmemberflags_key");

                entity.HasIndex(e => e.DeHomePhone, "de_home_phone_key");

                entity.HasIndex(e => e.DeListedDate, "de_listed_date_key");

                entity.HasIndex(e => e.DeName, "de_name_key");

                entity.HasIndex(e => e.DeNoteblob, "de_noteblob_key");

                entity.HasIndex(e => e.DeNumber, "de_number_key");

                entity.HasIndex(e => e.DeOtherPhone, "de_other_phone_key");

                entity.HasIndex(e => e.DeOwnedByDebtor, "de_owned_by_debtor_key");

                entity.HasIndex(e => e.DeRowidClient, "de_rowid_client_key");

                entity.HasIndex(e => e.DeSalesman, "de_salesman_key");

                entity.HasIndex(e => e.DeSin, "de_sin_key");

                entity.HasIndex(e => e.DeState, "de_state_key");

                entity.HasIndex(e => e.DeStatus, "de_status_key");

                entity.HasIndex(e => e.DeSummaryFlags, "de_summary_flags_key");

                entity.HasIndex(e => e.DeType, "de_type_key");

                entity.HasIndex(e => e.DeWorkPhone, "de_work_phone_key");

                entity.HasIndex(e => e.DeZip, "de_zip_key");

                entity.Property(e => e.DeRowid).HasColumnName("de_rowid");

                entity.Property(e => e.De30Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_30_days");

                entity.Property(e => e.De60Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_60_days");

                entity.Property(e => e.De90Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_90_days");

                entity.Property(e => e.DeAccountNumber)
                    .HasMaxLength(160)
                    .HasColumnName("de_account_number");

                entity.Property(e => e.DeAccruedInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_accrued_interest");

                entity.Property(e => e.DeActive)
                    .HasMaxLength(12)
                    .HasColumnName("de_active");

                entity.Property(e => e.DeActualPaymentAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_actual_payment_amount");

                entity.Property(e => e.DeAddFlags).HasColumnName("de_add_flags");

                entity.Property(e => e.DeAddress)
                    .HasMaxLength(160)
                    .HasColumnName("de_address");

                entity.Property(e => e.DeAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("de_address_1");

                entity.Property(e => e.DeAddress2)
                    .HasMaxLength(160)
                    .HasColumnName("de_address_2");

                entity.Property(e => e.DeAddressSource).HasColumnName("de_address_source");

                entity.Property(e => e.DeAdjustPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_adjust_paid_to_date");

                entity.Property(e => e.DeAdjustments)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_adjustments");

                entity.Property(e => e.DeAltNumber)
                    .HasMaxLength(40)
                    .HasColumnName("de_alt_number");

                entity.Property(e => e.DeAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_amount_1");

                entity.Property(e => e.DeAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_amount_2");

                entity.Property(e => e.DeAmountPastDue)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_amount_past_due");

                entity.Property(e => e.DeArchive).HasColumnName("de_archive");

                entity.Property(e => e.DeArchiveDate)
                    .HasColumnType("date")
                    .HasColumnName("de_archive_date");

                entity.Property(e => e.DeAttachNum).HasColumnName("de_attach_num");

                entity.Property(e => e.DeBank)
                    .HasMaxLength(128)
                    .HasColumnName("de_bank");

                entity.Property(e => e.DeBranch)
                    .HasMaxLength(160)
                    .HasColumnName("de_branch");

                entity.Property(e => e.DeBusiness)
                    .HasMaxLength(128)
                    .HasColumnName("de_business");

                entity.Property(e => e.DeBusinessAddress)
                    .HasMaxLength(128)
                    .HasColumnName("de_business_address");

                entity.Property(e => e.DeCategory).HasColumnName("de_category");

                entity.Property(e => e.DeCategory1).HasColumnName("de_category_1");

                entity.Property(e => e.DeCategory2).HasColumnName("de_category_2");

                entity.Property(e => e.DeCby)
                    .HasMaxLength(16)
                    .HasColumnName("de_cby");

                entity.Property(e => e.DeCdate)
                    .HasColumnType("date")
                    .HasColumnName("de_cdate");

                entity.Property(e => e.DeCellExtension)
                    .HasMaxLength(16)
                    .HasColumnName("de_cell_extension");

                entity.Property(e => e.DeCellPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cell_phone");

                entity.Property(e => e.DeChargeDate)
                    .HasColumnType("date")
                    .HasColumnName("de_charge_date");

                entity.Property(e => e.DeCity)
                    .HasMaxLength(64)
                    .HasColumnName("de_city");

                entity.Property(e => e.DeClAccount)
                    .HasMaxLength(160)
                    .HasColumnName("de_cl_account");

                entity.Property(e => e.DeClSettlementAmt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cl_settlement_amt");

                entity.Property(e => e.DeClass)
                    .HasMaxLength(16)
                    .HasColumnName("de_class");

                entity.Property(e => e.DeClerk)
                    .HasMaxLength(16)
                    .HasColumnName("de_clerk");

                entity.Property(e => e.DeCloseDate)
                    .HasColumnType("date")
                    .HasColumnName("de_close_date");

                entity.Property(e => e.DeCollector)
                    .HasMaxLength(16)
                    .HasColumnName("de_collector");

                entity.Property(e => e.DeCommFeesToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_fees_to_date");

                entity.Property(e => e.DeCommInterestToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_interest_to_date");

                entity.Property(e => e.DeCommLegalToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_legal_to_date");

                entity.Property(e => e.DeCommMiscToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_misc_to_date");

                entity.Property(e => e.DeCommOtherToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_other_to_date");

                entity.Property(e => e.DeCommPrincToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_princ_to_date");

                entity.Property(e => e.DeCommRateOption).HasColumnName("de_comm_rate_option");

                entity.Property(e => e.DeCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_rate");

                entity.Property(e => e.DeCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_rate_1");

                entity.Property(e => e.DeCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_rate_2");

                entity.Property(e => e.DeCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_rate_3");

                entity.Property(e => e.DeCommissionToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_to_date");

                entity.Property(e => e.DeCompanyName)
                    .HasMaxLength(128)
                    .HasColumnName("de_company_name");

                entity.Property(e => e.DeContact)
                    .HasMaxLength(128)
                    .HasColumnName("de_contact");

                entity.Property(e => e.DeCountry)
                    .HasMaxLength(64)
                    .HasColumnName("de_country");

                entity.Property(e => e.DeCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_ctime");

                entity.Property(e => e.DeCurrency).HasColumnName("de_currency");

                entity.Property(e => e.DeDate1)
                    .HasColumnType("date")
                    .HasColumnName("de_date1");

                entity.Property(e => e.DeDate11)
                    .HasColumnType("date")
                    .HasColumnName("de_date_1");

                entity.Property(e => e.DeDate2)
                    .HasColumnType("date")
                    .HasColumnName("de_date2");

                entity.Property(e => e.DeDate21)
                    .HasColumnType("date")
                    .HasColumnName("de_date_2");

                entity.Property(e => e.DeDelinquencyDate)
                    .HasColumnType("date")
                    .HasColumnName("de_delinquency_date");

                entity.Property(e => e.DeDepositTo)
                    .HasMaxLength(16)
                    .HasColumnName("de_deposit_to");

                entity.Property(e => e.DeDescription)
                    .HasMaxLength(256)
                    .HasColumnName("de_description");

                entity.Property(e => e.DeDisplayFlags).HasColumnName("de_display_flags");

                entity.Property(e => e.DeDl)
                    .HasMaxLength(160)
                    .HasColumnName("de_dl");

                entity.Property(e => e.DeDob)
                    .HasColumnType("date")
                    .HasColumnName("de_dob");

                entity.Property(e => e.DeEarlyPayoffAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_early_payoff_amount");

                entity.Property(e => e.DeEarlyPayoffDiscount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_early_payoff_discount");

                entity.Property(e => e.DeEarlyPayoffSavings)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_early_payoff_savings");

                entity.Property(e => e.DeEditDate)
                    .HasColumnType("date")
                    .HasColumnName("de_edit_date");

                entity.Property(e => e.DeElapsedTime).HasColumnName("de_elapsed_time");

                entity.Property(e => e.DeEmail)
                    .HasMaxLength(160)
                    .HasColumnName("de_email");

                entity.Property(e => e.DeEmailNum).HasColumnName("de_email_num");

                entity.Property(e => e.DeEntity).HasColumnName("de_entity");

                entity.Property(e => e.DeEstimatedTime).HasColumnName("de_estimated_time");

                entity.Property(e => e.DeFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_fees");

                entity.Property(e => e.DeFeesPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_fees_paid_to_date");

                entity.Property(e => e.DeFirstName)
                    .HasMaxLength(128)
                    .HasColumnName("de_first_name");

                entity.Property(e => e.DeFirstPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("de_first_payment_date");

                entity.Property(e => e.DeFixFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_fix_fee");

                entity.Property(e => e.DeFlags).HasColumnName("de_flags");

                entity.Property(e => e.DeFlags1).HasColumnName("de_flags_1");

                entity.Property(e => e.DeFlags2).HasColumnName("de_flags_2");

                entity.Property(e => e.DeFromOffice).HasColumnName("de_from_office");

                entity.Property(e => e.DeGeneration)
                    .HasMaxLength(64)
                    .HasColumnName("de_generation");

                entity.Property(e => e.DeGracePeriod).HasColumnName("de_grace_period");

                entity.Property(e => e.DeGroupFlags).HasColumnName("de_group_flags");

                entity.Property(e => e.DeGroupId).HasColumnName("de_group_id");

                entity.Property(e => e.DeGroupMember).HasColumnName("de_group_member");

                entity.Property(e => e.DeHomeExtension)
                    .HasMaxLength(16)
                    .HasColumnName("de_home_extension");

                entity.Property(e => e.DeHomePhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_home_phone");

                entity.Property(e => e.DeInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_interest");

                entity.Property(e => e.DeInterestDate)
                    .HasColumnType("date")
                    .HasColumnName("de_interest_date");

                entity.Property(e => e.DeInterestFlags1).HasColumnName("de_interest_flags1");

                entity.Property(e => e.DeInterestFlags2).HasColumnName("de_interest_flags2");

                entity.Property(e => e.DeInterestFlags3).HasColumnName("de_interest_flags3");

                entity.Property(e => e.DeInterestPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_interest_paid_to_date");

                entity.Property(e => e.DeInterestPeriod).HasColumnName("de_interest_period");

                entity.Property(e => e.DeInterestRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_interest_rate");

                entity.Property(e => e.DeInterestTime)
                    .HasMaxLength(8)
                    .HasColumnName("de_interest_time");

                entity.Property(e => e.DeJudgeFeePaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_fee_paidtodate");

                entity.Property(e => e.DeJudgeIntPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_int_paidtodate");

                entity.Property(e => e.DeJudgeLegalPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_legal_paidtodate");

                entity.Property(e => e.DeJudgeMiscPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_misc_paidtodate");

                entity.Property(e => e.DeJudgeOtherPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_other_paidtodate");

                entity.Property(e => e.DeJudgePrincPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_princ_paidtodate");

                entity.Property(e => e.DeJudgementBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_balance");

                entity.Property(e => e.DeJudgementDate)
                    .HasColumnType("date")
                    .HasColumnName("de_judgement_date");

                entity.Property(e => e.DeJudgementFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_fees");

                entity.Property(e => e.DeJudgementInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_interest");

                entity.Property(e => e.DeJudgementLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_legal");

                entity.Property(e => e.DeJudgementMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_misc");

                entity.Property(e => e.DeJudgementOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_other");

                entity.Property(e => e.DeJudgementPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_principal");

                entity.Property(e => e.DeLastAction)
                    .HasMaxLength(16)
                    .HasColumnName("de_last_action");

                entity.Property(e => e.DeLastPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_payment_date");

                entity.Property(e => e.DeLastWorkedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_worked_date");

                entity.Property(e => e.DeLastWorkedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_last_worked_time");

                entity.Property(e => e.DeLateFeeAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_late_fee_amount");

                entity.Property(e => e.DeLateFeeFlags1).HasColumnName("de_late_fee_flags1");

                entity.Property(e => e.DeLateFeeFlags2).HasColumnName("de_late_fee_flags2");

                entity.Property(e => e.DeLateFeePercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_late_fee_percent");

                entity.Property(e => e.DeLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_legal");

                entity.Property(e => e.DeLegalCosts)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_legal_costs");

                entity.Property(e => e.DeLegalPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_legal_paid_to_date");

                entity.Property(e => e.DeLetterNum).HasColumnName("de_letter_num");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeMby)
                    .HasMaxLength(16)
                    .HasColumnName("de_mby");

                entity.Property(e => e.DeMdate)
                    .HasColumnType("date")
                    .HasColumnName("de_mdate");

                entity.Property(e => e.DeMiddleName)
                    .HasMaxLength(128)
                    .HasColumnName("de_middle_name");

                entity.Property(e => e.DeMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_misc");

                entity.Property(e => e.DeMiscPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_misc_paid_to_date");

                entity.Property(e => e.DeModifiedBy)
                    .HasMaxLength(16)
                    .HasColumnName("de_modified_by");

                entity.Property(e => e.DeModifiedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_modified_date");

                entity.Property(e => e.DeModifiedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_modified_time");

                entity.Property(e => e.DeMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_mtime");

                entity.Property(e => e.DeName)
                    .HasMaxLength(128)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNextPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("de_next_payment_date");

                entity.Property(e => e.DeNoteblob).HasColumnName("de_noteblob");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeNumber1).HasColumnName("de_number_1");

                entity.Property(e => e.DeNumber2).HasColumnName("de_number_2");

                entity.Property(e => e.DeNumberOfPeriods).HasColumnName("de_number_of_periods");

                entity.Property(e => e.DeOkToPhone).HasColumnName("de_ok_to_phone");

                entity.Property(e => e.DeOp1)
                    .HasMaxLength(16)
                    .HasColumnName("de_op_1");

                entity.Property(e => e.DeOp2)
                    .HasMaxLength(16)
                    .HasColumnName("de_op_2");

                entity.Property(e => e.DeOrgCreditor)
                    .HasMaxLength(128)
                    .HasColumnName("de_org_creditor");

                entity.Property(e => e.DeOrgCreditorType).HasColumnName("de_org_creditor_type");

                entity.Property(e => e.DeOriginalInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_original_interest");

                entity.Property(e => e.DeOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_other");

                entity.Property(e => e.DeOtherExtension)
                    .HasMaxLength(16)
                    .HasColumnName("de_other_extension");

                entity.Property(e => e.DeOtherPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_other_paid_to_date");

                entity.Property(e => e.DeOtherPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_other_phone");

                entity.Property(e => e.DeOver90)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_over_90");

                entity.Property(e => e.DeOwing)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_owing");

                entity.Property(e => e.DeOwnedByDebtor).HasColumnName("de_owned_by_debtor");

                entity.Property(e => e.DePaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_paid");

                entity.Property(e => e.DePaymentAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_payment_amount");

                entity.Property(e => e.DePercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_percent_1");

                entity.Property(e => e.DePercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_percent_2");

                entity.Property(e => e.DePeriodDays).HasColumnName("de_period_days");

                entity.Property(e => e.DePoe)
                    .HasMaxLength(128)
                    .HasColumnName("de_poe");

                entity.Property(e => e.DePreCharge)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_pre_charge");

                entity.Property(e => e.DePreRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_pre_rate");

                entity.Property(e => e.DePrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_principal");

                entity.Property(e => e.DePrincipalPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_principal_paid_to_date");

                entity.Property(e => e.DeProcessId).HasColumnName("de_process_id");

                entity.Property(e => e.DeProcessStep).HasColumnName("de_process_step");

                entity.Property(e => e.DePromiseDate)
                    .HasColumnType("date")
                    .HasColumnName("de_promise_date");

                entity.Property(e => e.DeRateIndex)
                    .HasMaxLength(16)
                    .HasColumnName("de_rate_index");

                entity.Property(e => e.DeReferralRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_referral_rate");

                entity.Property(e => e.DeRiskScore).HasColumnName("de_risk_score");

                entity.Property(e => e.DeRowidClient).HasColumnName("de_rowid_client");

                entity.Property(e => e.DeSalesman)
                    .HasMaxLength(16)
                    .HasColumnName("de_salesman");

                entity.Property(e => e.DeSin)
                    .HasMaxLength(160)
                    .HasColumnName("de_sin");

                entity.Property(e => e.DeState)
                    .HasMaxLength(64)
                    .HasColumnName("de_state");

                entity.Property(e => e.DeStatus)
                    .HasMaxLength(20)
                    .HasColumnName("de_status");

                entity.Property(e => e.DeStreetNumber)
                    .HasMaxLength(48)
                    .HasColumnName("de_street_number");

                entity.Property(e => e.DeSummaryFlags).HasColumnName("de_summary_flags");

                entity.Property(e => e.DeTaxExempt).HasColumnName("de_tax_exempt");

                entity.Property(e => e.DeTaxOptions).HasColumnName("de_tax_options");

                entity.Property(e => e.DeTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_tax_rate");

                entity.Property(e => e.DeTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_tax_rate_1");

                entity.Property(e => e.DeTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_tax_rate_2");

                entity.Property(e => e.DeTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_tax_rate_3");

                entity.Property(e => e.DeTimeZone).HasColumnName("de_time_zone");

                entity.Property(e => e.DeTimezone1).HasColumnName("de_timezone");

                entity.Property(e => e.DeToOffice).HasColumnName("de_to_office");

                entity.Property(e => e.DeTotalPlanPayments)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_total_plan_payments");

                entity.Property(e => e.DeTransitNumber)
                    .HasMaxLength(128)
                    .HasColumnName("de_transit_number");

                entity.Property(e => e.DeType)
                    .HasMaxLength(64)
                    .HasColumnName("de_type");

                entity.Property(e => e.DeUid).HasColumnName("de_uid");

                entity.Property(e => e.DeUidm).HasColumnName("de_uidm");

                entity.Property(e => e.DeUido).HasColumnName("de_uido");

                entity.Property(e => e.DeUser1)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_1");

                entity.Property(e => e.DeUser2)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_2");

                entity.Property(e => e.DeUser3)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_3");

                entity.Property(e => e.DeUser4)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_4");

                entity.Property(e => e.DeUser5)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_5");

                entity.Property(e => e.DeWithdrawFrom)
                    .HasMaxLength(16)
                    .HasColumnName("de_withdraw_from");

                entity.Property(e => e.DeWorkExtension)
                    .HasMaxLength(16)
                    .HasColumnName("de_work_extension");

                entity.Property(e => e.DeWorkPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_work_phone");

                entity.Property(e => e.DeZip)
                    .HasMaxLength(48)
                    .HasColumnName("de_zip");

                entity.Property(e => e.LastClBillDate)
                    .HasColumnType("date")
                    .HasColumnName("last_cl_bill_date");

                entity.Property(e => e.LastClPaymentDate).HasColumnName("last_cl_payment_date");

                entity.HasOne(d => d.DeNoteblobNavigation)
                    .WithMany(p => p.ADebtors)
                    .HasForeignKey(d => d.DeNoteblob)
                    .HasConstraintName("FK__a_debtor__de_not__1CF15040");

                entity.HasOne(d => d.DeRowidClientNavigation)
                    .WithMany(p => p.ADebtors)
                    .HasForeignKey(d => d.DeRowidClient)
                    .HasConstraintName("FK__a_debtor__de_row__1BFD2C07");
            });

            modelBuilder.Entity<AEmail>(entity =>
            {
                entity.HasKey(e => e.EmRowid)
                    .HasName("PK__a_email__EBDFDBF0AA795972");

                entity.ToTable("a_email");

                entity.Property(e => e.EmRowid).HasColumnName("em_rowid");

                entity.Property(e => e.EmCby)
                    .HasMaxLength(16)
                    .HasColumnName("em_cby");

                entity.Property(e => e.EmCdate)
                    .HasColumnType("date")
                    .HasColumnName("em_cdate");

                entity.Property(e => e.EmCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("em_ctime");

                entity.Property(e => e.EmDate1)
                    .HasColumnType("date")
                    .HasColumnName("em_date_1");

                entity.Property(e => e.EmDate2)
                    .HasColumnType("date")
                    .HasColumnName("em_date_2");

                entity.Property(e => e.EmEmailAddress)
                    .HasMaxLength(256)
                    .HasColumnName("em_email_address");

                entity.Property(e => e.EmFlags).HasColumnName("em_flags");

                entity.Property(e => e.EmFlags1).HasColumnName("em_flags_1");

                entity.Property(e => e.EmMby)
                    .HasMaxLength(16)
                    .HasColumnName("em_mby");

                entity.Property(e => e.EmMdate)
                    .HasColumnType("date")
                    .HasColumnName("em_mdate");

                entity.Property(e => e.EmMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("em_mtime");

                entity.Property(e => e.EmOp1)
                    .HasMaxLength(16)
                    .HasColumnName("em_op_1");

                entity.Property(e => e.EmOp2)
                    .HasMaxLength(16)
                    .HasColumnName("em_op_2");

                entity.Property(e => e.EmRowidAssociated).HasColumnName("em_rowid_associated");

                entity.Property(e => e.EmRowidBank).HasColumnName("em_rowid_bank");

                entity.Property(e => e.EmRowidClient).HasColumnName("em_rowid_client");

                entity.Property(e => e.EmRowidCosigner).HasColumnName("em_rowid_cosigner");

                entity.Property(e => e.EmRowidDebtor).HasColumnName("em_rowid_debtor");

                entity.Property(e => e.EmType).HasColumnName("em_type");

                entity.Property(e => e.EmUid).HasColumnName("em_uid");

                entity.Property(e => e.EmUidm).HasColumnName("em_uidm");

                entity.Property(e => e.EmUido).HasColumnName("em_uido");

                entity.Property(e => e.EmUido1).HasColumnName("em_uido_1");

                entity.Property(e => e.EmUido2).HasColumnName("em_uido_2");

                entity.Property(e => e.EmUido3).HasColumnName("em_uido_3");

                entity.Property(e => e.EmUido4).HasColumnName("em_uido_4");

                entity.HasOne(d => d.EmRowidAssociatedNavigation)
                    .WithMany(p => p.AEmails)
                    .HasForeignKey(d => d.EmRowidAssociated)
                    .HasConstraintName("FK__a_email__em_rowi__2EDAF651");

                entity.HasOne(d => d.EmRowidBankNavigation)
                    .WithMany(p => p.AEmails)
                    .HasForeignKey(d => d.EmRowidBank)
                    .HasConstraintName("FK__a_email__em_rowi__2B0A656D");

                entity.HasOne(d => d.EmRowidClientNavigation)
                    .WithMany(p => p.AEmails)
                    .HasForeignKey(d => d.EmRowidClient)
                    .HasConstraintName("FK__a_email__em_rowi__2BFE89A6");

                entity.HasOne(d => d.EmRowidCosignerNavigation)
                    .WithMany(p => p.AEmails)
                    .HasForeignKey(d => d.EmRowidCosigner)
                    .HasConstraintName("FK__a_email__em_rowi__2DE6D218");

                entity.HasOne(d => d.EmRowidDebtorNavigation)
                    .WithMany(p => p.AEmails)
                    .HasForeignKey(d => d.EmRowidDebtor)
                    .HasConstraintName("FK__a_email__em_rowi__2CF2ADDF");
            });

            modelBuilder.Entity<AInvoice>(entity =>
            {
                entity.HasKey(e => e.InRowid)
                    .HasName("PK__a_invoic__3A8093B29C3C1CA5");

                entity.ToTable("a_invoice");

                entity.HasIndex(e => e.InDate, "in_date_key");

                entity.HasIndex(e => e.InRowidClient, "in_rowid_client_key");

                entity.Property(e => e.InRowid).HasColumnName("in_rowid");

                entity.Property(e => e.In120Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_120_days");

                entity.Property(e => e.In150Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_150_days");

                entity.Property(e => e.In30Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_30_days");

                entity.Property(e => e.In60Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_60_days");

                entity.Property(e => e.In90Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_90_days");

                entity.Property(e => e.InAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_amount_1");

                entity.Property(e => e.InAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_amount_2");

                entity.Property(e => e.InBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_balance");

                entity.Property(e => e.InCby)
                    .HasMaxLength(16)
                    .HasColumnName("in_cby");

                entity.Property(e => e.InCdate)
                    .HasColumnType("date")
                    .HasColumnName("in_cdate");

                entity.Property(e => e.InCheckNumber).HasColumnName("in_check_number");

                entity.Property(e => e.InCommission)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_commission");

                entity.Property(e => e.InCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_commission_rate");

                entity.Property(e => e.InCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("in_ctime");

                entity.Property(e => e.InCurrency).HasColumnName("in_currency");

                entity.Property(e => e.InDate)
                    .HasColumnType("date")
                    .HasColumnName("in_date");

                entity.Property(e => e.InDate1)
                    .HasColumnType("date")
                    .HasColumnName("in_date_1");

                entity.Property(e => e.InDate2)
                    .HasColumnType("date")
                    .HasColumnName("in_date_2");

                entity.Property(e => e.InDirect)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_direct");

                entity.Property(e => e.InDirectComm)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_direct_comm");

                entity.Property(e => e.InDirectTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_direct_tax");

                entity.Property(e => e.InDue)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_due");

                entity.Property(e => e.InFlags1).HasColumnName("in_flags_1");

                entity.Property(e => e.InFlags2).HasColumnName("in_flags_2");

                entity.Property(e => e.InFromDate)
                    .HasColumnType("date")
                    .HasColumnName("in_from_date");

                entity.Property(e => e.InGeneratedBy)
                    .HasMaxLength(16)
                    .HasColumnName("in_generated_by");

                entity.Property(e => e.InGst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_gst");

                entity.Property(e => e.InMby)
                    .HasMaxLength(16)
                    .HasColumnName("in_mby");

                entity.Property(e => e.InMdate)
                    .HasColumnType("date")
                    .HasColumnName("in_mdate");

                entity.Property(e => e.InMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("in_mtime");

                entity.Property(e => e.InNumber).HasColumnName("in_number");

                entity.Property(e => e.InNumber1).HasColumnName("in_number_1");

                entity.Property(e => e.InNumber2).HasColumnName("in_number_2");

                entity.Property(e => e.InOp1)
                    .HasMaxLength(16)
                    .HasColumnName("in_op_1");

                entity.Property(e => e.InOp2)
                    .HasMaxLength(16)
                    .HasColumnName("in_op_2");

                entity.Property(e => e.InPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_percent_1");

                entity.Property(e => e.InPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_percent_2");

                entity.Property(e => e.InReturned)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_returned");

                entity.Property(e => e.InRowidClient).HasColumnName("in_rowid_client");

                entity.Property(e => e.InSubtotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_subtotal");

                entity.Property(e => e.InToDate)
                    .HasColumnType("date")
                    .HasColumnName("in_to_date");

                entity.Property(e => e.InToUs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_to_us");

                entity.Property(e => e.InTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_total");

                entity.Property(e => e.InTousComm)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_tous_comm");

                entity.Property(e => e.InTousTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_tous_tax");

                entity.Property(e => e.InType).HasColumnName("in_type");

                entity.Property(e => e.InUid).HasColumnName("in_uid");

                entity.Property(e => e.InUidm).HasColumnName("in_uidm");

                entity.Property(e => e.InUido).HasColumnName("in_uido");

                entity.HasOne(d => d.InRowidClientNavigation)
                    .WithMany(p => p.AInvoices)
                    .HasForeignKey(d => d.InRowidClient)
                    .HasConstraintName("FK__a_invoice__in_ro__3A4CA8FD");
            });

            modelBuilder.Entity<AInvoiceLine>(entity =>
            {
                entity.HasKey(e => e.IlRowid)
                    .HasName("PK__a_invoic__7ED0E8A84E4A7E28");

                entity.ToTable("a_invoice_line");

                entity.HasIndex(e => e.IlRowidDeTransaction, "il_rowid_de_transaction_key");

                entity.HasIndex(e => e.IlRowidInvoice, "il_rowid_invoice_key");

                entity.Property(e => e.IlRowid).HasColumnName("il_rowid");

                entity.Property(e => e.IlBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_balance");

                entity.Property(e => e.IlCby)
                    .HasMaxLength(16)
                    .HasColumnName("il_cby");

                entity.Property(e => e.IlCdate)
                    .HasColumnType("date")
                    .HasColumnName("il_cdate");

                entity.Property(e => e.IlCommission)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_commission");

                entity.Property(e => e.IlCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_commission_rate");

                entity.Property(e => e.IlCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("il_ctime");

                entity.Property(e => e.IlDate)
                    .HasColumnType("date")
                    .HasColumnName("il_date");

                entity.Property(e => e.IlDebtor)
                    .HasMaxLength(128)
                    .HasColumnName("il_debtor");

                entity.Property(e => e.IlDebtorNumber).HasColumnName("il_debtor_number");

                entity.Property(e => e.IlDescription)
                    .HasMaxLength(128)
                    .HasColumnName("il_description");

                entity.Property(e => e.IlDirect)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_direct");

                entity.Property(e => e.IlMby)
                    .HasMaxLength(16)
                    .HasColumnName("il_mby");

                entity.Property(e => e.IlMdate)
                    .HasColumnType("date")
                    .HasColumnName("il_mdate");

                entity.Property(e => e.IlMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("il_mtime");

                entity.Property(e => e.IlNumber).HasColumnName("il_number");

                entity.Property(e => e.IlReturned)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_returned");

                entity.Property(e => e.IlRowidDeTransaction).HasColumnName("il_rowid_de_transaction");

                entity.Property(e => e.IlRowidInvoice).HasColumnName("il_rowid_invoice");

                entity.Property(e => e.IlTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_tax");

                entity.Property(e => e.IlToUs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_to_us");

                entity.Property(e => e.IlUid).HasColumnName("il_uid");

                entity.Property(e => e.IlUidm).HasColumnName("il_uidm");

                entity.Property(e => e.IlUido).HasColumnName("il_uido");

                entity.Property(e => e.IlUido1).HasColumnName("il_uido_1");

                entity.HasOne(d => d.IlRowidDeTransactionNavigation)
                    .WithMany(p => p.AInvoiceLines)
                    .HasForeignKey(d => d.IlRowidDeTransaction)
                    .HasConstraintName("FK__a_invoice__il_ro__41EDCAC5");

                entity.HasOne(d => d.IlRowidInvoiceNavigation)
                    .WithMany(p => p.AInvoiceLines)
                    .HasForeignKey(d => d.IlRowidInvoice)
                    .HasConstraintName("FK__a_invoice__il_ro__40F9A68C");
            });

            modelBuilder.Entity<ANote>(entity =>
            {
                entity.HasKey(e => e.NoRowid)
                    .HasName("PK__a_notes__DD8F4A22D3C6DE18");

                entity.ToTable("a_notes");

                entity.Property(e => e.NoRowid).HasColumnName("no_rowid");

                entity.Property(e => e.NoRowidClient).HasColumnName("no_rowid_client");

                entity.Property(e => e.NoRowidDebtor).HasColumnName("no_rowid_debtor");

                entity.Property(e => e.NoText)
                    .HasMaxLength(160)
                    .HasColumnName("no_text");

                entity.HasOne(d => d.NoRowidClientNavigation)
                    .WithMany(p => p.ANotes)
                    .HasForeignKey(d => d.NoRowidClient)
                    .HasConstraintName("FK__a_notes__no_rowi__489AC854");

                entity.HasOne(d => d.NoRowidDebtorNavigation)
                    .WithMany(p => p.ANotes)
                    .HasForeignKey(d => d.NoRowidDebtor)
                    .HasConstraintName("FK__a_notes__no_rowi__498EEC8D");
            });

            modelBuilder.Entity<ANxday>(entity =>
            {
                entity.HasKey(e => e.DaRowid)
                    .HasName("PK__a_nxday__6D5388C6114E9C53");

                entity.ToTable("a_nxday");

                entity.Property(e => e.DaRowid).HasColumnName("da_rowid");

                entity.Property(e => e.DaAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_amount_1");

                entity.Property(e => e.DaAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_amount_2");

                entity.Property(e => e.DaBuffer1)
                    .HasMaxLength(510)
                    .HasColumnName("da_buffer_1");

                entity.Property(e => e.DaBuffer2)
                    .HasMaxLength(510)
                    .HasColumnName("da_buffer_2");

                entity.Property(e => e.DaCalls).HasColumnName("da_calls");

                entity.Property(e => e.DaCallsRemaining).HasColumnName("da_calls_remaining");

                entity.Property(e => e.DaCategory).HasColumnName("da_category");

                entity.Property(e => e.DaCategory1).HasColumnName("da_category_1");

                entity.Property(e => e.DaCategory2).HasColumnName("da_category_2");

                entity.Property(e => e.DaCby)
                    .HasMaxLength(16)
                    .HasColumnName("da_cby");

                entity.Property(e => e.DaCdate)
                    .HasColumnType("date")
                    .HasColumnName("da_cdate");

                entity.Property(e => e.DaClientPayments)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_client_payments");

                entity.Property(e => e.DaCommFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_fees");

                entity.Property(e => e.DaCommInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_interest");

                entity.Property(e => e.DaCommLegal).HasColumnName("da_comm_legal");

                entity.Property(e => e.DaCommMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_misc");

                entity.Property(e => e.DaCommOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_other");

                entity.Property(e => e.DaCommPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_principal");

                entity.Property(e => e.DaCommission)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_commission");

                entity.Property(e => e.DaContacts).HasColumnName("da_contacts");

                entity.Property(e => e.DaCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("da_ctime");

                entity.Property(e => e.DaDate)
                    .HasColumnType("date")
                    .HasColumnName("da_date");

                entity.Property(e => e.DaDate1)
                    .HasColumnType("date")
                    .HasColumnName("da_date_1");

                entity.Property(e => e.DaDate2)
                    .HasColumnType("date")
                    .HasColumnName("da_date_2");

                entity.Property(e => e.DaDebtFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_fees");

                entity.Property(e => e.DaDebtInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_interest");

                entity.Property(e => e.DaDebtLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_legal");

                entity.Property(e => e.DaDebtMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_misc");

                entity.Property(e => e.DaDebtOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_other");

                entity.Property(e => e.DaDebtPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_principal");

                entity.Property(e => e.DaFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_fees");

                entity.Property(e => e.DaFlags1).HasColumnName("da_flags_1");

                entity.Property(e => e.DaFlags2).HasColumnName("da_flags_2");

                entity.Property(e => e.DaInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_interest");

                entity.Property(e => e.DaLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_legal");

                entity.Property(e => e.DaMailings).HasColumnName("da_mailings");

                entity.Property(e => e.DaMby)
                    .HasMaxLength(16)
                    .HasColumnName("da_mby");

                entity.Property(e => e.DaMdate)
                    .HasColumnType("date")
                    .HasColumnName("da_mdate");

                entity.Property(e => e.DaMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_misc");

                entity.Property(e => e.DaMonthToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_month_to_date");

                entity.Property(e => e.DaMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("da_mtime");

                entity.Property(e => e.DaNumber1).HasColumnName("da_number_1");

                entity.Property(e => e.DaNumber2).HasColumnName("da_number_2");

                entity.Property(e => e.DaNumberOfListings).HasColumnName("da_number_of_listings");

                entity.Property(e => e.DaOp1)
                    .HasMaxLength(16)
                    .HasColumnName("da_op_1");

                entity.Property(e => e.DaOp2)
                    .HasMaxLength(16)
                    .HasColumnName("da_op_2");

                entity.Property(e => e.DaOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_other");

                entity.Property(e => e.DaOthers).HasColumnName("da_others");

                entity.Property(e => e.DaOthersRemaining).HasColumnName("da_others_remaining");

                entity.Property(e => e.DaPaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_paid");

                entity.Property(e => e.DaPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_percent_1");

                entity.Property(e => e.DaPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_percent_2");

                entity.Property(e => e.DaPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_principal");

                entity.Property(e => e.DaPromised)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_promised");

                entity.Property(e => e.DaRemainingContacts).HasColumnName("da_remaining_contacts");

                entity.Property(e => e.DaRemainingMailings).HasColumnName("da_remaining_mailings");

                entity.Property(e => e.DaReviews).HasColumnName("da_reviews");

                entity.Property(e => e.DaReviewsRemaining).HasColumnName("da_reviews_remaining");

                entity.Property(e => e.DaTaxFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_fees");

                entity.Property(e => e.DaTaxInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_interest");

                entity.Property(e => e.DaTaxLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_legal");

                entity.Property(e => e.DaTaxMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_misc");

                entity.Property(e => e.DaTaxOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_other");

                entity.Property(e => e.DaTaxPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_principal");

                entity.Property(e => e.DaTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_total");

                entity.Property(e => e.DaTotalListed)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_total_listed");

                entity.Property(e => e.DaUid).HasColumnName("da_uid");

                entity.Property(e => e.DaUidm).HasColumnName("da_uidm");
            });

            modelBuilder.Entity<APhone>(entity =>
            {
                entity.HasKey(e => e.PhRowid)
                    .HasName("PK__a_phone__965FCA8974A27441");

                entity.ToTable("a_phone");

                entity.HasIndex(e => e.PhCategory, "ph_category_key");

                entity.HasIndex(e => e.PhRowidAssociated, "ph_rowid_associated_key");

                entity.HasIndex(e => e.PhRowidBank, "ph_rowid_bank_key");

                entity.HasIndex(e => e.PhRowidClient, "ph_rowid_client_key");

                entity.HasIndex(e => e.PhRowidCosigner, "ph_rowid_cosigner_key");

                entity.HasIndex(e => e.PhRowidDebtor, "ph_rowid_debtor_key");

                entity.Property(e => e.PhRowid).HasColumnName("ph_rowid");

                entity.Property(e => e.PhCategory).HasColumnName("ph_category");

                entity.Property(e => e.PhCategory1).HasColumnName("ph_category_1");

                entity.Property(e => e.PhCategory2).HasColumnName("ph_category_2");

                entity.Property(e => e.PhCby)
                    .HasMaxLength(16)
                    .HasColumnName("ph_cby");

                entity.Property(e => e.PhCdate)
                    .HasColumnType("date")
                    .HasColumnName("ph_cdate");

                entity.Property(e => e.PhCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_ctime");

                entity.Property(e => e.PhDateReceived)
                    .HasColumnType("date")
                    .HasColumnName("ph_date_received");

                entity.Property(e => e.PhExtension)
                    .HasMaxLength(16)
                    .HasColumnName("ph_extension");

                entity.Property(e => e.PhFlags).HasColumnName("ph_flags");

                entity.Property(e => e.PhMby)
                    .HasMaxLength(16)
                    .HasColumnName("ph_mby");

                entity.Property(e => e.PhMdate)
                    .HasColumnType("date")
                    .HasColumnName("ph_mdate");

                entity.Property(e => e.PhMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_mtime");

                entity.Property(e => e.PhNisDate)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_NIS_date");

                entity.Property(e => e.PhNisId).HasColumnName("ph_NIS_id");

                entity.Property(e => e.PhNisReason).HasColumnName("ph_NIS_reason");

                entity.Property(e => e.PhNumber)
                    .HasMaxLength(48)
                    .HasColumnName("ph_number");

                entity.Property(e => e.PhNumber1).HasColumnName("ph_number_1");

                entity.Property(e => e.PhNumber2).HasColumnName("ph_number_2");

                entity.Property(e => e.PhRowidAssociated).HasColumnName("ph_rowid_associated");

                entity.Property(e => e.PhRowidBank).HasColumnName("ph_rowid_bank");

                entity.Property(e => e.PhRowidClient).HasColumnName("ph_rowid_client");

                entity.Property(e => e.PhRowidCosigner).HasColumnName("ph_rowid_cosigner");

                entity.Property(e => e.PhRowidDebtor).HasColumnName("ph_rowid_debtor");

                entity.Property(e => e.PhSource).HasColumnName("ph_source");

                entity.Property(e => e.PhTimeFrom)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_time_from");

                entity.Property(e => e.PhTimeTo)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_time_to");

                entity.Property(e => e.PhTimezone).HasColumnName("ph_timezone");

                entity.Property(e => e.PhType).HasColumnName("ph_type");

                entity.Property(e => e.PhUid).HasColumnName("ph_uid");

                entity.Property(e => e.PhUidm).HasColumnName("ph_uidm");

                entity.Property(e => e.PhUido).HasColumnName("ph_uido");

                entity.Property(e => e.PhUido1).HasColumnName("ph_uido_1");

                entity.Property(e => e.PhUido2).HasColumnName("ph_uido_2");

                entity.Property(e => e.PhUido3).HasColumnName("ph_uido_3");

                entity.Property(e => e.PhUido4).HasColumnName("ph_uido_4");

                entity.Property(e => e.PhUser1)
                    .HasMaxLength(60)
                    .HasColumnName("ph_user1");

                entity.Property(e => e.PhUser2)
                    .HasMaxLength(60)
                    .HasColumnName("ph_user2");

                entity.HasOne(d => d.PhRowidAssociatedNavigation)
                    .WithMany(p => p.APhones)
                    .HasForeignKey(d => d.PhRowidAssociated)
                    .HasConstraintName("FK__a_phone__ph_rowi__5CA1C101");

                entity.HasOne(d => d.PhRowidBankNavigation)
                    .WithMany(p => p.APhones)
                    .HasForeignKey(d => d.PhRowidBank)
                    .HasConstraintName("FK__a_phone__ph_rowi__58D1301D");

                entity.HasOne(d => d.PhRowidClientNavigation)
                    .WithMany(p => p.APhones)
                    .HasForeignKey(d => d.PhRowidClient)
                    .HasConstraintName("FK__a_phone__ph_rowi__59C55456");

                entity.HasOne(d => d.PhRowidCosignerNavigation)
                    .WithMany(p => p.APhones)
                    .HasForeignKey(d => d.PhRowidCosigner)
                    .HasConstraintName("FK__a_phone__ph_rowi__5BAD9CC8");

                entity.HasOne(d => d.PhRowidDebtorNavigation)
                    .WithMany(p => p.APhones)
                    .HasForeignKey(d => d.PhRowidDebtor)
                    .HasConstraintName("FK__a_phone__ph_rowi__5AB9788F");
            });

            modelBuilder.Entity<AddressLookup>(entity =>
            {
                entity.HasKey(e => e.AddRowid)
                    .HasName("PK__address___2A1A3B57388903A5");

                entity.ToTable("address_lookup");

                entity.HasIndex(e => e.AddRowidAssociated, "add_rowid_associated_key");

                entity.HasIndex(e => e.AddRowidBank, "add_rowid_bank_key");

                entity.HasIndex(e => e.AddRowidClient, "add_rowid_client_key");

                entity.HasIndex(e => e.AddRowidCosigner, "add_rowid_cosigner_key");

                entity.HasIndex(e => e.AddRowidDebtor, "add_rowid_debtor_key");

                entity.Property(e => e.AddRowid).HasColumnName("add_rowid");

                entity.Property(e => e.AddAddress)
                    .HasMaxLength(164)
                    .HasColumnName("add_address");

                entity.Property(e => e.AddAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("add_address_1");

                entity.Property(e => e.AddAddress2)
                    .HasMaxLength(144)
                    .HasColumnName("add_address_2");

                entity.Property(e => e.AddAddressSource).HasColumnName("add_address_source");

                entity.Property(e => e.AddCategory).HasColumnName("add_category");

                entity.Property(e => e.AddCategory1).HasColumnName("add_category_1");

                entity.Property(e => e.AddCategory2).HasColumnName("add_category_2");

                entity.Property(e => e.AddCby)
                    .HasMaxLength(16)
                    .HasColumnName("add_cby");

                entity.Property(e => e.AddCdate)
                    .HasColumnType("date")
                    .HasColumnName("add_cdate");

                entity.Property(e => e.AddCity)
                    .HasMaxLength(64)
                    .HasColumnName("add_city");

                entity.Property(e => e.AddCountry)
                    .HasMaxLength(64)
                    .HasColumnName("add_country");

                entity.Property(e => e.AddCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("add_ctime");

                entity.Property(e => e.AddFlags).HasColumnName("add_flags");

                entity.Property(e => e.AddMby)
                    .HasMaxLength(16)
                    .HasColumnName("add_mby");

                entity.Property(e => e.AddMdate)
                    .HasColumnType("date")
                    .HasColumnName("add_mdate");

                entity.Property(e => e.AddMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("add_mtime");

                entity.Property(e => e.AddRowidAssociated).HasColumnName("add_rowid_associated");

                entity.Property(e => e.AddRowidBank).HasColumnName("add_rowid_bank");

                entity.Property(e => e.AddRowidClient).HasColumnName("add_rowid_client");

                entity.Property(e => e.AddRowidCosigner).HasColumnName("add_rowid_cosigner");

                entity.Property(e => e.AddRowidDebtor).HasColumnName("add_rowid_debtor");

                entity.Property(e => e.AddState)
                    .HasMaxLength(64)
                    .HasColumnName("add_state");

                entity.Property(e => e.AddTimezone).HasColumnName("add_timezone");

                entity.Property(e => e.AddType).HasColumnName("add_type");

                entity.Property(e => e.AddUid).HasColumnName("add_uid");

                entity.Property(e => e.AddUidm).HasColumnName("add_uidm");

                entity.Property(e => e.AddUido).HasColumnName("add_uido");

                entity.Property(e => e.AddUido1).HasColumnName("add_uido_1");

                entity.Property(e => e.AddUido2).HasColumnName("add_uido_2");

                entity.Property(e => e.AddUido3).HasColumnName("add_uido_3");

                entity.Property(e => e.AddUido4).HasColumnName("add_uido_4");

                entity.Property(e => e.AddZip)
                    .HasMaxLength(48)
                    .HasColumnName("add_zip");

                entity.HasOne(d => d.AddRowidAssociatedNavigation)
                    .WithMany(p => p.AddressLookups)
                    .HasForeignKey(d => d.AddRowidAssociated)
                    .HasConstraintName("FK__address_l__add_r__4222D4EF");

                entity.HasOne(d => d.AddRowidBankNavigation)
                    .WithMany(p => p.AddressLookups)
                    .HasForeignKey(d => d.AddRowidBank)
                    .HasConstraintName("FK__address_l__add_r__3E52440B");

                entity.HasOne(d => d.AddRowidClientNavigation)
                    .WithMany(p => p.AddressLookups)
                    .HasForeignKey(d => d.AddRowidClient)
                    .HasConstraintName("FK__address_l__add_r__3F466844");

                entity.HasOne(d => d.AddRowidCosignerNavigation)
                    .WithMany(p => p.AddressLookups)
                    .HasForeignKey(d => d.AddRowidCosigner)
                    .HasConstraintName("FK__address_l__add_r__412EB0B6");

                entity.HasOne(d => d.AddRowidDebtorNavigation)
                    .WithMany(p => p.AddressLookups)
                    .HasForeignKey(d => d.AddRowidDebtor)
                    .HasConstraintName("FK__address_l__add_r__403A8C7D");
            });

            modelBuilder.Entity<ApplicationForm>(entity =>
            {
                entity.HasKey(e => e.AfRowid)
                    .HasName("PK__applicat__1238F791F74E8E6A");

                entity.ToTable("application_form");

                entity.HasIndex(e => e.AfAlias, "af_alias_key");

                entity.HasIndex(e => e.AfControlFile, "af_control_file_key");

                entity.HasIndex(e => e.AfFormName, "af_form_name_key");

                entity.HasIndex(e => e.AfPickListFile, "af_pick_list_file_key");

                entity.Property(e => e.AfRowid).HasColumnName("af_rowid");

                entity.Property(e => e.AfAlias)
                    .HasMaxLength(132)
                    .HasColumnName("af_alias");

                entity.Property(e => e.AfAttributes1).HasColumnName("af_attributes_1");

                entity.Property(e => e.AfAttributes2).HasColumnName("af_attributes_2");

                entity.Property(e => e.AfCby)
                    .HasMaxLength(16)
                    .HasColumnName("af_cby");

                entity.Property(e => e.AfCdate)
                    .HasColumnType("date")
                    .HasColumnName("af_cdate");

                entity.Property(e => e.AfColor).HasColumnName("af_color");

                entity.Property(e => e.AfControlFile)
                    .HasMaxLength(128)
                    .HasColumnName("af_control_file");

                entity.Property(e => e.AfCounter).HasColumnName("af_counter");

                entity.Property(e => e.AfCounterType).HasColumnName("af_counter_type");

                entity.Property(e => e.AfCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("af_ctime");

                entity.Property(e => e.AfDefaultValue)
                    .HasMaxLength(256)
                    .HasColumnName("af_default_value");

                entity.Property(e => e.AfFldType).HasColumnName("af_fld_type");

                entity.Property(e => e.AfFormFieldname)
                    .HasMaxLength(132)
                    .HasColumnName("af_form_fieldname");

                entity.Property(e => e.AfFormHeight).HasColumnName("af_form_height");

                entity.Property(e => e.AfFormName)
                    .HasMaxLength(132)
                    .HasColumnName("af_form_name");

                entity.Property(e => e.AfFormNumber).HasColumnName("af_form_number");

                entity.Property(e => e.AfFormWidth).HasColumnName("af_form_width");

                entity.Property(e => e.AfListIndex).HasColumnName("af_list_index");

                entity.Property(e => e.AfListWidth).HasColumnName("af_list_width");

                entity.Property(e => e.AfLogChanges).HasColumnName("af_log_changes");

                entity.Property(e => e.AfMby)
                    .HasMaxLength(16)
                    .HasColumnName("af_mby");

                entity.Property(e => e.AfMdate)
                    .HasColumnType("date")
                    .HasColumnName("af_mdate");

                entity.Property(e => e.AfMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("af_mtime");

                entity.Property(e => e.AfPickListFile)
                    .HasMaxLength(128)
                    .HasColumnName("af_pick_list_file");

                entity.Property(e => e.AfUid).HasColumnName("af_uid");

                entity.Property(e => e.AfUidm).HasColumnName("af_uidm");

                entity.Property(e => e.AfUido).HasColumnName("af_uido");

                entity.Property(e => e.AfX).HasColumnName("af_x");

                entity.Property(e => e.AfY).HasColumnName("af_y");
            });

            modelBuilder.Entity<AsContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__as_conta__91C3A18C041B99DD");

                entity.ToTable("as_contact");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidAssociated).HasColumnName("co_rowid_associated");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.AsContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__as_contac__co_at__4E88ABD4");

                entity.HasOne(d => d.CoRowidAssociatedNavigation)
                    .WithMany(p => p.AsContacts)
                    .HasForeignKey(d => d.CoRowidAssociated)
                    .HasConstraintName("FK__as_contac__co_ro__4D94879B");
            });

            modelBuilder.Entity<Associated>(entity =>
            {
                entity.HasKey(e => e.AsCosRowid)
                    .HasName("PK__associat__62B199EB104D0685");

                entity.ToTable("associated");

                entity.HasIndex(e => e.AsCosBusinessPhone, "as_cos_business_phone_key");

                entity.HasIndex(e => e.AsCosCategory1, "as_cos_category_1_key");

                entity.HasIndex(e => e.AsCosCategory, "as_cos_category_key");

                entity.HasIndex(e => e.AsCosCellPhone, "as_cos_cell_phone_key");

                entity.HasIndex(e => e.AsCosCity, "as_cos_city_key");

                entity.HasIndex(e => e.AsCosDl, "as_cos_dl_key");

                entity.HasIndex(e => e.AsCosDob, "as_cos_dob_key");

                entity.HasIndex(e => e.AsCosEmail, "as_cos_email_key");

                entity.HasIndex(e => e.AsCosName, "as_cos_name_key");

                entity.HasIndex(e => e.AsCosOtherPhone, "as_cos_other_phone_key");

                entity.HasIndex(e => e.AsCosPhone, "as_cos_phone_key");

                entity.HasIndex(e => e.AsCosRowidClient, "as_cos_rowid_client_key");

                entity.HasIndex(e => e.AsCosSin, "as_cos_sin_key");

                entity.HasIndex(e => e.AsCosState, "as_cos_state_key");

                entity.HasIndex(e => e.AsCosZip, "as_cos_zip_key");

                entity.HasIndex(e => e.AsCosigner, "as_cosigner_key");

                entity.Property(e => e.AsCosRowid).HasColumnName("as_cos_rowid");

                entity.Property(e => e.AsCosAddress)
                    .HasMaxLength(164)
                    .HasColumnName("as_cos_address");

                entity.Property(e => e.AsCosAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("as_cos_address_1");

                entity.Property(e => e.AsCosAddress2)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_address_2");

                entity.Property(e => e.AsCosAddressFlags).HasColumnName("as_cos_address_flags");

                entity.Property(e => e.AsCosAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_amount");

                entity.Property(e => e.AsCosAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_amount_1");

                entity.Property(e => e.AsCosAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_amount_2");

                entity.Property(e => e.AsCosAttachNum).HasColumnName("as_cos_attach_num");

                entity.Property(e => e.AsCosBusinessExt)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_business_ext");

                entity.Property(e => e.AsCosBusinessPhone)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_business_phone");

                entity.Property(e => e.AsCosCategory).HasColumnName("as_cos_category");

                entity.Property(e => e.AsCosCategory1).HasColumnName("as_cos_category_1");

                entity.Property(e => e.AsCosCategory2).HasColumnName("as_cos_category_2");

                entity.Property(e => e.AsCosCbrAssociation)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_cbr_association");

                entity.Property(e => e.AsCosCby)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_cby");

                entity.Property(e => e.AsCosCdate)
                    .HasColumnType("date")
                    .HasColumnName("as_cos_cdate");

                entity.Property(e => e.AsCosCellExt)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_cell_ext");

                entity.Property(e => e.AsCosCellPhone)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_cell_phone");

                entity.Property(e => e.AsCosCinfoInd)
                    .HasMaxLength(8)
                    .HasColumnName("as_cos_cinfo_ind");

                entity.Property(e => e.AsCosCity)
                    .HasMaxLength(64)
                    .HasColumnName("as_cos_city");

                entity.Property(e => e.AsCosClass).HasColumnName("as_cos_class");

                entity.Property(e => e.AsCosCountry)
                    .HasMaxLength(64)
                    .HasColumnName("as_cos_country");

                entity.Property(e => e.AsCosCreated).HasColumnName("as_cos_created");

                entity.Property(e => e.AsCosCreatedBy)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_created_by");

                entity.Property(e => e.AsCosCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("as_cos_ctime");

                entity.Property(e => e.AsCosDate1)
                    .HasColumnType("date")
                    .HasColumnName("as_cos_date_1");

                entity.Property(e => e.AsCosDate2)
                    .HasColumnType("date")
                    .HasColumnName("as_cos_date_2");

                entity.Property(e => e.AsCosDl)
                    .HasMaxLength(160)
                    .HasColumnName("as_cos_dl");

                entity.Property(e => e.AsCosDob).HasColumnName("as_cos_dob");

                entity.Property(e => e.AsCosEcoa)
                    .HasMaxLength(8)
                    .HasColumnName("as_cos_ecoa");

                entity.Property(e => e.AsCosEmail)
                    .HasMaxLength(256)
                    .HasColumnName("as_cos_email");

                entity.Property(e => e.AsCosEmailNum).HasColumnName("as_cos_email_num");

                entity.Property(e => e.AsCosEntity).HasColumnName("as_cos_entity");

                entity.Property(e => e.AsCosFlags1).HasColumnName("as_cos_flags_1");

                entity.Property(e => e.AsCosFlags2).HasColumnName("as_cos_flags_2");

                entity.Property(e => e.AsCosGroupFlags).HasColumnName("as_cos_group_flags");

                entity.Property(e => e.AsCosGroupId).HasColumnName("as_cos_group_id");

                entity.Property(e => e.AsCosGroupMember).HasColumnName("as_cos_group_member");

                entity.Property(e => e.AsCosLetterNum).HasColumnName("as_cos_letter_num");

                entity.Property(e => e.AsCosMby)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_mby");

                entity.Property(e => e.AsCosMdate)
                    .HasColumnType("date")
                    .HasColumnName("as_cos_mdate");

                entity.Property(e => e.AsCosModified).HasColumnName("as_cos_modified");

                entity.Property(e => e.AsCosModifiedBy)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_modified_by");

                entity.Property(e => e.AsCosMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("as_cos_mtime");

                entity.Property(e => e.AsCosName)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_name");

                entity.Property(e => e.AsCosNote1)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_note_1");

                entity.Property(e => e.AsCosNote2)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_note_2");

                entity.Property(e => e.AsCosNote3)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_note_3");

                entity.Property(e => e.AsCosNote4)
                    .HasMaxLength(128)
                    .HasColumnName("as_cos_note_4");

                entity.Property(e => e.AsCosNumber1).HasColumnName("as_cos_number_1");

                entity.Property(e => e.AsCosNumber2).HasColumnName("as_cos_number_2");

                entity.Property(e => e.AsCosOp1)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_op_1");

                entity.Property(e => e.AsCosOp2)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_op_2");

                entity.Property(e => e.AsCosOtherExt)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_other_ext");

                entity.Property(e => e.AsCosOtherPhone)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_other_phone");

                entity.Property(e => e.AsCosPercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_percent");

                entity.Property(e => e.AsCosPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_percent_1");

                entity.Property(e => e.AsCosPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("as_cos_percent_2");

                entity.Property(e => e.AsCosPhone)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_phone");

                entity.Property(e => e.AsCosPhoneExt)
                    .HasMaxLength(16)
                    .HasColumnName("as_cos_phone_ext");

                entity.Property(e => e.AsCosRowidClient).HasColumnName("as_cos_rowid_client");

                entity.Property(e => e.AsCosSin)
                    .HasMaxLength(160)
                    .HasColumnName("as_cos_sin");

                entity.Property(e => e.AsCosState)
                    .HasMaxLength(64)
                    .HasColumnName("as_cos_state");

                entity.Property(e => e.AsCosStreetNumber)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_street_number");

                entity.Property(e => e.AsCosTimezone).HasColumnName("as_cos_timezone");

                entity.Property(e => e.AsCosTitle)
                    .HasMaxLength(64)
                    .HasColumnName("as_cos_title");

                entity.Property(e => e.AsCosType).HasColumnName("as_cos_type");

                entity.Property(e => e.AsCosUid).HasColumnName("as_cos_uid");

                entity.Property(e => e.AsCosUidm).HasColumnName("as_cos_uidm");

                entity.Property(e => e.AsCosUido).HasColumnName("as_cos_uido");

                entity.Property(e => e.AsCosZip)
                    .HasMaxLength(48)
                    .HasColumnName("as_cos_zip");

                entity.Property(e => e.AsCosigner)
                    .HasMaxLength(128)
                    .HasColumnName("as_cosigner");

                entity.HasOne(d => d.AsCosRowidClientNavigation)
                    .WithMany(p => p.Associateds)
                    .HasForeignKey(d => d.AsCosRowidClient)
                    .HasConstraintName("FK__associate__as_co__25869641");
            });

            modelBuilder.Entity<AtContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__at_conta__91C3A18CE8AC068C");

                entity.ToTable("at_contact");

                entity.HasIndex(e => e.CoAttachmentBlob, "co_attachment_blob_key");

                entity.HasIndex(e => e.CoCategory1, "co_category_1_key");

                entity.HasIndex(e => e.CoCategory, "co_category_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoType, e.CoDate }, "co_completedtypedate_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoWho, e.CoDate }, "co_completedwhodate_key");

                entity.HasIndex(e => e.CoDate, "co_date_key");

                entity.HasIndex(e => e.CoDoneDate, "co_done_date_key");

                entity.HasIndex(e => new { e.CoOriginator, e.CoCreationDate }, "co_originatordate_key");

                entity.HasIndex(e => e.CoRowidAttachment, "co_rowid_attachment_key");

                entity.HasIndex(e => new { e.CoType, e.CoCompleted, e.CoWho, e.CoDate }, "co_typecompletedwhodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoDoneDate }, "co_whodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoType, e.CoDate }, "co_whotypedate_key");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidAttachment).HasColumnName("co_rowid_attachment");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.AtContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__at_contac__co_at__5DCAEF64");

                entity.HasOne(d => d.CoRowidAttachmentNavigation)
                    .WithMany(p => p.AtContacts)
                    .HasForeignKey(d => d.CoRowidAttachment)
                    .HasConstraintName("FK__at_contac__co_ro__5CD6CB2B");
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.HasKey(e => e.AtRowid)
                    .HasName("PK__attachme__39C176A411654D48");

                entity.ToTable("attachment");

                entity.HasIndex(e => e.AtBlob, "at_blob_key");

                entity.HasIndex(e => e.AtDate1, "at_date_1_key");

                entity.HasIndex(e => e.AtDate2, "at_date_2_key");

                entity.HasIndex(e => e.AtDetail1, "at_detail_1_key");

                entity.HasIndex(e => e.AtDetail2, "at_detail_2_key");

                entity.HasIndex(e => e.AtRowidDebtor, "at_rowid_debtor_key");

                entity.Property(e => e.AtRowid).HasColumnName("at_rowid");

                entity.Property(e => e.AtBlob).HasColumnName("at_blob");

                entity.Property(e => e.AtCategory).HasColumnName("at_category");

                entity.Property(e => e.AtCategory1).HasColumnName("at_category_1");

                entity.Property(e => e.AtCategory2).HasColumnName("at_category_2");

                entity.Property(e => e.AtCby)
                    .HasMaxLength(16)
                    .HasColumnName("at_cby");

                entity.Property(e => e.AtCdate)
                    .HasColumnType("date")
                    .HasColumnName("at_cdate");

                entity.Property(e => e.AtClass).HasColumnName("at_class");

                entity.Property(e => e.AtCreatedBy)
                    .HasMaxLength(16)
                    .HasColumnName("at_created_by");

                entity.Property(e => e.AtCreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("at_created_date");

                entity.Property(e => e.AtCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("at_ctime");

                entity.Property(e => e.AtDate1)
                    .HasColumnType("date")
                    .HasColumnName("at_date_1");

                entity.Property(e => e.AtDate2)
                    .HasColumnType("date")
                    .HasColumnName("at_date_2");

                entity.Property(e => e.AtDate3)
                    .HasColumnType("date")
                    .HasColumnName("at_date_3");

                entity.Property(e => e.AtDescription)
                    .HasMaxLength(256)
                    .HasColumnName("at_description");

                entity.Property(e => e.AtDetail1)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_1");

                entity.Property(e => e.AtDetail10)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_10");

                entity.Property(e => e.AtDetail11)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_11");

                entity.Property(e => e.AtDetail12)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_12");

                entity.Property(e => e.AtDetail13)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_13");

                entity.Property(e => e.AtDetail14)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_14");

                entity.Property(e => e.AtDetail15)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_15");

                entity.Property(e => e.AtDetail16)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_16");

                entity.Property(e => e.AtDetail2)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_2");

                entity.Property(e => e.AtDetail3)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_3");

                entity.Property(e => e.AtDetail4)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_4");

                entity.Property(e => e.AtDetail5)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_5");

                entity.Property(e => e.AtDetail6)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_6");

                entity.Property(e => e.AtDetail7)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_7");

                entity.Property(e => e.AtDetail8)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_8");

                entity.Property(e => e.AtDetail9)
                    .HasMaxLength(128)
                    .HasColumnName("at_detail_9");

                entity.Property(e => e.AtFactor).HasColumnName("at_factor");

                entity.Property(e => e.AtFile)
                    .HasMaxLength(264)
                    .HasColumnName("at_file");

                entity.Property(e => e.AtMby)
                    .HasMaxLength(16)
                    .HasColumnName("at_mby");

                entity.Property(e => e.AtMdate)
                    .HasColumnType("date")
                    .HasColumnName("at_mdate");

                entity.Property(e => e.AtModifiedBy)
                    .HasMaxLength(16)
                    .HasColumnName("at_modified_by");

                entity.Property(e => e.AtModifiedDate)
                    .HasColumnType("date")
                    .HasColumnName("at_modified_date");

                entity.Property(e => e.AtMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("at_mtime");

                entity.Property(e => e.AtRowidDebtor).HasColumnName("at_rowid_debtor");

                entity.Property(e => e.AtSeqDebtor).HasColumnName("at_seq_debtor");

                entity.Property(e => e.AtTotalCredits)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("at_total_credits");

                entity.Property(e => e.AtTotalDebits)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("at_total_debits");

                entity.Property(e => e.AtTotalResult)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("at_total_result");

                entity.Property(e => e.AtType).HasColumnName("at_type");

                entity.Property(e => e.AtUid).HasColumnName("at_uid");

                entity.Property(e => e.AtUidm).HasColumnName("at_uidm");

                entity.Property(e => e.AtUido).HasColumnName("at_uido");

                entity.Property(e => e.AtValue).HasColumnName("at_value");

                entity.HasOne(d => d.AtBlobNavigation)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.AtBlob)
                    .HasConstraintName("FK__attachmen__at_bl__5629CD9C");

                entity.HasOne(d => d.AtRowidDebtorNavigation)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.AtRowidDebtor)
                    .HasConstraintName("FK__attachmen__at_ro__5535A963");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.BkRowid)
                    .HasName("PK__bank__8EA6D3626D000F1F");

                entity.ToTable("bank");

                entity.HasIndex(e => e.BkCategory, "bk_category_key");

                entity.HasIndex(e => e.BkRoutingNo, "bk_routing_no_key");

                entity.HasIndex(e => e.BkRowidAccount, "bk_rowid_account_key");

                entity.Property(e => e.BkRowid).HasColumnName("bk_rowid");

                entity.Property(e => e.BkAccess)
                    .HasMaxLength(16)
                    .HasColumnName("bk_access");

                entity.Property(e => e.BkAddress)
                    .HasMaxLength(164)
                    .HasColumnName("bk_address");

                entity.Property(e => e.BkAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("bk_address_1");

                entity.Property(e => e.BkAddressCity)
                    .HasMaxLength(64)
                    .HasColumnName("bk_address_city");

                entity.Property(e => e.BkAddressCountry)
                    .HasMaxLength(64)
                    .HasColumnName("bk_address_country");

                entity.Property(e => e.BkAddressFlags).HasColumnName("bk_address_flags");

                entity.Property(e => e.BkAddressState)
                    .HasMaxLength(64)
                    .HasColumnName("bk_address_state");

                entity.Property(e => e.BkAddressStreetNo)
                    .HasMaxLength(48)
                    .HasColumnName("bk_address_street_no");

                entity.Property(e => e.BkAddressZip)
                    .HasMaxLength(48)
                    .HasColumnName("bk_address_zip");

                entity.Property(e => e.BkBank)
                    .HasMaxLength(256)
                    .HasColumnName("bk_bank");

                entity.Property(e => e.BkBranch)
                    .HasMaxLength(160)
                    .HasColumnName("bk_branch");

                entity.Property(e => e.BkCategory).HasColumnName("bk_category");

                entity.Property(e => e.BkCategory1).HasColumnName("bk_category_1");

                entity.Property(e => e.BkCategory2).HasColumnName("bk_category_2");

                entity.Property(e => e.BkCby)
                    .HasMaxLength(16)
                    .HasColumnName("bk_cby");

                entity.Property(e => e.BkCdate)
                    .HasColumnType("date")
                    .HasColumnName("bk_cdate");

                entity.Property(e => e.BkClerk)
                    .HasMaxLength(16)
                    .HasColumnName("bk_clerk");

                entity.Property(e => e.BkCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("bk_ctime");

                entity.Property(e => e.BkDate1)
                    .HasColumnType("date")
                    .HasColumnName("bk_date_1");

                entity.Property(e => e.BkDate2)
                    .HasColumnType("date")
                    .HasColumnName("bk_date_2");

                entity.Property(e => e.BkFax)
                    .HasMaxLength(48)
                    .HasColumnName("bk_fax");

                entity.Property(e => e.BkFaxExtension)
                    .HasMaxLength(16)
                    .HasColumnName("bk_fax_extension");

                entity.Property(e => e.BkFlags1).HasColumnName("bk_flags_1");

                entity.Property(e => e.BkFlags2).HasColumnName("bk_flags_2");

                entity.Property(e => e.BkMby)
                    .HasMaxLength(16)
                    .HasColumnName("bk_mby");

                entity.Property(e => e.BkMdate)
                    .HasColumnType("date")
                    .HasColumnName("bk_mdate");

                entity.Property(e => e.BkMoney1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bk_money_1");

                entity.Property(e => e.BkMoney2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bk_money_2");

                entity.Property(e => e.BkMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("bk_mtime");

                entity.Property(e => e.BkNumber1).HasColumnName("bk_number_1");

                entity.Property(e => e.BkNumber2).HasColumnName("bk_number_2");

                entity.Property(e => e.BkOp1)
                    .HasMaxLength(16)
                    .HasColumnName("bk_op_1");

                entity.Property(e => e.BkOp2)
                    .HasMaxLength(16)
                    .HasColumnName("bk_op_2");

                entity.Property(e => e.BkOther)
                    .HasMaxLength(48)
                    .HasColumnName("bk_other");

                entity.Property(e => e.BkOtherExtension)
                    .HasMaxLength(16)
                    .HasColumnName("bk_other_extension");

                entity.Property(e => e.BkPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bk_percent_1");

                entity.Property(e => e.BkPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bk_percent_2");

                entity.Property(e => e.BkPhone)
                    .HasMaxLength(48)
                    .HasColumnName("bk_phone");

                entity.Property(e => e.BkPhoneExtension)
                    .HasMaxLength(16)
                    .HasColumnName("bk_phone_extension");

                entity.Property(e => e.BkRoutingNo)
                    .HasMaxLength(64)
                    .HasColumnName("bk_routing_no");

                entity.Property(e => e.BkRowidAccount).HasColumnName("bk_rowid_account");

                entity.Property(e => e.BkTimezone).HasColumnName("bk_timezone");

                entity.Property(e => e.BkUid).HasColumnName("bk_uid");

                entity.Property(e => e.BkUidm).HasColumnName("bk_uidm");

                entity.Property(e => e.BkUido).HasColumnName("bk_uido");

                entity.Property(e => e.BkUser1)
                    .HasMaxLength(128)
                    .HasColumnName("bk_user_1");

                entity.Property(e => e.BkUser2)
                    .HasMaxLength(128)
                    .HasColumnName("bk_user_2");

                entity.Property(e => e.BkUser3)
                    .HasMaxLength(128)
                    .HasColumnName("bk_user_3");

                entity.Property(e => e.BkUser4)
                    .HasMaxLength(128)
                    .HasColumnName("bk_user_4");

                entity.HasOne(d => d.BkRowidAccountNavigation)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.BkRowidAccount)
                    .HasConstraintName("FK__bank__bk_rowid_a__38996AB5");
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.HasKey(e => e.BkaccRowid)
                    .HasName("PK__bank_acc__37A99D437599D143");

                entity.ToTable("bank_account");

                entity.HasIndex(e => e.BkaccCategory, "bkacc_category_key");

                entity.HasIndex(e => e.BkaccRowidAssociated, "bkacc_rowid_associated_key");

                entity.HasIndex(e => e.BkaccRowidClient, "bkacc_rowid_client_key");

                entity.HasIndex(e => e.BkaccRowidCosigner, "bkacc_rowid_cosigner_key");

                entity.HasIndex(e => e.BkaccRowidDebtor, "bkacc_rowid_debtor_key");

                entity.Property(e => e.BkaccRowid).HasColumnName("bkacc_rowid");

                entity.Property(e => e.BkaccAccount)
                    .HasMaxLength(160)
                    .HasColumnName("bkacc_account");

                entity.Property(e => e.BkaccBankRoutingNo)
                    .HasMaxLength(64)
                    .HasColumnName("bkacc_bank_routing_no");

                entity.Property(e => e.BkaccCategory).HasColumnName("bkacc_category");

                entity.Property(e => e.BkaccCategory1).HasColumnName("bkacc_category_1");

                entity.Property(e => e.BkaccCategory2).HasColumnName("bkacc_category_2");

                entity.Property(e => e.BkaccCby)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_cby");

                entity.Property(e => e.BkaccCdate)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_cdate");

                entity.Property(e => e.BkaccCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("bkacc_ctime");

                entity.Property(e => e.BkaccCurrency).HasColumnName("bkacc_currency");

                entity.Property(e => e.BkaccDate1)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_date_1");

                entity.Property(e => e.BkaccDate2)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_date_2");

                entity.Property(e => e.BkaccExpDate)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_exp_date");

                entity.Property(e => e.BkaccFlags1).HasColumnName("bkacc_flags_1");

                entity.Property(e => e.BkaccFlags2).HasColumnName("bkacc_flags_2");

                entity.Property(e => e.BkaccId)
                    .HasMaxLength(20)
                    .HasColumnName("bkacc_id");

                entity.Property(e => e.BkaccMby)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_mby");

                entity.Property(e => e.BkaccMdate)
                    .HasColumnType("date")
                    .HasColumnName("bkacc_mdate");

                entity.Property(e => e.BkaccMoney1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bkacc_money_1");

                entity.Property(e => e.BkaccMoney2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bkacc_money_2");

                entity.Property(e => e.BkaccMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("bkacc_mtime");

                entity.Property(e => e.BkaccNameOnAccount)
                    .HasMaxLength(164)
                    .HasColumnName("bkacc_name_on_account");

                entity.Property(e => e.BkaccNumber1).HasColumnName("bkacc_number_1");

                entity.Property(e => e.BkaccNumber2).HasColumnName("bkacc_number_2");

                entity.Property(e => e.BkaccOp1)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_op_1");

                entity.Property(e => e.BkaccOp2)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_op_2");

                entity.Property(e => e.BkaccPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bkacc_percent_1");

                entity.Property(e => e.BkaccPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("bkacc_percent_2");

                entity.Property(e => e.BkaccPin)
                    .HasMaxLength(16)
                    .HasColumnName("bkacc_pin");

                entity.Property(e => e.BkaccRowidAssociated).HasColumnName("bkacc_rowid_associated");

                entity.Property(e => e.BkaccRowidClient).HasColumnName("bkacc_rowid_client");

                entity.Property(e => e.BkaccRowidCosigner).HasColumnName("bkacc_rowid_cosigner");

                entity.Property(e => e.BkaccRowidDebtor).HasColumnName("bkacc_rowid_debtor");

                entity.Property(e => e.BkaccUid).HasColumnName("bkacc_uid");

                entity.Property(e => e.BkaccUidm).HasColumnName("bkacc_uidm");

                entity.Property(e => e.BkaccUido).HasColumnName("bkacc_uido");

                entity.Property(e => e.BkaccUido1).HasColumnName("bkacc_uido_1");

                entity.Property(e => e.BkaccUido2).HasColumnName("bkacc_uido_2");

                entity.Property(e => e.BkaccUido3).HasColumnName("bkacc_uido_3");

                entity.Property(e => e.BkaccUser1)
                    .HasMaxLength(128)
                    .HasColumnName("bkacc_user_1");

                entity.Property(e => e.BkaccUser2)
                    .HasMaxLength(128)
                    .HasColumnName("bkacc_user_2");

                entity.Property(e => e.BkaccUser3)
                    .HasMaxLength(128)
                    .HasColumnName("bkacc_user_3");

                entity.Property(e => e.BkaccUser4)
                    .HasMaxLength(128)
                    .HasColumnName("bkacc_user_4");

                entity.HasOne(d => d.BkaccRowidAssociatedNavigation)
                    .WithMany(p => p.BankAccounts)
                    .HasForeignKey(d => d.BkaccRowidAssociated)
                    .HasConstraintName("FK__bank_acco__bkacc__2E1BDC42");

                entity.HasOne(d => d.BkaccRowidClientNavigation)
                    .WithMany(p => p.BankAccounts)
                    .HasForeignKey(d => d.BkaccRowidClient)
                    .HasConstraintName("FK__bank_acco__bkacc__2C3393D0");

                entity.HasOne(d => d.BkaccRowidCosignerNavigation)
                    .WithMany(p => p.BankAccounts)
                    .HasForeignKey(d => d.BkaccRowidCosigner)
                    .HasConstraintName("FK__bank_acco__bkacc__2D27B809");

                entity.HasOne(d => d.BkaccRowidDebtorNavigation)
                    .WithMany(p => p.BankAccounts)
                    .HasForeignKey(d => d.BkaccRowidDebtor)
                    .HasConstraintName("FK__bank_acco__bkacc__2B3F6F97");
            });

            modelBuilder.Entity<Blob>(entity =>
            {
                entity.HasKey(e => e.BlRowid)
                    .HasName("PK__blobs__99EEB89015AA1DD5");

                entity.ToTable("blobs");

                entity.HasIndex(e => e.BlDate, "bl_date_key");

                entity.HasIndex(e => e.BlRowidAClient, "bl_rowid_a_client_key");

                entity.HasIndex(e => e.BlRowidADebtor, "bl_rowid_a_debtor_key");

                entity.HasIndex(e => e.BlRowidClient, "bl_rowid_client_key");

                entity.HasIndex(e => e.BlRowidDebtor, "bl_rowid_debtor_key");

                entity.HasIndex(e => e.BlType, "bl_type_key");

                entity.Property(e => e.BlRowid).HasColumnName("bl_rowid");

                entity.Property(e => e.BlBlob).HasColumnName("bl_blob");

                entity.Property(e => e.BlDate)
                    .HasColumnType("date")
                    .HasColumnName("bl_date");

                entity.Property(e => e.BlOpid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("bl_opid");

                entity.Property(e => e.BlRowidAClient).HasColumnName("bl_rowid_a_client");

                entity.Property(e => e.BlRowidADebtor).HasColumnName("bl_rowid_a_debtor");

                entity.Property(e => e.BlRowidClient).HasColumnName("bl_rowid_client");

                entity.Property(e => e.BlRowidDebtor).HasColumnName("bl_rowid_debtor");

                entity.Property(e => e.BlStatus)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("bl_status");

                entity.Property(e => e.BlSticky).HasColumnName("bl_sticky");

                entity.Property(e => e.BlText)
                    .IsUnicode(false)
                    .HasColumnName("bl_text");

                entity.Property(e => e.BlTime)
                    .HasColumnType("time(3)")
                    .HasColumnName("bl_time");

                entity.Property(e => e.BlType).HasColumnName("bl_type");

                entity.HasOne(d => d.BlRowidAClientNavigation)
                    .WithMany(p => p.Blobs)
                    .HasForeignKey(d => d.BlRowidAClient)
                    .HasConstraintName("FK__blobs__bl_rowid___11158940");

                entity.HasOne(d => d.BlRowidADebtorNavigation)
                    .WithMany(p => p.Blobs)
                    .HasForeignKey(d => d.BlRowidADebtor)
                    .HasConstraintName("FK__blobs__bl_rowid___0F2D40CE");

                entity.HasOne(d => d.BlRowidClientNavigation)
                    .WithMany(p => p.Blobs)
                    .HasForeignKey(d => d.BlRowidClient)
                    .HasConstraintName("FK__blobs__bl_rowid___10216507");

                entity.HasOne(d => d.BlRowidDebtorNavigation)
                    .WithMany(p => p.Blobs)
                    .HasForeignKey(d => d.BlRowidDebtor)
                    .HasConstraintName("FK__blobs__bl_rowid___0E391C95");
            });

            modelBuilder.Entity<CatContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__cat_cont__91C3A18C4DF87D6F");

                entity.ToTable("cat_contact");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidClAttachment).HasColumnName("co_rowid_cl_attachment");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.CatContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__cat_conta__co_at__6D0D32F4");

                entity.HasOne(d => d.CoRowidClAttachmentNavigation)
                    .WithMany(p => p.CatContacts)
                    .HasForeignKey(d => d.CoRowidClAttachment)
                    .HasConstraintName("FK__cat_conta__co_ro__6C190EBB");
            });

            modelBuilder.Entity<ClAttachment>(entity =>
            {
                entity.HasKey(e => e.ClAtRowid)
                    .HasName("PK__cl_attac__CFA34B4586B420B8");

                entity.ToTable("cl_attachment");

                entity.HasIndex(e => e.ClAtBlob, "cl_at_blob_key");

                entity.HasIndex(e => e.ClAtDate1, "cl_at_date_1_key");

                entity.HasIndex(e => e.ClAtDate2, "cl_at_date_2_key");

                entity.HasIndex(e => e.ClAtDetail1, "cl_at_detail_1_key");

                entity.HasIndex(e => e.ClAtDetail2, "cl_at_detail_2_key");

                entity.HasIndex(e => e.ClAtRowidClient, "cl_at_rowid_client_key");

                entity.Property(e => e.ClAtRowid).HasColumnName("cl_at_rowid");

                entity.Property(e => e.ClAtBlob).HasColumnName("cl_at_blob");

                entity.Property(e => e.ClAtCategory).HasColumnName("cl_at_category");

                entity.Property(e => e.ClAtCategory1).HasColumnName("cl_at_category_1");

                entity.Property(e => e.ClAtCategory2).HasColumnName("cl_at_category_2");

                entity.Property(e => e.ClAtCby)
                    .HasMaxLength(16)
                    .HasColumnName("cl_at_cby");

                entity.Property(e => e.ClAtCdate)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_cdate");

                entity.Property(e => e.ClAtClass).HasColumnName("cl_at_class");

                entity.Property(e => e.ClAtCreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_created_date");

                entity.Property(e => e.ClAtCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cl_at_ctime");

                entity.Property(e => e.ClAtDate1)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_date_1");

                entity.Property(e => e.ClAtDate2)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_date_2");

                entity.Property(e => e.ClAtDate3)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_date_3");

                entity.Property(e => e.ClAtDescription)
                    .HasMaxLength(256)
                    .HasColumnName("cl_at_description");

                entity.Property(e => e.ClAtDetail1)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_1");

                entity.Property(e => e.ClAtDetail10)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_10");

                entity.Property(e => e.ClAtDetail11)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_11");

                entity.Property(e => e.ClAtDetail12)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_12");

                entity.Property(e => e.ClAtDetail13)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_13");

                entity.Property(e => e.ClAtDetail14)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_14");

                entity.Property(e => e.ClAtDetail15)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_15");

                entity.Property(e => e.ClAtDetail16)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_16");

                entity.Property(e => e.ClAtDetail2)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_2");

                entity.Property(e => e.ClAtDetail3)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_3");

                entity.Property(e => e.ClAtDetail4)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_4");

                entity.Property(e => e.ClAtDetail5)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_5");

                entity.Property(e => e.ClAtDetail6)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_6");

                entity.Property(e => e.ClAtDetail7)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_7");

                entity.Property(e => e.ClAtDetail8)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_8");

                entity.Property(e => e.ClAtDetail9)
                    .HasMaxLength(128)
                    .HasColumnName("cl_at_detail_9");

                entity.Property(e => e.ClAtFactor).HasColumnName("cl_at_factor");

                entity.Property(e => e.ClAtFile)
                    .HasMaxLength(264)
                    .HasColumnName("cl_at_file");

                entity.Property(e => e.ClAtMby)
                    .HasMaxLength(16)
                    .HasColumnName("cl_at_mby");

                entity.Property(e => e.ClAtMdate)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_mdate");

                entity.Property(e => e.ClAtModifiedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_at_modified_date");

                entity.Property(e => e.ClAtMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cl_at_mtime");

                entity.Property(e => e.ClAtRowidClient).HasColumnName("cl_at_rowid_client");

                entity.Property(e => e.ClAtTotalDebits)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_at_total_debits");

                entity.Property(e => e.ClAtTotalResult)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_at_total_result");

                entity.Property(e => e.ClAtType).HasColumnName("cl_at_type");

                entity.Property(e => e.ClAtUid).HasColumnName("cl_at_uid");

                entity.Property(e => e.ClAtUidm).HasColumnName("cl_at_uidm");

                entity.Property(e => e.ClAtUido).HasColumnName("cl_at_uido");

                entity.Property(e => e.ClAtValue).HasColumnName("cl_at_value");

                entity.Property(e => e.ClTotalCredits)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_total_credits");

                entity.HasOne(d => d.ClAtBlobNavigation)
                    .WithMany(p => p.ClAttachments)
                    .HasForeignKey(d => d.ClAtBlob)
                    .HasConstraintName("FK__cl_attach__cl_at__656C112C");

                entity.HasOne(d => d.ClAtRowidClientNavigation)
                    .WithMany(p => p.ClAttachments)
                    .HasForeignKey(d => d.ClAtRowidClient)
                    .HasConstraintName("FK__cl_attach__cl_at__6477ECF3");
            });

            modelBuilder.Entity<ClContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__cl_conta__91C3A18C2FFD9B0D");

                entity.ToTable("cl_contact");

                entity.HasIndex(e => e.CoAttachmentBlob, "co_attachment_blob_key");

                entity.HasIndex(e => e.CoCategory1, "co_category_1_key");

                entity.HasIndex(e => e.CoCategory, "co_category_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoType, e.CoDate }, "co_completedtypedate_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoWho, e.CoDate }, "co_completedwhodate_key");

                entity.HasIndex(e => e.CoDate, "co_date_key");

                entity.HasIndex(e => e.CoDoneDate, "co_done_date_key");

                entity.HasIndex(e => new { e.CoOriginator, e.CoCreationDate }, "co_originatordate_key");

                entity.HasIndex(e => e.CoRowidClient, "co_rowid_client_key");

                entity.HasIndex(e => new { e.CoType, e.CoCompleted, e.CoWho, e.CoDate }, "co_typecompletedwhodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoDoneDate }, "co_whodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoType, e.CoDate }, "co_whotypedate_key");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidClient).HasColumnName("co_rowid_client");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.ClContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__cl_contac__co_at__74AE54BC");

                entity.HasOne(d => d.CoRowidClientNavigation)
                    .WithMany(p => p.ClContacts)
                    .HasForeignKey(d => d.CoRowidClient)
                    .HasConstraintName("FK__cl_contac__co_ro__73BA3083");
            });

            modelBuilder.Entity<ClTransaction>(entity =>
            {
                entity.HasKey(e => e.TrRowid)
                    .HasName("PK__cl_trans__C5AB8E927B5E749E");

                entity.ToTable("cl_transaction");

                entity.HasIndex(e => e.TrBlob, "tr_blob_key");

                entity.HasIndex(e => e.TrCategory1, "tr_category_1_key");

                entity.HasIndex(e => e.TrCategory2, "tr_category_2_key");

                entity.HasIndex(e => e.TrCategory, "tr_category_key");

                entity.HasIndex(e => e.TrPostedDate, "tr_posted_date_key");

                entity.HasIndex(e => e.TrRowidClient, "tr_rowid_client_key");

                entity.Property(e => e.TrRowid).HasColumnName("tr_rowid");

                entity.Property(e => e.TrAccount).HasColumnName("tr_account");

                entity.Property(e => e.TrActual)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_actual");

                entity.Property(e => e.TrAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_adjustment");

                entity.Property(e => e.TrAgencyAcctCurrency).HasColumnName("tr_agency_acct_currency");

                entity.Property(e => e.TrAgencyExchangeAmt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_agency_exchange_amt");

                entity.Property(e => e.TrAgencyExchangeRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_agency_exchange_rate");

                entity.Property(e => e.TrAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("tr_attachment");

                entity.Property(e => e.TrBlob).HasColumnName("tr_blob");

                entity.Property(e => e.TrBucket10)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_10");

                entity.Property(e => e.TrBucket11)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_11");

                entity.Property(e => e.TrBucket12)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_12");

                entity.Property(e => e.TrBucket13)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_13");

                entity.Property(e => e.TrBucket14)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_14");

                entity.Property(e => e.TrBucket15)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_15");

                entity.Property(e => e.TrBucket16)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_16");

                entity.Property(e => e.TrBucket5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_5");

                entity.Property(e => e.TrBucket6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_6");

                entity.Property(e => e.TrBucket7)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_7");

                entity.Property(e => e.TrBucket8)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_8");

                entity.Property(e => e.TrBucket9)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_9");

                entity.Property(e => e.TrCategory).HasColumnName("tr_category");

                entity.Property(e => e.TrCategory1).HasColumnName("tr_category_1");

                entity.Property(e => e.TrCategory2).HasColumnName("tr_category_2");

                entity.Property(e => e.TrCby)
                    .HasMaxLength(16)
                    .HasColumnName("tr_cby");

                entity.Property(e => e.TrCdate)
                    .HasColumnType("date")
                    .HasColumnName("tr_cdate");

                entity.Property(e => e.TrCommFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_fees");

                entity.Property(e => e.TrCommInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_interest");

                entity.Property(e => e.TrCommLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_legal");

                entity.Property(e => e.TrCommMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_misc");

                entity.Property(e => e.TrCommOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_other");

                entity.Property(e => e.TrCommPrinc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_princ");

                entity.Property(e => e.TrCommRateOption).HasColumnName("tr_comm_rate_option");

                entity.Property(e => e.TrCommissionAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_amount");

                entity.Property(e => e.TrCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate");

                entity.Property(e => e.TrCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_1");

                entity.Property(e => e.TrCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_2");

                entity.Property(e => e.TrCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_3");

                entity.Property(e => e.TrConfirmationDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_confirmation_date");

                entity.Property(e => e.TrConfirmationNumber)
                    .HasMaxLength(128)
                    .HasColumnName("tr_confirmation_number");

                entity.Property(e => e.TrConfirmationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_confirmation_time");

                entity.Property(e => e.TrCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_ctime");

                entity.Property(e => e.TrCurrency).HasColumnName("tr_currency");

                entity.Property(e => e.TrDate1)
                    .HasColumnType("date")
                    .HasColumnName("tr_date_1");

                entity.Property(e => e.TrDate2)
                    .HasColumnType("date")
                    .HasColumnName("tr_date_2");

                entity.Property(e => e.TrDeowingPostPayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_deowing_post_payment");

                entity.Property(e => e.TrDeowingPrePayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_deowing_pre_payment");

                entity.Property(e => e.TrDepositTo)
                    .HasMaxLength(16)
                    .HasColumnName("tr_deposit_to");

                entity.Property(e => e.TrDepositedDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_deposited_date");

                entity.Property(e => e.TrDepositedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_deposited_time");

                entity.Property(e => e.TrDescription)
                    .HasMaxLength(256)
                    .HasColumnName("tr_description");

                entity.Property(e => e.TrDisbursement)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_disbursement");

                entity.Property(e => e.TrExchangeRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_exchange_rate");

                entity.Property(e => e.TrFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_fee");

                entity.Property(e => e.TrFlags).HasColumnName("tr_flags");

                entity.Property(e => e.TrFlags1).HasColumnName("tr_flags_1");

                entity.Property(e => e.TrFlags2).HasColumnName("tr_flags_2");

                entity.Property(e => e.TrId).HasColumnName("tr_id");

                entity.Property(e => e.TrInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_interest");

                entity.Property(e => e.TrInvoiceNumber).HasColumnName("tr_invoice_number");

                entity.Property(e => e.TrLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_legal");

                entity.Property(e => e.TrMby)
                    .HasMaxLength(16)
                    .HasColumnName("tr_mby");

                entity.Property(e => e.TrMdate)
                    .HasColumnType("date")
                    .HasColumnName("tr_mdate");

                entity.Property(e => e.TrMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_misc");

                entity.Property(e => e.TrMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_mtime");

                entity.Property(e => e.TrNumber1).HasColumnName("tr_number_1");

                entity.Property(e => e.TrNumber2).HasColumnName("tr_number_2");

                entity.Property(e => e.TrOp1)
                    .HasMaxLength(16)
                    .HasColumnName("tr_op_1");

                entity.Property(e => e.TrOp2)
                    .HasMaxLength(16)
                    .HasColumnName("tr_op_2");

                entity.Property(e => e.TrOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_other");

                entity.Property(e => e.TrPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_payment_date");

                entity.Property(e => e.TrPaymentDueDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_payment_due_date");

                entity.Property(e => e.TrPaymentDueTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_payment_due_time");

                entity.Property(e => e.TrPaymentTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_payment_time");

                entity.Property(e => e.TrPaymentTypeFlag).HasColumnName("tr_payment_type_flag");

                entity.Property(e => e.TrPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_percent_1");

                entity.Property(e => e.TrPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_percent_2");

                entity.Property(e => e.TrPostedDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_posted_date");

                entity.Property(e => e.TrPostedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_posted_time");

                entity.Property(e => e.TrPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_principal");

                entity.Property(e => e.TrReceiptNumber).HasColumnName("tr_receipt_number");

                entity.Property(e => e.TrReturn)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_return");

                entity.Property(e => e.TrRowidClient).HasColumnName("tr_rowid_client");

                entity.Property(e => e.TrSales)
                    .HasMaxLength(16)
                    .HasColumnName("tr_sales");

                entity.Property(e => e.TrSwitches).HasColumnName("tr_switches");

                entity.Property(e => e.TrTaxAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_amount");

                entity.Property(e => e.TrTaxFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_fees");

                entity.Property(e => e.TrTaxInt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_int");

                entity.Property(e => e.TrTaxLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_legal");

                entity.Property(e => e.TrTaxMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_misc");

                entity.Property(e => e.TrTaxOptions).HasColumnName("tr_tax_options");

                entity.Property(e => e.TrTaxOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_other");

                entity.Property(e => e.TrTaxPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_principal");

                entity.Property(e => e.TrTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate");

                entity.Property(e => e.TrTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_1");

                entity.Property(e => e.TrTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_2");

                entity.Property(e => e.TrTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_3");

                entity.Property(e => e.TrToAgency)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_agency");

                entity.Property(e => e.TrToClient)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_client");

                entity.Property(e => e.TrToCurrency).HasColumnName("tr_to_currency");

                entity.Property(e => e.TrToCurrent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_current");

                entity.Property(e => e.TrType)
                    .HasMaxLength(20)
                    .HasColumnName("tr_type");

                entity.Property(e => e.TrUid).HasColumnName("tr_uid");

                entity.Property(e => e.TrUidm).HasColumnName("tr_uidm");

                entity.Property(e => e.TrUido).HasColumnName("tr_uido");

                entity.Property(e => e.TrUser1)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_1");

                entity.Property(e => e.TrUser2)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_2");

                entity.Property(e => e.TrUser3)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_3");

                entity.Property(e => e.TrUser4)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_4");

                entity.Property(e => e.TrUser5)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_5");

                entity.Property(e => e.TrUser6)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_6");

                entity.Property(e => e.TrUser7)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_7");

                entity.Property(e => e.TrWho)
                    .HasMaxLength(16)
                    .HasColumnName("tr_who");

                entity.Property(e => e.TrWithdrawFrom)
                    .HasMaxLength(16)
                    .HasColumnName("tr_withdraw_from");

                entity.HasOne(d => d.TrBlobNavigation)
                    .WithMany(p => p.ClTransactions)
                    .HasForeignKey(d => d.TrBlob)
                    .HasConstraintName("FK__cl_transa__tr_bl__7C4F7684");

                entity.HasOne(d => d.TrRowidClientNavigation)
                    .WithMany(p => p.ClTransactions)
                    .HasForeignKey(d => d.TrRowidClient)
                    .HasConstraintName("FK__cl_transa__tr_ro__7B5B524B");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ClRowid)
                    .HasName("PK__client__53B861160D5A1065");

                entity.ToTable("client");

                entity.HasIndex(e => e.ClAltNumber, "cl_alt_number_key");

                entity.HasIndex(e => e.ClCategory1, "cl_category_1_key");

                entity.HasIndex(e => e.ClCategory2, "cl_category_2_key");

                entity.HasIndex(e => e.ClCategory, "cl_category_key");

                entity.HasIndex(e => e.ClName, "cl_name_key");

                entity.HasIndex(e => e.ClNoteblob, "cl_noteblob_key");

                entity.HasIndex(e => e.ClNumber, "cl_number_key");

                entity.HasIndex(e => e.ClOwnedbyNumber, "cl_ownedby_number_key");

                entity.HasIndex(e => e.ClUser1, "cl_user_1_key");

                entity.Property(e => e.ClRowid).HasColumnName("cl_rowid");

                entity.Property(e => e.ClAddFlags).HasColumnName("cl_add_flags");

                entity.Property(e => e.ClAddType).HasColumnName("cl_add_type");

                entity.Property(e => e.ClAddress)
                    .HasMaxLength(160)
                    .HasColumnName("cl_address");

                entity.Property(e => e.ClAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("cl_address_1");

                entity.Property(e => e.ClAddress2)
                    .HasMaxLength(160)
                    .HasColumnName("cl_address_2");

                entity.Property(e => e.ClAdjustments)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_adjustments");

                entity.Property(e => e.ClAltContact)
                    .HasMaxLength(128)
                    .HasColumnName("cl_alt_contact");

                entity.Property(e => e.ClAltNumber)
                    .HasMaxLength(40)
                    .HasColumnName("cl_alt_number");

                entity.Property(e => e.ClAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_amount_1");

                entity.Property(e => e.ClAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_amount_2");

                entity.Property(e => e.ClArchive).HasColumnName("cl_archive");

                entity.Property(e => e.ClAttachNum).HasColumnName("cl_attach_num");

                entity.Property(e => e.ClBillingPeriod).HasColumnName("cl_billing_period");

                entity.Property(e => e.ClCategory).HasColumnName("cl_category");

                entity.Property(e => e.ClCategory1).HasColumnName("cl_category_1");

                entity.Property(e => e.ClCategory2).HasColumnName("cl_category_2");

                entity.Property(e => e.ClCby)
                    .HasMaxLength(16)
                    .HasColumnName("cl_cby");

                entity.Property(e => e.ClCdate)
                    .HasColumnType("date")
                    .HasColumnName("cl_cdate");

                entity.Property(e => e.ClCell)
                    .HasMaxLength(48)
                    .HasColumnName("cl_cell");

                entity.Property(e => e.ClCellExtension)
                    .HasMaxLength(16)
                    .HasColumnName("cl_cell_extension");

                entity.Property(e => e.ClCity)
                    .HasMaxLength(64)
                    .HasColumnName("cl_city");

                entity.Property(e => e.ClClass).HasColumnName("cl_class");

                entity.Property(e => e.ClClosed)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_closed");

                entity.Property(e => e.ClCommRateOptions).HasColumnName("cl_comm_rate_options");

                entity.Property(e => e.ClCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_commission_rate");

                entity.Property(e => e.ClCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_commission_rate_1");

                entity.Property(e => e.ClCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_commission_rate_2");

                entity.Property(e => e.ClCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_commission_rate_3");

                entity.Property(e => e.ClCompClDebtorThresh).HasColumnName("cl_comp_cl_debtor_thresh");

                entity.Property(e => e.ClCompClNumber).HasColumnName("cl_comp_cl_number");

                entity.Property(e => e.ClCompFlags).HasColumnName("cl_comp_flags");

                entity.Property(e => e.ClCompFlags2).HasColumnName("cl_comp_flags2");

                entity.Property(e => e.ClCompGst)
                    .HasMaxLength(124)
                    .HasColumnName("cl_comp_gst");

                entity.Property(e => e.ClContact)
                    .HasMaxLength(128)
                    .HasColumnName("cl_contact");

                entity.Property(e => e.ClContactPlan)
                    .HasMaxLength(16)
                    .HasColumnName("cl_contact_plan");

                entity.Property(e => e.ClCountry)
                    .HasMaxLength(64)
                    .HasColumnName("cl_country");

                entity.Property(e => e.ClCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cl_ctime");

                entity.Property(e => e.ClCurrency).HasColumnName("cl_currency");

                entity.Property(e => e.ClDate1)
                    .HasColumnType("date")
                    .HasColumnName("cl_date_1");

                entity.Property(e => e.ClDate2)
                    .HasColumnType("date")
                    .HasColumnName("cl_date_2");

                entity.Property(e => e.ClDoBusinessAs)
                    .HasMaxLength(128)
                    .HasColumnName("cl_do_business_as");

                entity.Property(e => e.ClEmail)
                    .HasMaxLength(160)
                    .HasColumnName("cl_email");

                entity.Property(e => e.ClEmailNum).HasColumnName("cl_email_num");

                entity.Property(e => e.ClFax)
                    .HasMaxLength(48)
                    .HasColumnName("cl_fax");

                entity.Property(e => e.ClFaxExtension)
                    .HasMaxLength(16)
                    .HasColumnName("cl_fax_extension");

                entity.Property(e => e.ClFeeDisbursement).HasColumnName("cl_fee_disbursement");

                entity.Property(e => e.ClFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_fees");

                entity.Property(e => e.ClFixFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_fix_fee");

                entity.Property(e => e.ClFlags).HasColumnName("cl_flags");

                entity.Property(e => e.ClFlags1).HasColumnName("cl_flags_1");

                entity.Property(e => e.ClFlags2).HasColumnName("cl_flags_2");

                entity.Property(e => e.ClInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_interest");

                entity.Property(e => e.ClInterestFlags1).HasColumnName("cl_interest_flags1");

                entity.Property(e => e.ClInterestFlags2).HasColumnName("cl_interest_flags2");

                entity.Property(e => e.ClInterestFlags3).HasColumnName("cl_interest_flags3");

                entity.Property(e => e.ClInterestRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_interest_rate");

                entity.Property(e => e.ClInvoiceCode).HasColumnName("cl_invoice_code");

                entity.Property(e => e.ClJudgement)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_judgement");

                entity.Property(e => e.ClLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_legal");

                entity.Property(e => e.ClLetterNum).HasColumnName("cl_letter_num");

                entity.Property(e => e.ClListed)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_listed");

                entity.Property(e => e.ClListedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_listed_date");

                entity.Property(e => e.ClMby)
                    .HasMaxLength(16)
                    .HasColumnName("cl_mby");

                entity.Property(e => e.ClMdate)
                    .HasColumnType("date")
                    .HasColumnName("cl_mdate");

                entity.Property(e => e.ClMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_misc");

                entity.Property(e => e.ClMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cl_mtime");

                entity.Property(e => e.ClName)
                    .HasMaxLength(128)
                    .HasColumnName("cl_name");

                entity.Property(e => e.ClNoteblob).HasColumnName("cl_noteblob");

                entity.Property(e => e.ClNumOfActiveAccounts).HasColumnName("cl_num_of_active_accounts");

                entity.Property(e => e.ClNumOfClosedAccounts).HasColumnName("cl_num_of_closed_accounts");

                entity.Property(e => e.ClNumOfOtherAccounts).HasColumnName("cl_num_of_other_accounts");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.ClNumber1).HasColumnName("cl_number_1");

                entity.Property(e => e.ClNumber2).HasColumnName("cl_number_2");

                entity.Property(e => e.ClNumberOfAccounts).HasColumnName("cl_number_of_accounts");

                entity.Property(e => e.ClOp1)
                    .HasMaxLength(16)
                    .HasColumnName("cl_op_1");

                entity.Property(e => e.ClOp2)
                    .HasMaxLength(16)
                    .HasColumnName("cl_op_2");

                entity.Property(e => e.ClOperator)
                    .HasMaxLength(16)
                    .HasColumnName("cl_operator");

                entity.Property(e => e.ClOther)
                    .HasMaxLength(48)
                    .HasColumnName("cl_other");

                entity.Property(e => e.ClOtherExtension)
                    .HasMaxLength(16)
                    .HasColumnName("cl_other_extension");

                entity.Property(e => e.ClOtherFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_other_fee");

                entity.Property(e => e.ClOwing)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_owing");

                entity.Property(e => e.ClOwnedbyNumber).HasColumnName("cl_ownedby_number");

                entity.Property(e => e.ClPaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_paid");

                entity.Property(e => e.ClPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_percent_1");

                entity.Property(e => e.ClPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_percent_2");

                entity.Property(e => e.ClPhone)
                    .HasMaxLength(48)
                    .HasColumnName("cl_phone");

                entity.Property(e => e.ClPhoneExtension)
                    .HasMaxLength(16)
                    .HasColumnName("cl_phone_extension");

                entity.Property(e => e.ClPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_principal");

                entity.Property(e => e.ClRatePlan)
                    .HasMaxLength(16)
                    .HasColumnName("cl_rate_plan");

                entity.Property(e => e.ClReportAcknowledgement)
                    .HasMaxLength(160)
                    .HasColumnName("cl_report_acknowledgement");

                entity.Property(e => e.ClReportExtra)
                    .HasMaxLength(160)
                    .HasColumnName("cl_report_extra");

                entity.Property(e => e.ClReportListings)
                    .HasMaxLength(160)
                    .HasColumnName("cl_report_listings");

                entity.Property(e => e.ClReportStatements)
                    .HasMaxLength(160)
                    .HasColumnName("cl_report_statements");

                entity.Property(e => e.ClSales)
                    .HasMaxLength(16)
                    .HasColumnName("cl_sales");

                entity.Property(e => e.ClState)
                    .HasMaxLength(64)
                    .HasColumnName("cl_state");

                entity.Property(e => e.ClStatementCurrency).HasColumnName("cl_statement_currency");

                entity.Property(e => e.ClStreetNo)
                    .HasMaxLength(48)
                    .HasColumnName("cl_street_no");

                entity.Property(e => e.ClSuccessCalc).HasColumnName("cl_success_calc");

                entity.Property(e => e.ClSuccessEquation)
                    .HasMaxLength(256)
                    .HasColumnName("cl_success_equation");

                entity.Property(e => e.ClSuccessRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_success_rate");

                entity.Property(e => e.ClTaxDisbursement).HasColumnName("cl_tax_disbursement");

                entity.Property(e => e.ClTaxExempt).HasColumnName("cl_tax_exempt");

                entity.Property(e => e.ClTaxOptions).HasColumnName("cl_tax_options");

                entity.Property(e => e.ClTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_tax_rate");

                entity.Property(e => e.ClTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_tax_rate_1");

                entity.Property(e => e.ClTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_tax_rate_2");

                entity.Property(e => e.ClTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cl_tax_rate_3");

                entity.Property(e => e.ClTimezone).HasColumnName("cl_timezone");

                entity.Property(e => e.ClType).HasColumnName("cl_type");

                entity.Property(e => e.ClUid).HasColumnName("cl_uid");

                entity.Property(e => e.ClUidm).HasColumnName("cl_uidm");

                entity.Property(e => e.ClUser1)
                    .HasMaxLength(128)
                    .HasColumnName("cl_user_1");

                entity.Property(e => e.ClUser2)
                    .HasMaxLength(128)
                    .HasColumnName("cl_user_2");

                entity.Property(e => e.ClUser3)
                    .HasMaxLength(128)
                    .HasColumnName("cl_user_3");

                entity.Property(e => e.ClUser4)
                    .HasMaxLength(128)
                    .HasColumnName("cl_user_4");

                entity.Property(e => e.ClWorkedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_worked_date");

                entity.Property(e => e.ClZip)
                    .HasMaxLength(48)
                    .HasColumnName("cl_zip");

                entity.Property(e => e.CpPrecollectDelay).HasColumnName("cp_precollect_delay");

                entity.HasOne(d => d.ClNoteblobNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ClNoteblob)
                    .HasConstraintName("FK__client__cl_noteb__1273C1CD");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__contact__91C3A18C65E6D1D1");

                entity.ToTable("contact");

                entity.HasIndex(e => e.CoAttachmentBlob, "co_attachment_blob_key");

                entity.HasIndex(e => e.CoCategory1, "co_category_1_key");

                entity.HasIndex(e => e.CoCategory, "co_category_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoType, e.CoDate }, "co_completedtypedate_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoWho, e.CoDate }, "co_completedwhodate_key");

                entity.HasIndex(e => e.CoDate, "co_date_key");

                entity.HasIndex(e => e.CoDoneDate, "co_done_date_key");

                entity.HasIndex(e => new { e.CoOriginator, e.CoCreationDate }, "co_originatordate_key");

                entity.HasIndex(e => e.CoRowidDebtor, "co_rowid_debtor_key");

                entity.HasIndex(e => new { e.CoType, e.CoCompleted, e.CoWho, e.CoDate }, "co_typecompletedwhodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoDoneDate }, "co_whodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoType, e.CoDate }, "co_whotypedate_key");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidDebtor).HasColumnName("co_rowid_debtor");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__contact__co_atta__03F0984C");

                entity.HasOne(d => d.CoRowidDebtorNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CoRowidDebtor)
                    .HasConstraintName("FK__contact__co_rowi__02FC7413");
            });

            modelBuilder.Entity<ContactEvent>(entity =>
            {
                entity.HasKey(e => e.CeRowid)
                    .HasName("PK__contact___64ABA97DAC1E6784");

                entity.ToTable("contact_event");

                entity.HasIndex(e => e.CeRowidContactPlan, "ce_rowid_contact_plan_key");

                entity.Property(e => e.CeRowid).HasColumnName("ce_rowid");

                entity.Property(e => e.CeAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ce_amount");

                entity.Property(e => e.CeAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("ce_attachment");

                entity.Property(e => e.CeCby)
                    .HasMaxLength(16)
                    .HasColumnName("ce_cby");

                entity.Property(e => e.CeCdate)
                    .HasColumnType("date")
                    .HasColumnName("ce_cdate");

                entity.Property(e => e.CeCompare)
                    .HasMaxLength(12)
                    .HasColumnName("ce_compare");

                entity.Property(e => e.CeCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ce_ctime");

                entity.Property(e => e.CeCustomRepeat).HasColumnName("ce_custom_repeat");

                entity.Property(e => e.CeDateFlag).HasColumnName("ce_date_flag");

                entity.Property(e => e.CeDelay).HasColumnName("ce_delay");

                entity.Property(e => e.CeDescription)
                    .HasMaxLength(160)
                    .HasColumnName("ce_description");

                entity.Property(e => e.CeDummy).HasColumnName("ce_dummy");

                entity.Property(e => e.CeEstimatedDays).HasColumnName("ce_estimated_days");

                entity.Property(e => e.CeEstimatedTime).HasColumnName("ce_estimated_time");

                entity.Property(e => e.CeFlags).HasColumnName("ce_flags");

                entity.Property(e => e.CeHolidaySwitch).HasColumnName("ce_holiday_switch");

                entity.Property(e => e.CeIf)
                    .HasMaxLength(32)
                    .HasColumnName("ce_if");

                entity.Property(e => e.CeMby)
                    .HasMaxLength(16)
                    .HasColumnName("ce_mby");

                entity.Property(e => e.CeMdate)
                    .HasColumnType("date")
                    .HasColumnName("ce_mdate");

                entity.Property(e => e.CeMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ce_mtime");

                entity.Property(e => e.CeOperatorFlag).HasColumnName("ce_operator_flag");

                entity.Property(e => e.CePriority).HasColumnName("ce_priority");

                entity.Property(e => e.CeRepeat).HasColumnName("ce_repeat");

                entity.Property(e => e.CeRowidContactPlan).HasColumnName("ce_rowid_contact_plan");

                entity.Property(e => e.CeSeqContactPlan).HasColumnName("ce_seq_contact_plan");

                entity.Property(e => e.CeSetProcessStep).HasColumnName("ce_set_process_step");

                entity.Property(e => e.CeTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ce_time");

                entity.Property(e => e.CeTimeFlag).HasColumnName("ce_time_flag");

                entity.Property(e => e.CeTransactionType)
                    .HasMaxLength(20)
                    .HasColumnName("ce_transaction_type");

                entity.Property(e => e.CeType).HasColumnName("ce_type");

                entity.Property(e => e.CeUid).HasColumnName("ce_uid");

                entity.Property(e => e.CeUidm).HasColumnName("ce_uidm");

                entity.Property(e => e.CeUido).HasColumnName("ce_uido");

                entity.Property(e => e.CeValue)
                    .HasMaxLength(48)
                    .HasColumnName("ce_value");

                entity.Property(e => e.CeValue2)
                    .HasMaxLength(48)
                    .HasColumnName("ce_value2");

                entity.Property(e => e.CeWarningTime).HasColumnName("ce_warning_time");

                entity.Property(e => e.CeWho)
                    .HasMaxLength(16)
                    .HasColumnName("ce_who");

                entity.HasOne(d => d.CeRowidContactPlanNavigation)
                    .WithMany(p => p.ContactEvents)
                    .HasForeignKey(d => d.CeRowidContactPlan)
                    .HasConstraintName("FK__contact_e__ce_ro__0C85DE4D");
            });

            modelBuilder.Entity<ContactPlan>(entity =>
            {
                entity.HasKey(e => e.CpRowid)
                    .HasName("PK__contact___D7AF8BB93D3F0528");

                entity.ToTable("contact_plan");

                entity.HasIndex(e => e.CpCode, "cp_code_key");

                entity.Property(e => e.CpRowid).HasColumnName("cp_rowid");

                entity.Property(e => e.CpCategory).HasColumnName("cp_category");

                entity.Property(e => e.CpCategory1).HasColumnName("cp_category_1");

                entity.Property(e => e.CpCategory2).HasColumnName("cp_category_2");

                entity.Property(e => e.CpCby)
                    .HasMaxLength(16)
                    .HasColumnName("cp_cby");

                entity.Property(e => e.CpCdate)
                    .HasColumnType("date")
                    .HasColumnName("cp_cdate");

                entity.Property(e => e.CpClearPending).HasColumnName("cp_clear_pending");

                entity.Property(e => e.CpCode)
                    .HasMaxLength(16)
                    .HasColumnName("cp_code");

                entity.Property(e => e.CpCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cp_ctime");

                entity.Property(e => e.CpDescription)
                    .HasMaxLength(160)
                    .HasColumnName("cp_description");

                entity.Property(e => e.CpDuration).HasColumnName("cp_duration");

                entity.Property(e => e.CpFlags).HasColumnName("cp_flags");

                entity.Property(e => e.CpFrequency).HasColumnName("cp_frequency");

                entity.Property(e => e.CpMaxRange1).HasColumnName("cp_max_range_1");

                entity.Property(e => e.CpMaxRange2).HasColumnName("cp_max_range_2");

                entity.Property(e => e.CpMaxRange3).HasColumnName("cp_max_range_3");

                entity.Property(e => e.CpMby)
                    .HasMaxLength(16)
                    .HasColumnName("cp_mby");

                entity.Property(e => e.CpMdate)
                    .HasColumnType("date")
                    .HasColumnName("cp_mdate");

                entity.Property(e => e.CpMinRange1).HasColumnName("cp_min_range_1");

                entity.Property(e => e.CpMinRange2).HasColumnName("cp_min_range_2");

                entity.Property(e => e.CpMinRange3).HasColumnName("cp_min_range_3");

                entity.Property(e => e.CpMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cp_mtime");

                entity.Property(e => e.CpProcessId).HasColumnName("cp_process_id");

                entity.Property(e => e.CpProcessStep).HasColumnName("cp_process_step");

                entity.Property(e => e.CpSetProcessId).HasColumnName("cp_set_process_id");

                entity.Property(e => e.CpSwitches).HasColumnName("cp_switches");

                entity.Property(e => e.CpUid).HasColumnName("cp_uid");

                entity.Property(e => e.CpUidm).HasColumnName("cp_uidm");
            });

            modelBuilder.Entity<Cosigner>(entity =>
            {
                entity.HasKey(e => e.DeCosRowid)
                    .HasName("PK__cosigner__6B4F30D45F344809");

                entity.ToTable("cosigner");

                entity.HasIndex(e => e.DeCosBusinessPhone, "de_cos_business_phone_key");

                entity.HasIndex(e => e.DeCosCategory1, "de_cos_category_1_key");

                entity.HasIndex(e => e.DeCosCategory2, "de_cos_category_2_key");

                entity.HasIndex(e => e.DeCosCategory, "de_cos_category_key");

                entity.HasIndex(e => e.DeCosCellPhone, "de_cos_cell_phone_key");

                entity.HasIndex(e => e.DeCosCity, "de_cos_city_key");

                entity.HasIndex(e => e.DeCosDl, "de_cos_dl_key");

                entity.HasIndex(e => e.DeCosDob, "de_cos_dob_key");

                entity.HasIndex(e => e.DeCosEmail, "de_cos_email_key");

                entity.HasIndex(e => e.DeCosName, "de_cos_name_key");

                entity.HasIndex(e => e.DeCosOtherPhone, "de_cos_other_phone_key");

                entity.HasIndex(e => e.DeCosPhone, "de_cos_phone_key");

                entity.HasIndex(e => e.DeCosRowidDebtor, "de_cos_rowid_debtor_key");

                entity.HasIndex(e => e.DeCosSin, "de_cos_sin_key");

                entity.HasIndex(e => e.DeCosState, "de_cos_state_key");

                entity.HasIndex(e => e.DeCosZip, "de_cos_zip_key");

                entity.HasIndex(e => e.DeCosigner, "de_cosigner_key");

                entity.Property(e => e.DeCosRowid).HasColumnName("de_cos_rowid");

                entity.Property(e => e.DeCosAddress)
                    .HasMaxLength(164)
                    .HasColumnName("de_cos_address");

                entity.Property(e => e.DeCosAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("de_cos_address_1");

                entity.Property(e => e.DeCosAddress2)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_address_2");

                entity.Property(e => e.DeCosAddressFlags).HasColumnName("de_cos_address_flags");

                entity.Property(e => e.DeCosAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_amount");

                entity.Property(e => e.DeCosAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_amount_1");

                entity.Property(e => e.DeCosAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_amount_2");

                entity.Property(e => e.DeCosAttachNum).HasColumnName("de_cos_attach_num");

                entity.Property(e => e.DeCosBusinessExt)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_business_ext");

                entity.Property(e => e.DeCosBusinessPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_business_phone");

                entity.Property(e => e.DeCosCategory).HasColumnName("de_cos_category");

                entity.Property(e => e.DeCosCategory1).HasColumnName("de_cos_category_1");

                entity.Property(e => e.DeCosCategory2).HasColumnName("de_cos_category_2");

                entity.Property(e => e.DeCosCbrAssociation)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_cbr_association");

                entity.Property(e => e.DeCosCby)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_cby");

                entity.Property(e => e.DeCosCdate)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_cdate");

                entity.Property(e => e.DeCosCellExt)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_cell_ext");

                entity.Property(e => e.DeCosCellPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_cell_phone");

                entity.Property(e => e.DeCosCinfoInd)
                    .HasMaxLength(8)
                    .HasColumnName("de_cos_cinfo_ind");

                entity.Property(e => e.DeCosCity)
                    .HasMaxLength(64)
                    .HasColumnName("de_cos_city");

                entity.Property(e => e.DeCosClass).HasColumnName("de_cos_class");

                entity.Property(e => e.DeCosCountry)
                    .HasMaxLength(64)
                    .HasColumnName("de_cos_country");

                entity.Property(e => e.DeCosCreated).HasColumnName("de_cos_created");

                entity.Property(e => e.DeCosCreatedBy)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_created_by");

                entity.Property(e => e.DeCosCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_cos_ctime");

                entity.Property(e => e.DeCosDate1)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_date_1");

                entity.Property(e => e.DeCosDate2)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_date_2");

                entity.Property(e => e.DeCosDl)
                    .HasMaxLength(160)
                    .HasColumnName("de_cos_dl");

                entity.Property(e => e.DeCosDob)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_dob");

                entity.Property(e => e.DeCosEcoa)
                    .HasMaxLength(8)
                    .HasColumnName("de_cos_ecoa");

                entity.Property(e => e.DeCosEmail)
                    .HasMaxLength(256)
                    .HasColumnName("de_cos_email");

                entity.Property(e => e.DeCosEmailNum).HasColumnName("de_cos_email_num");

                entity.Property(e => e.DeCosEntity).HasColumnName("de_cos_entity");

                entity.Property(e => e.DeCosFlags1).HasColumnName("de_cos_flags_1");

                entity.Property(e => e.DeCosFlags2).HasColumnName("de_cos_flags_2");

                entity.Property(e => e.DeCosGroupFlags).HasColumnName("de_cos_group_flags");

                entity.Property(e => e.DeCosGroupId).HasColumnName("de_cos_group_id");

                entity.Property(e => e.DeCosGroupMember).HasColumnName("de_cos_group_member");

                entity.Property(e => e.DeCosLetterNum).HasColumnName("de_cos_letter_num");

                entity.Property(e => e.DeCosMby)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_mby");

                entity.Property(e => e.DeCosMdate)
                    .HasColumnType("date")
                    .HasColumnName("de_cos_mdate");

                entity.Property(e => e.DeCosModified).HasColumnName("de_cos_modified");

                entity.Property(e => e.DeCosModifiedBy)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_modified_by");

                entity.Property(e => e.DeCosMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_cos_mtime");

                entity.Property(e => e.DeCosName)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_name");

                entity.Property(e => e.DeCosNote1)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_note_1");

                entity.Property(e => e.DeCosNote2)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_note_2");

                entity.Property(e => e.DeCosNote3)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_note_3");

                entity.Property(e => e.DeCosNote4)
                    .HasMaxLength(128)
                    .HasColumnName("de_cos_note_4");

                entity.Property(e => e.DeCosNumber1).HasColumnName("de_cos_number_1");

                entity.Property(e => e.DeCosNumber2).HasColumnName("de_cos_number_2");

                entity.Property(e => e.DeCosOp1)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_op_1");

                entity.Property(e => e.DeCosOp2)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_op_2");

                entity.Property(e => e.DeCosOtherExt)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_other_ext");

                entity.Property(e => e.DeCosOtherPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_other_phone");

                entity.Property(e => e.DeCosPercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_percent");

                entity.Property(e => e.DeCosPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_percent_1");

                entity.Property(e => e.DeCosPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cos_percent_2");

                entity.Property(e => e.DeCosPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_phone");

                entity.Property(e => e.DeCosPhoneExt)
                    .HasMaxLength(16)
                    .HasColumnName("de_cos_phone_ext");

                entity.Property(e => e.DeCosRowidDebtor).HasColumnName("de_cos_rowid_debtor");

                entity.Property(e => e.DeCosSin)
                    .HasMaxLength(160)
                    .HasColumnName("de_cos_sin");

                entity.Property(e => e.DeCosState)
                    .HasMaxLength(64)
                    .HasColumnName("de_cos_state");

                entity.Property(e => e.DeCosStreetNumber)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_street_number");

                entity.Property(e => e.DeCosTimezone).HasColumnName("de_cos_timezone");

                entity.Property(e => e.DeCosTitle)
                    .HasMaxLength(64)
                    .HasColumnName("de_cos_title");

                entity.Property(e => e.DeCosType).HasColumnName("de_cos_type");

                entity.Property(e => e.DeCosUid).HasColumnName("de_cos_uid");

                entity.Property(e => e.DeCosUidm).HasColumnName("de_cos_uidm");

                entity.Property(e => e.DeCosUido).HasColumnName("de_cos_uido");

                entity.Property(e => e.DeCosZip)
                    .HasMaxLength(48)
                    .HasColumnName("de_cos_zip");

                entity.Property(e => e.DeCosigner)
                    .HasMaxLength(128)
                    .HasColumnName("de_cosigner");

                entity.HasOne(d => d.DeCosRowidDebtorNavigation)
                    .WithMany(p => p.Cosigners)
                    .HasForeignKey(d => d.DeCosRowidDebtor)
                    .HasConstraintName("FK__cosigner__de_cos__1FCDBCEB");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("countries");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Capital)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("capital");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Iso2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("iso2")
                    .IsFixedLength();

                entity.Property(e => e.Iso3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("iso3")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phonecode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("phonecode");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CurrencyLookup>(entity =>
            {
                entity.HasKey(e => e.CuRowid)
                    .HasName("PK__currency__8BF10B7AE3DD9195");

                entity.ToTable("currency_lookup");

                entity.HasIndex(e => e.CuCategory, "cu_category_key");

                entity.HasIndex(e => e.CuDate, "cu_date_key");

                entity.Property(e => e.CuRowid).HasColumnName("cu_rowid");

                entity.Property(e => e.CuBad).HasColumnName("cu_bad");

                entity.Property(e => e.CuCategory).HasColumnName("cu_category");

                entity.Property(e => e.CuCategory1).HasColumnName("cu_category_1");

                entity.Property(e => e.CuCategory2).HasColumnName("cu_category_2");

                entity.Property(e => e.CuCby)
                    .HasMaxLength(16)
                    .HasColumnName("cu_cby");

                entity.Property(e => e.CuCdate)
                    .HasColumnType("date")
                    .HasColumnName("cu_cdate");

                entity.Property(e => e.CuCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cu_ctime");

                entity.Property(e => e.CuDate)
                    .HasColumnType("date")
                    .HasColumnName("cu_date");

                entity.Property(e => e.CuId1)
                    .HasMaxLength(16)
                    .HasColumnName("cu_id_1");

                entity.Property(e => e.CuId2)
                    .HasMaxLength(16)
                    .HasColumnName("cu_id_2");

                entity.Property(e => e.CuMby)
                    .HasMaxLength(16)
                    .HasColumnName("cu_mby");

                entity.Property(e => e.CuMdate)
                    .HasColumnType("date")
                    .HasColumnName("cu_mdate");

                entity.Property(e => e.CuMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cu_mtime");

                entity.Property(e => e.CuOp1)
                    .HasMaxLength(16)
                    .HasColumnName("cu_op_1");

                entity.Property(e => e.CuOp2)
                    .HasMaxLength(16)
                    .HasColumnName("cu_op_2");

                entity.Property(e => e.CuRateBuy)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cu_rate_buy");

                entity.Property(e => e.CuRateSell)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("cu_rate_sell");

                entity.Property(e => e.CuTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("cu_time");

                entity.Property(e => e.CuType1).HasColumnName("cu_type_1");

                entity.Property(e => e.CuType2).HasColumnName("cu_type_2");

                entity.Property(e => e.CuUid).HasColumnName("cu_uid");

                entity.Property(e => e.CuUidm).HasColumnName("cu_uidm");
            });

            modelBuilder.Entity<Dbtag>(entity =>
            {
                entity.HasKey(e => e.DtRowid)
                    .HasName("PK__dbtag__EB9A54A0BEBBD72F");

                entity.ToTable("dbtag");

                entity.HasIndex(e => e.DtDate, "dt_date_key");

                entity.Property(e => e.DtRowid).HasColumnName("dt_rowid");

                entity.Property(e => e.DtAdapterId)
                    .HasMaxLength(22)
                    .HasColumnName("dt_adapterID");

                entity.Property(e => e.DtCby)
                    .HasMaxLength(16)
                    .HasColumnName("dt_cby");

                entity.Property(e => e.DtCdate)
                    .HasColumnType("date")
                    .HasColumnName("dt_cdate");

                entity.Property(e => e.DtCnxr)
                    .HasMaxLength(2000)
                    .HasColumnName("dt_cnxr");

                entity.Property(e => e.DtCompany)
                    .HasMaxLength(240)
                    .HasColumnName("dt_company");

                entity.Property(e => e.DtCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("dt_ctime");

                entity.Property(e => e.DtDate)
                    .HasColumnType("date")
                    .HasColumnName("dt_date");

                entity.Property(e => e.DtDetectMode).HasColumnName("dt_detectMode");

                entity.Property(e => e.DtDetectModeDateSet).HasColumnName("dt_detectModeDateSet");

                entity.Property(e => e.DtDetectdate)
                    .HasColumnType("date")
                    .HasColumnName("dt_detectdate");

                entity.Property(e => e.DtFeatures).HasColumnName("dt_features");

                entity.Property(e => e.DtId).HasColumnName("dt_id");

                entity.Property(e => e.DtMby)
                    .HasMaxLength(16)
                    .HasColumnName("dt_mby");

                entity.Property(e => e.DtMdate)
                    .HasColumnType("date")
                    .HasColumnName("dt_mdate");

                entity.Property(e => e.DtMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("dt_mtime");

                entity.Property(e => e.DtOptions).HasColumnName("dt_options");

                entity.Property(e => e.DtText)
                    .HasMaxLength(320)
                    .HasColumnName("dt_text");

                entity.Property(e => e.DtType)
                    .HasMaxLength(160)
                    .HasColumnName("dt_type");

                entity.Property(e => e.DtUcode)
                    .HasMaxLength(160)
                    .HasColumnName("dt_ucode");

                entity.Property(e => e.DtUdate)
                    .HasColumnType("date")
                    .HasColumnName("dt_udate");

                entity.Property(e => e.DtUdays).HasColumnName("dt_udays");

                entity.Property(e => e.DtUid).HasColumnName("dt_uid");

                entity.Property(e => e.DtUidm).HasColumnName("dt_uidm");

                entity.Property(e => e.DtUser)
                    .HasMaxLength(160)
                    .HasColumnName("dt_user");

                entity.Property(e => e.DtUsers).HasColumnName("dt_users");

                entity.Property(e => e.DtUtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("dt_utime");
            });

            modelBuilder.Entity<DcosContact>(entity =>
            {
                entity.HasKey(e => e.CoRowid)
                    .HasName("PK__dcos_con__91C3A18C722F7A00");

                entity.ToTable("dcos_contact");

                entity.HasIndex(e => e.CoAttachmentBlob, "co_attachment_blob_key");

                entity.HasIndex(e => e.CoCategory1, "co_category_1_key");

                entity.HasIndex(e => e.CoCategory, "co_category_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoType, e.CoDate }, "co_completedtypedate_key");

                entity.HasIndex(e => new { e.CoCompleted, e.CoWho, e.CoDate }, "co_completedwhodate_key");

                entity.HasIndex(e => e.CoDate, "co_date_key");

                entity.HasIndex(e => e.CoDoneDate, "co_done_date_key");

                entity.HasIndex(e => new { e.CoOriginator, e.CoCreationDate }, "co_originatordate_key");

                entity.HasIndex(e => e.CoRowidCosigner, "co_rowid_cosigner_key");

                entity.HasIndex(e => new { e.CoType, e.CoCompleted, e.CoWho, e.CoDate }, "co_typecompletedwhodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoDoneDate }, "co_whodate_key");

                entity.HasIndex(e => new { e.CoWho, e.CoType, e.CoDate }, "co_whotypedate_key");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_1");

                entity.Property(e => e.CoAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_amount_2");

                entity.Property(e => e.CoAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("co_attachment");

                entity.Property(e => e.CoAttachmentBlob).HasColumnName("co_attachment_blob");

                entity.Property(e => e.CoCategory).HasColumnName("co_category");

                entity.Property(e => e.CoCategory1).HasColumnName("co_category_1");

                entity.Property(e => e.CoCategory2).HasColumnName("co_category_2");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(16)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoClass).HasColumnName("co_class");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoCreationDate)
                    .HasColumnType("date")
                    .HasColumnName("co_creation_date");

                entity.Property(e => e.CoCreationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_creation_time");

                entity.Property(e => e.CoCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_ctime");

                entity.Property(e => e.CoCustomRepeat).HasColumnName("co_custom_repeat");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDate1)
                    .HasColumnType("date")
                    .HasColumnName("co_date_1");

                entity.Property(e => e.CoDate2)
                    .HasColumnType("date")
                    .HasColumnName("co_date_2");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(160)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoDoneBy)
                    .HasMaxLength(16)
                    .HasColumnName("co_done_by");

                entity.Property(e => e.CoDoneDate)
                    .HasColumnType("date")
                    .HasColumnName("co_done_date");

                entity.Property(e => e.CoDoneTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_done_time");

                entity.Property(e => e.CoElapsedTime).HasColumnName("co_elapsed_time");

                entity.Property(e => e.CoEstimatedTime).HasColumnName("co_estimated_time");

                entity.Property(e => e.CoFlags1).HasColumnName("co_flags_1");

                entity.Property(e => e.CoFlags2).HasColumnName("co_flags_2");

                entity.Property(e => e.CoLock).HasColumnName("co_lock");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(16)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_mtime");

                entity.Property(e => e.CoNumber1).HasColumnName("co_number_1");

                entity.Property(e => e.CoNumber2).HasColumnName("co_number_2");

                entity.Property(e => e.CoOp1)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_1");

                entity.Property(e => e.CoOp2)
                    .HasMaxLength(16)
                    .HasColumnName("co_op_2");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(16)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_1");

                entity.Property(e => e.CoPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("co_percent_2");

                entity.Property(e => e.CoPriority).HasColumnName("co_priority");

                entity.Property(e => e.CoRepeat).HasColumnName("co_repeat");

                entity.Property(e => e.CoRowidCosigner).HasColumnName("co_rowid_cosigner");

                entity.Property(e => e.CoTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("co_time");

                entity.Property(e => e.CoType).HasColumnName("co_type");

                entity.Property(e => e.CoUid).HasColumnName("co_uid");

                entity.Property(e => e.CoUidm).HasColumnName("co_uidm");

                entity.Property(e => e.CoUido).HasColumnName("co_uido");

                entity.Property(e => e.CoUser1)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_1");

                entity.Property(e => e.CoUser2)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_2");

                entity.Property(e => e.CoUser3)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_3");

                entity.Property(e => e.CoUser4)
                    .HasMaxLength(160)
                    .HasColumnName("co_user_4");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(16)
                    .HasColumnName("co_who");

                entity.Property(e => e.CoWhoFrom)
                    .HasMaxLength(16)
                    .HasColumnName("co_who_from");

                entity.HasOne(d => d.CoAttachmentBlobNavigation)
                    .WithMany(p => p.DcosContacts)
                    .HasForeignKey(d => d.CoAttachmentBlob)
                    .HasConstraintName("FK__dcos_cont__co_at__14270015");

                entity.HasOne(d => d.CoRowidCosignerNavigation)
                    .WithMany(p => p.DcosContacts)
                    .HasForeignKey(d => d.CoRowidCosigner)
                    .HasConstraintName("FK__dcos_cont__co_ro__1332DBDC");
            });

            modelBuilder.Entity<DeTransaction>(entity =>
            {
                entity.HasKey(e => e.TrRowid)
                    .HasName("PK__de_trans__C5AB8E9279FCC3A4");

                entity.ToTable("de_transaction");

                entity.HasIndex(e => e.TrBlob, "tr_blob_key");

                entity.HasIndex(e => e.TrCategory1, "tr_category_1_key");

                entity.HasIndex(e => e.TrCategory2, "tr_category_2_key");

                entity.HasIndex(e => e.TrCategory, "tr_category_key");

                entity.HasIndex(e => e.TrInvoiceNumber, "tr_invoice_number_key");

                entity.HasIndex(e => e.TrPaymentDate, "tr_payment_date_key");

                entity.HasIndex(e => e.TrPostedDate, "tr_posted_date_key");

                entity.HasIndex(e => e.TrReceiptNumber, "tr_receipt_number_key");

                entity.HasIndex(e => e.TrRowidDebtor, "tr_rowid_debtor_key");

                entity.Property(e => e.TrRowid).HasColumnName("tr_rowid");

                entity.Property(e => e.TrAccount).HasColumnName("tr_account");

                entity.Property(e => e.TrActual)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_actual");

                entity.Property(e => e.TrAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_adjustment");

                entity.Property(e => e.TrAgencyAcctCurrency).HasColumnName("tr_agency_acct_currency");

                entity.Property(e => e.TrAgencyExchangeAmt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_agency_exchange_amt");

                entity.Property(e => e.TrAgencyExchangeRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_agency_exchange_rate");

                entity.Property(e => e.TrAttachment)
                    .HasMaxLength(128)
                    .HasColumnName("tr_attachment");

                entity.Property(e => e.TrBlob).HasColumnName("tr_blob");

                entity.Property(e => e.TrBucket10)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_10");

                entity.Property(e => e.TrBucket11)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_11");

                entity.Property(e => e.TrBucket12)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_12");

                entity.Property(e => e.TrBucket13)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_13");

                entity.Property(e => e.TrBucket14)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_14");

                entity.Property(e => e.TrBucket15)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_15");

                entity.Property(e => e.TrBucket16)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_16");

                entity.Property(e => e.TrBucket5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_5");

                entity.Property(e => e.TrBucket6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_6");

                entity.Property(e => e.TrBucket7)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_7");

                entity.Property(e => e.TrBucket8)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_8");

                entity.Property(e => e.TrBucket9)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_bucket_9");

                entity.Property(e => e.TrCategory).HasColumnName("tr_category");

                entity.Property(e => e.TrCategory1).HasColumnName("tr_category_1");

                entity.Property(e => e.TrCategory2).HasColumnName("tr_category_2");

                entity.Property(e => e.TrCby)
                    .HasMaxLength(16)
                    .HasColumnName("tr_cby");

                entity.Property(e => e.TrCdate)
                    .HasColumnType("date")
                    .HasColumnName("tr_cdate");

                entity.Property(e => e.TrCommFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_fees");

                entity.Property(e => e.TrCommInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_interest");

                entity.Property(e => e.TrCommLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_legal");

                entity.Property(e => e.TrCommMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_misc");

                entity.Property(e => e.TrCommOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_other");

                entity.Property(e => e.TrCommPrinc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_comm_princ");

                entity.Property(e => e.TrCommRateOption).HasColumnName("tr_comm_rate_option");

                entity.Property(e => e.TrCommissionAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_amount");

                entity.Property(e => e.TrCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate");

                entity.Property(e => e.TrCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_1");

                entity.Property(e => e.TrCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_2");

                entity.Property(e => e.TrCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_commission_rate_3");

                entity.Property(e => e.TrConfirmationDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_confirmation_date");

                entity.Property(e => e.TrConfirmationNumber)
                    .HasMaxLength(128)
                    .HasColumnName("tr_confirmation_number");

                entity.Property(e => e.TrConfirmationTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_confirmation_time");

                entity.Property(e => e.TrCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_ctime");

                entity.Property(e => e.TrCurrency).HasColumnName("tr_currency");

                entity.Property(e => e.TrDate1)
                    .HasColumnType("date")
                    .HasColumnName("tr_date_1");

                entity.Property(e => e.TrDate2)
                    .HasColumnType("date")
                    .HasColumnName("tr_date_2");

                entity.Property(e => e.TrDeowingPostPayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_deowing_post_payment");

                entity.Property(e => e.TrDeowingPrePayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_deowing_pre_payment");

                entity.Property(e => e.TrDepositTo)
                    .HasMaxLength(16)
                    .HasColumnName("tr_deposit_to");

                entity.Property(e => e.TrDepositedDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_deposited_date");

                entity.Property(e => e.TrDepositedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_deposited_time");

                entity.Property(e => e.TrDescription)
                    .HasMaxLength(256)
                    .HasColumnName("tr_description");

                entity.Property(e => e.TrDisbursement)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_disbursement");

                entity.Property(e => e.TrExchangeRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_exchange_rate");

                entity.Property(e => e.TrFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_fee");

                entity.Property(e => e.TrFlags).HasColumnName("tr_flags");

                entity.Property(e => e.TrFlags1).HasColumnName("tr_flags_1");

                entity.Property(e => e.TrFlags2).HasColumnName("tr_flags_2");

                entity.Property(e => e.TrId).HasColumnName("tr_id");

                entity.Property(e => e.TrInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_interest");

                entity.Property(e => e.TrInvoiceNumber).HasColumnName("tr_invoice_number");

                entity.Property(e => e.TrLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_legal");

                entity.Property(e => e.TrMby)
                    .HasMaxLength(16)
                    .HasColumnName("tr_mby");

                entity.Property(e => e.TrMdate)
                    .HasColumnType("date")
                    .HasColumnName("tr_mdate");

                entity.Property(e => e.TrMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_misc");

                entity.Property(e => e.TrMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_mtime");

                entity.Property(e => e.TrNumber1).HasColumnName("tr_number_1");

                entity.Property(e => e.TrNumber2).HasColumnName("tr_number_2");

                entity.Property(e => e.TrOp1)
                    .HasMaxLength(16)
                    .HasColumnName("tr_op_1");

                entity.Property(e => e.TrOp2)
                    .HasMaxLength(16)
                    .HasColumnName("tr_op_2");

                entity.Property(e => e.TrOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_other");

                entity.Property(e => e.TrPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_payment_date");

                entity.Property(e => e.TrPaymentDueDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_payment_due_date");

                entity.Property(e => e.TrPaymentDueTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_payment_due_time");

                entity.Property(e => e.TrPaymentTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_payment_time");

                entity.Property(e => e.TrPaymentTypeFlag).HasColumnName("tr_payment_type_flag");

                entity.Property(e => e.TrPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_percent_1");

                entity.Property(e => e.TrPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_percent_2");

                entity.Property(e => e.TrPostedDate)
                    .HasColumnType("date")
                    .HasColumnName("tr_posted_date");

                entity.Property(e => e.TrPostedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tr_posted_time");

                entity.Property(e => e.TrPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_principal");

                entity.Property(e => e.TrReceiptNumber).HasColumnName("tr_receipt_number");

                entity.Property(e => e.TrReturn)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_return");

                entity.Property(e => e.TrRowidDebtor).HasColumnName("tr_rowid_debtor");

                entity.Property(e => e.TrSales)
                    .HasMaxLength(16)
                    .HasColumnName("tr_sales");

                entity.Property(e => e.TrSwitches).HasColumnName("tr_switches");

                entity.Property(e => e.TrTaxAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_amount");

                entity.Property(e => e.TrTaxFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_fees");

                entity.Property(e => e.TrTaxInt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_int");

                entity.Property(e => e.TrTaxLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_legal");

                entity.Property(e => e.TrTaxMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_misc");

                entity.Property(e => e.TrTaxOptions).HasColumnName("tr_tax_options");

                entity.Property(e => e.TrTaxOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_other");

                entity.Property(e => e.TrTaxPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_principal");

                entity.Property(e => e.TrTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate");

                entity.Property(e => e.TrTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_1");

                entity.Property(e => e.TrTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_2");

                entity.Property(e => e.TrTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_tax_rate_3");

                entity.Property(e => e.TrToAgency)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_agency");

                entity.Property(e => e.TrToClient)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_client");

                entity.Property(e => e.TrToCurrency).HasColumnName("tr_to_currency");

                entity.Property(e => e.TrToCurrent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tr_to_current");

                entity.Property(e => e.TrType)
                    .HasMaxLength(20)
                    .HasColumnName("tr_type");

                entity.Property(e => e.TrUid).HasColumnName("tr_uid");

                entity.Property(e => e.TrUidm).HasColumnName("tr_uidm");

                entity.Property(e => e.TrUido).HasColumnName("tr_uido");

                entity.Property(e => e.TrUser1)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_1");

                entity.Property(e => e.TrUser2)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_2");

                entity.Property(e => e.TrUser3)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_3");

                entity.Property(e => e.TrUser4)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_4");

                entity.Property(e => e.TrUser5)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_5");

                entity.Property(e => e.TrUser6)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_6");

                entity.Property(e => e.TrUser7)
                    .HasMaxLength(128)
                    .HasColumnName("tr_user_7");

                entity.Property(e => e.TrWho)
                    .HasMaxLength(16)
                    .HasColumnName("tr_who");

                entity.Property(e => e.TrWithdrawFrom)
                    .HasMaxLength(16)
                    .HasColumnName("tr_withdraw_from");

                entity.HasOne(d => d.TrBlobNavigation)
                    .WithMany(p => p.DeTransactions)
                    .HasForeignKey(d => d.TrBlob)
                    .HasConstraintName("FK__de_transa__tr_bl__1BC821DD");

                entity.HasOne(d => d.TrRowidDebtorNavigation)
                    .WithMany(p => p.DeTransactions)
                    .HasForeignKey(d => d.TrRowidDebtor)
                    .HasConstraintName("FK__de_transa__tr_ro__1AD3FDA4");
            });

            modelBuilder.Entity<Debtor>(entity =>
            {
                entity.HasKey(e => e.DeRowid)
                    .HasName("PK__debtor__D042D9C7E59007DE");

                entity.ToTable("debtor");

                entity.HasIndex(e => new { e.DeActive, e.DeName }, "de_activename_key");

                entity.HasIndex(e => e.DeCategory1, "de_category_1_key");

                entity.HasIndex(e => e.DeCategory2, "de_category_2_key");

                entity.HasIndex(e => e.DeCategory, "de_category_key");

                entity.HasIndex(e => e.DeCellPhone, "de_cell_phone_key");

                entity.HasIndex(e => e.DeCity, "de_city_key");

                entity.HasIndex(e => e.DeClAccount, "de_cl_account_key");

                entity.HasIndex(e => e.DeClerk, "de_clerk_key");

                entity.HasIndex(e => e.DeCloseDate, "de_close_date_key");

                entity.HasIndex(e => e.DeCollector, "de_collector_key");

                entity.HasIndex(e => e.DeContact, "de_contact_key");

                entity.HasIndex(e => e.DeCountry, "de_country_key");

                entity.HasIndex(e => e.DeDl, "de_dl_key");

                entity.HasIndex(e => e.DeDob, "de_dob_key");

                entity.HasIndex(e => e.DeEmail, "de_email_key");

                entity.HasIndex(e => new { e.DeGroupId, e.DeGroupMember, e.DeGroupFlags }, "de_group_idmemberflags_key");

                entity.HasIndex(e => e.DeHomePhone, "de_home_phone_key");

                entity.HasIndex(e => e.DeListedDate, "de_listed_date_key");

                entity.HasIndex(e => e.DeName, "de_name_key");

                entity.HasIndex(e => e.DeNoteblob, "de_noteblob_key");

                entity.HasIndex(e => e.DeNumber, "de_number_key");

                entity.HasIndex(e => e.DeOtherPhone, "de_other_phone_key");

                entity.HasIndex(e => e.DeOwnedByDebtor, "de_owned_by_debtor_key");

                entity.HasIndex(e => e.DeRowidClient, "de_rowid_client_key");

                entity.HasIndex(e => e.DeSalesman, "de_salesman_key");

                entity.HasIndex(e => e.DeSin, "de_sin_key");

                entity.HasIndex(e => e.DeState, "de_state_key");

                entity.HasIndex(e => e.DeStatus, "de_status_key");

                entity.HasIndex(e => e.DeSummaryFlags, "de_summary_flags_key");

                entity.HasIndex(e => e.DeType, "de_type_key");

                entity.HasIndex(e => e.DeWorkPhone, "de_work_phone_key");

                entity.HasIndex(e => e.DeZip, "de_zip_key");

                entity.Property(e => e.DeRowid).HasColumnName("de_rowid");

                entity.Property(e => e.De30Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_30_days");

                entity.Property(e => e.De60Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_60_days");

                entity.Property(e => e.De90Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_90_days");

                entity.Property(e => e.DeAccountNumber)
                    .HasMaxLength(160)
                    .HasColumnName("de_account_number");

                entity.Property(e => e.DeAccruedInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_accrued_interest");

                entity.Property(e => e.DeActive)
                    .HasMaxLength(12)
                    .HasColumnName("de_active");

                entity.Property(e => e.DeActualPaymentAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_actual_payment_amount");

                entity.Property(e => e.DeAddFlags).HasColumnName("de_add_flags");

                entity.Property(e => e.DeAddress)
                    .HasMaxLength(160)
                    .HasColumnName("de_address");

                entity.Property(e => e.DeAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("de_address_1");

                entity.Property(e => e.DeAddress2)
                    .HasMaxLength(160)
                    .HasColumnName("de_address_2");

                entity.Property(e => e.DeAddressSource).HasColumnName("de_address_source");

                entity.Property(e => e.DeAdjustPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_adjust_paid_to_date");

                entity.Property(e => e.DeAdjustments)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_adjustments");

                entity.Property(e => e.DeAltNumber)
                    .HasMaxLength(40)
                    .HasColumnName("de_alt_number");

                entity.Property(e => e.DeAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_amount_1");

                entity.Property(e => e.DeAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_amount_2");

                entity.Property(e => e.DeAmountPastDue)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_amount_past_due");

                entity.Property(e => e.DeArchive).HasColumnName("de_archive");

                entity.Property(e => e.DeArchiveDate)
                    .HasColumnType("date")
                    .HasColumnName("de_archive_date");

                entity.Property(e => e.DeAttachNum).HasColumnName("de_attach_num");

                entity.Property(e => e.DeBank)
                    .HasMaxLength(128)
                    .HasColumnName("de_bank");

                entity.Property(e => e.DeBranch)
                    .HasMaxLength(160)
                    .HasColumnName("de_branch");

                entity.Property(e => e.DeBusiness)
                    .HasMaxLength(128)
                    .HasColumnName("de_business");

                entity.Property(e => e.DeBusinessAddress)
                    .HasMaxLength(128)
                    .HasColumnName("de_business_address");

                entity.Property(e => e.DeCategory).HasColumnName("de_category");

                entity.Property(e => e.DeCategory1).HasColumnName("de_category_1");

                entity.Property(e => e.DeCategory2).HasColumnName("de_category_2");

                entity.Property(e => e.DeCby)
                    .HasMaxLength(16)
                    .HasColumnName("de_cby");

                entity.Property(e => e.DeCdate)
                    .HasColumnType("date")
                    .HasColumnName("de_cdate");

                entity.Property(e => e.DeCellExtension)
                    .HasMaxLength(16)
                    .HasColumnName("de_cell_extension");

                entity.Property(e => e.DeCellPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cell_phone");

                entity.Property(e => e.DeChargeDate)
                    .HasColumnType("date")
                    .HasColumnName("de_charge_date");

                entity.Property(e => e.DeCity)
                    .HasMaxLength(64)
                    .HasColumnName("de_city");

                entity.Property(e => e.DeClAccount)
                    .HasMaxLength(160)
                    .HasColumnName("de_cl_account");

                entity.Property(e => e.DeClSettlementAmt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_cl_settlement_amt");

                entity.Property(e => e.DeClass)
                    .HasMaxLength(16)
                    .HasColumnName("de_class");

                entity.Property(e => e.DeClerk)
                    .HasMaxLength(16)
                    .HasColumnName("de_clerk");

                entity.Property(e => e.DeCloseDate)
                    .HasColumnType("date")
                    .HasColumnName("de_close_date");

                entity.Property(e => e.DeCollector)
                    .HasMaxLength(16)
                    .HasColumnName("de_collector");

                entity.Property(e => e.DeCommFeesToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_fees_to_date");

                entity.Property(e => e.DeCommInterestToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_interest_to_date");

                entity.Property(e => e.DeCommLegalToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_legal_to_date");

                entity.Property(e => e.DeCommMiscToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_misc_to_date");

                entity.Property(e => e.DeCommOtherToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_other_to_date");

                entity.Property(e => e.DeCommPrincToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_comm_princ_to_date");

                entity.Property(e => e.DeCommRateOption).HasColumnName("de_comm_rate_option");

                entity.Property(e => e.DeCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_rate");

                entity.Property(e => e.DeCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_rate_1");

                entity.Property(e => e.DeCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_rate_2");

                entity.Property(e => e.DeCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_rate_3");

                entity.Property(e => e.DeCommissionToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_commission_to_date");

                entity.Property(e => e.DeCompanyName)
                    .HasMaxLength(128)
                    .HasColumnName("de_company_name");

                entity.Property(e => e.DeContact)
                    .HasMaxLength(128)
                    .HasColumnName("de_contact");

                entity.Property(e => e.DeCountry)
                    .HasMaxLength(64)
                    .HasColumnName("de_country");

                entity.Property(e => e.DeCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_ctime");

                entity.Property(e => e.DeCurrency).HasColumnName("de_currency");

                entity.Property(e => e.DeDate1)
                    .HasColumnType("date")
                    .HasColumnName("de_date1");

                entity.Property(e => e.DeDate11)
                    .HasColumnType("date")
                    .HasColumnName("de_date_1");

                entity.Property(e => e.DeDate2)
                    .HasColumnType("date")
                    .HasColumnName("de_date2");

                entity.Property(e => e.DeDate21)
                    .HasColumnType("date")
                    .HasColumnName("de_date_2");

                entity.Property(e => e.DeDelinquencyDate)
                    .HasColumnType("date")
                    .HasColumnName("de_delinquency_date");

                entity.Property(e => e.DeDepositTo)
                    .HasMaxLength(16)
                    .HasColumnName("de_deposit_to");

                entity.Property(e => e.DeDescription)
                    .HasMaxLength(256)
                    .HasColumnName("de_description");

                entity.Property(e => e.DeDisplayFlags).HasColumnName("de_display_flags");

                entity.Property(e => e.DeDl)
                    .HasMaxLength(160)
                    .HasColumnName("de_dl");

                entity.Property(e => e.DeDob)
                    .HasColumnType("date")
                    .HasColumnName("de_dob");

                entity.Property(e => e.DeEarlyPayoffAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_early_payoff_amount");

                entity.Property(e => e.DeEarlyPayoffDiscount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_early_payoff_discount");

                entity.Property(e => e.DeEarlyPayoffSavings)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_early_payoff_savings");

                entity.Property(e => e.DeEditDate)
                    .HasColumnType("date")
                    .HasColumnName("de_edit_date");

                entity.Property(e => e.DeElapsedTime).HasColumnName("de_elapsed_time");

                entity.Property(e => e.DeEmail)
                    .HasMaxLength(160)
                    .HasColumnName("de_email");

                entity.Property(e => e.DeEmailNum).HasColumnName("de_email_num");

                entity.Property(e => e.DeEntity).HasColumnName("de_entity");

                entity.Property(e => e.DeEstimatedTime).HasColumnName("de_estimated_time");

                entity.Property(e => e.DeFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_fees");

                entity.Property(e => e.DeFeesPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_fees_paid_to_date");

                entity.Property(e => e.DeFirstName)
                    .HasMaxLength(128)
                    .HasColumnName("de_first_name");

                entity.Property(e => e.DeFirstPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("de_first_payment_date");

                entity.Property(e => e.DeFixFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_fix_fee");

                entity.Property(e => e.DeFlags).HasColumnName("de_flags");

                entity.Property(e => e.DeFlags1).HasColumnName("de_flags_1");

                entity.Property(e => e.DeFlags2).HasColumnName("de_flags_2");

                entity.Property(e => e.DeFromOffice).HasColumnName("de_from_office");

                entity.Property(e => e.DeGeneration)
                    .HasMaxLength(64)
                    .HasColumnName("de_generation");

                entity.Property(e => e.DeGracePeriod).HasColumnName("de_grace_period");

                entity.Property(e => e.DeGroupFlags).HasColumnName("de_group_flags");

                entity.Property(e => e.DeGroupId).HasColumnName("de_group_id");

                entity.Property(e => e.DeGroupMember).HasColumnName("de_group_member");

                entity.Property(e => e.DeHomeExtension)
                    .HasMaxLength(16)
                    .HasColumnName("de_home_extension");

                entity.Property(e => e.DeHomePhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_home_phone");

                entity.Property(e => e.DeInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_interest");

                entity.Property(e => e.DeInterestDate)
                    .HasColumnType("date")
                    .HasColumnName("de_interest_date");

                entity.Property(e => e.DeInterestFlags1).HasColumnName("de_interest_flags1");

                entity.Property(e => e.DeInterestFlags2).HasColumnName("de_interest_flags2");

                entity.Property(e => e.DeInterestFlags3).HasColumnName("de_interest_flags3");

                entity.Property(e => e.DeInterestPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_interest_paid_to_date");

                entity.Property(e => e.DeInterestPeriod).HasColumnName("de_interest_period");

                entity.Property(e => e.DeInterestRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_interest_rate");

                entity.Property(e => e.DeInterestTime)
                    .HasMaxLength(8)
                    .HasColumnName("de_interest_time");

                entity.Property(e => e.DeJudgeFeePaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_fee_paidtodate");

                entity.Property(e => e.DeJudgeIntPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_int_paidtodate");

                entity.Property(e => e.DeJudgeLegalPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_legal_paidtodate");

                entity.Property(e => e.DeJudgeMiscPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_misc_paidtodate");

                entity.Property(e => e.DeJudgeOtherPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_other_paidtodate");

                entity.Property(e => e.DeJudgePrincPaidtodate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judge_princ_paidtodate");

                entity.Property(e => e.DeJudgementBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_balance");

                entity.Property(e => e.DeJudgementDate)
                    .HasColumnType("date")
                    .HasColumnName("de_judgement_date");

                entity.Property(e => e.DeJudgementFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_fees");

                entity.Property(e => e.DeJudgementInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_interest");

                entity.Property(e => e.DeJudgementLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_legal");

                entity.Property(e => e.DeJudgementMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_misc");

                entity.Property(e => e.DeJudgementOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_other");

                entity.Property(e => e.DeJudgementPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_judgement_principal");

                entity.Property(e => e.DeLastAction)
                    .HasMaxLength(16)
                    .HasColumnName("de_last_action");

                entity.Property(e => e.DeLastPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_payment_date");

                entity.Property(e => e.DeLastWorkedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_worked_date");

                entity.Property(e => e.DeLastWorkedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_last_worked_time");

                entity.Property(e => e.DeLateFeeAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_late_fee_amount");

                entity.Property(e => e.DeLateFeeFlags1).HasColumnName("de_late_fee_flags1");

                entity.Property(e => e.DeLateFeeFlags2).HasColumnName("de_late_fee_flags2");

                entity.Property(e => e.DeLateFeePercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_late_fee_percent");

                entity.Property(e => e.DeLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_legal");

                entity.Property(e => e.DeLegalCosts)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_legal_costs");

                entity.Property(e => e.DeLegalPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_legal_paid_to_date");

                entity.Property(e => e.DeLetterNum).HasColumnName("de_letter_num");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeMby)
                    .HasMaxLength(16)
                    .HasColumnName("de_mby");

                entity.Property(e => e.DeMdate)
                    .HasColumnType("date")
                    .HasColumnName("de_mdate");

                entity.Property(e => e.DeMiddleName)
                    .HasMaxLength(128)
                    .HasColumnName("de_middle_name");

                entity.Property(e => e.DeMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_misc");

                entity.Property(e => e.DeMiscPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_misc_paid_to_date");

                entity.Property(e => e.DeModifiedBy)
                    .HasMaxLength(16)
                    .HasColumnName("de_modified_by");

                entity.Property(e => e.DeModifiedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_modified_date");

                entity.Property(e => e.DeModifiedTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_modified_time");

                entity.Property(e => e.DeMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("de_mtime");

                entity.Property(e => e.DeName)
                    .HasMaxLength(128)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNextPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("de_next_payment_date");

                entity.Property(e => e.DeNoteblob).HasColumnName("de_noteblob");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeNumber1).HasColumnName("de_number_1");

                entity.Property(e => e.DeNumber2).HasColumnName("de_number_2");

                entity.Property(e => e.DeNumberOfPeriods).HasColumnName("de_number_of_periods");

                entity.Property(e => e.DeOkToPhone).HasColumnName("de_ok_to_phone");

                entity.Property(e => e.DeOp1)
                    .HasMaxLength(16)
                    .HasColumnName("de_op_1");

                entity.Property(e => e.DeOp2)
                    .HasMaxLength(16)
                    .HasColumnName("de_op_2");

                entity.Property(e => e.DeOrgCreditor)
                    .HasMaxLength(128)
                    .HasColumnName("de_org_creditor");

                entity.Property(e => e.DeOrgCreditorType).HasColumnName("de_org_creditor_type");

                entity.Property(e => e.DeOriginalInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_original_interest");

                entity.Property(e => e.DeOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_other");

                entity.Property(e => e.DeOtherExtension)
                    .HasMaxLength(16)
                    .HasColumnName("de_other_extension");

                entity.Property(e => e.DeOtherPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_other_paid_to_date");

                entity.Property(e => e.DeOtherPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_other_phone");

                entity.Property(e => e.DeOver90)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_over_90");

                entity.Property(e => e.DeOwing)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_owing");

                entity.Property(e => e.DeOwnedByDebtor).HasColumnName("de_owned_by_debtor");

                entity.Property(e => e.DePaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_paid");

                entity.Property(e => e.DePaymentAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_payment_amount");

                entity.Property(e => e.DePercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_percent_1");

                entity.Property(e => e.DePercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_percent_2");

                entity.Property(e => e.DePeriodDays).HasColumnName("de_period_days");

                entity.Property(e => e.DePoe)
                    .HasMaxLength(128)
                    .HasColumnName("de_poe");

                entity.Property(e => e.DePreCharge)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_pre_charge");

                entity.Property(e => e.DePreRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_pre_rate");

                entity.Property(e => e.DePrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_principal");

                entity.Property(e => e.DePrincipalPaidToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_principal_paid_to_date");

                entity.Property(e => e.DeProcessId).HasColumnName("de_process_id");

                entity.Property(e => e.DeProcessStep).HasColumnName("de_process_step");

                entity.Property(e => e.DePromiseDate)
                    .HasColumnType("date")
                    .HasColumnName("de_promise_date");

                entity.Property(e => e.DeRateIndex)
                    .HasMaxLength(16)
                    .HasColumnName("de_rate_index");

                entity.Property(e => e.DeReferralRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_referral_rate");

                entity.Property(e => e.DeRiskScore).HasColumnName("de_risk_score");

                entity.Property(e => e.DeRowidClient).HasColumnName("de_rowid_client");

                entity.Property(e => e.DeSalesman)
                    .HasMaxLength(16)
                    .HasColumnName("de_salesman");

                entity.Property(e => e.DeSin)
                    .HasMaxLength(160)
                    .HasColumnName("de_sin");

                entity.Property(e => e.DeState)
                    .HasMaxLength(64)
                    .HasColumnName("de_state");

                entity.Property(e => e.DeStatus)
                    .HasMaxLength(20)
                    .HasColumnName("de_status");

                entity.Property(e => e.DeStreetNumber)
                    .HasMaxLength(48)
                    .HasColumnName("de_street_number");

                entity.Property(e => e.DeSummaryFlags).HasColumnName("de_summary_flags");

                entity.Property(e => e.DeTaxExempt).HasColumnName("de_tax_exempt");

                entity.Property(e => e.DeTaxOptions).HasColumnName("de_tax_options");

                entity.Property(e => e.DeTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_tax_rate");

                entity.Property(e => e.DeTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_tax_rate_1");

                entity.Property(e => e.DeTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_tax_rate_2");

                entity.Property(e => e.DeTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_tax_rate_3");

                entity.Property(e => e.DeTimeZone).HasColumnName("de_time_zone");

                entity.Property(e => e.DeTimezone1).HasColumnName("de_timezone");

                entity.Property(e => e.DeToOffice).HasColumnName("de_to_office");

                entity.Property(e => e.DeTotalPlanPayments)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_total_plan_payments");

                entity.Property(e => e.DeTransitNumber)
                    .HasMaxLength(128)
                    .HasColumnName("de_transit_number");

                entity.Property(e => e.DeType)
                    .HasMaxLength(64)
                    .HasColumnName("de_type");

                entity.Property(e => e.DeUid).HasColumnName("de_uid");

                entity.Property(e => e.DeUidm).HasColumnName("de_uidm");

                entity.Property(e => e.DeUido).HasColumnName("de_uido");

                entity.Property(e => e.DeUser1)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_1");

                entity.Property(e => e.DeUser2)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_2");

                entity.Property(e => e.DeUser3)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_3");

                entity.Property(e => e.DeUser4)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_4");

                entity.Property(e => e.DeUser5)
                    .HasMaxLength(128)
                    .HasColumnName("de_user_5");

                entity.Property(e => e.DeWithdrawFrom)
                    .HasMaxLength(16)
                    .HasColumnName("de_withdraw_from");

                entity.Property(e => e.DeWorkExtension)
                    .HasMaxLength(16)
                    .HasColumnName("de_work_extension");

                entity.Property(e => e.DeWorkPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_work_phone");

                entity.Property(e => e.DeZip)
                    .HasMaxLength(48)
                    .HasColumnName("de_zip");

                entity.Property(e => e.LastClBillDate)
                    .HasColumnType("date")
                    .HasColumnName("last_cl_bill_date");

                entity.Property(e => e.LastClPaymentDate).HasColumnName("last_cl_payment_date");

                entity.HasOne(d => d.DeNoteblobNavigation)
                    .WithMany(p => p.Debtors)
                    .HasForeignKey(d => d.DeNoteblob)
                    .HasConstraintName("FK__debtor__de_noteb__1920BF5C");

                entity.HasOne(d => d.DeRowidClientNavigation)
                    .WithMany(p => p.Debtors)
                    .HasForeignKey(d => d.DeRowidClient)
                    .HasConstraintName("FK__debtor__de_rowid__182C9B23");
            });

            modelBuilder.Entity<DebtorStatus>(entity =>
            {
                entity.HasKey(e => e.DsRowid)
                    .HasName("PK__debtor_s__7C6DC866B6700396");

                entity.ToTable("debtor_status");

                entity.HasIndex(e => e.DsCategory, "ds_category_key");

                entity.HasIndex(e => e.DsCode, "ds_code_key");

                entity.Property(e => e.DsRowid).HasColumnName("ds_rowid");

                entity.Property(e => e.DsCategory).HasColumnName("ds_category");

                entity.Property(e => e.DsCategory1).HasColumnName("ds_category_1");

                entity.Property(e => e.DsCategory2).HasColumnName("ds_category_2");

                entity.Property(e => e.DsCby)
                    .HasMaxLength(16)
                    .HasColumnName("ds_cby");

                entity.Property(e => e.DsCdate)
                    .HasColumnType("date")
                    .HasColumnName("ds_cdate");

                entity.Property(e => e.DsCode)
                    .HasMaxLength(20)
                    .HasColumnName("ds_code");

                entity.Property(e => e.DsColor).HasColumnName("ds_color");

                entity.Property(e => e.DsCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ds_ctime");

                entity.Property(e => e.DsDescription)
                    .HasMaxLength(160)
                    .HasColumnName("ds_description");

                entity.Property(e => e.DsFlags).HasColumnName("ds_flags");

                entity.Property(e => e.DsMby)
                    .HasMaxLength(16)
                    .HasColumnName("ds_mby");

                entity.Property(e => e.DsMdate)
                    .HasColumnType("date")
                    .HasColumnName("ds_mdate");

                entity.Property(e => e.DsMetroStatus)
                    .HasMaxLength(16)
                    .HasColumnName("ds_metro_status");

                entity.Property(e => e.DsMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ds_mtime");

                entity.Property(e => e.DsPlan)
                    .HasMaxLength(16)
                    .HasColumnName("ds_plan");

                entity.Property(e => e.DsState)
                    .HasMaxLength(8)
                    .HasColumnName("ds_state");

                entity.Property(e => e.DsUid).HasColumnName("ds_uid");

                entity.Property(e => e.DsUidm).HasColumnName("ds_uidm");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.EmRowid)
                    .HasName("PK__email__EBDFDBF0CA38C1EF");

                entity.ToTable("email");

                entity.Property(e => e.EmRowid).HasColumnName("em_rowid");

                entity.Property(e => e.EmCby)
                    .HasMaxLength(16)
                    .HasColumnName("em_cby");

                entity.Property(e => e.EmCdate)
                    .HasColumnType("date")
                    .HasColumnName("em_cdate");

                entity.Property(e => e.EmCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("em_ctime");

                entity.Property(e => e.EmDate1)
                    .HasColumnType("date")
                    .HasColumnName("em_date_1");

                entity.Property(e => e.EmDate2)
                    .HasColumnType("date")
                    .HasColumnName("em_date_2");

                entity.Property(e => e.EmEmailAddress)
                    .HasMaxLength(256)
                    .HasColumnName("em_email_address");

                entity.Property(e => e.EmFlags).HasColumnName("em_flags");

                entity.Property(e => e.EmFlags1).HasColumnName("em_flags_1");

                entity.Property(e => e.EmMby)
                    .HasMaxLength(16)
                    .HasColumnName("em_mby");

                entity.Property(e => e.EmMdate)
                    .HasColumnType("date")
                    .HasColumnName("em_mdate");

                entity.Property(e => e.EmMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("em_mtime");

                entity.Property(e => e.EmOp1)
                    .HasMaxLength(16)
                    .HasColumnName("em_op_1");

                entity.Property(e => e.EmOp2)
                    .HasMaxLength(16)
                    .HasColumnName("em_op_2");

                entity.Property(e => e.EmRowidAssociated).HasColumnName("em_rowid_associated");

                entity.Property(e => e.EmRowidBank).HasColumnName("em_rowid_bank");

                entity.Property(e => e.EmRowidClient).HasColumnName("em_rowid_client");

                entity.Property(e => e.EmRowidCosigner).HasColumnName("em_rowid_cosigner");

                entity.Property(e => e.EmRowidDebtor).HasColumnName("em_rowid_debtor");

                entity.Property(e => e.EmType).HasColumnName("em_type");

                entity.Property(e => e.EmUid).HasColumnName("em_uid");

                entity.Property(e => e.EmUidm).HasColumnName("em_uidm");

                entity.Property(e => e.EmUido).HasColumnName("em_uido");

                entity.Property(e => e.EmUido1).HasColumnName("em_uido_1");

                entity.Property(e => e.EmUido2).HasColumnName("em_uido_2");

                entity.Property(e => e.EmUido3).HasColumnName("em_uido_3");

                entity.Property(e => e.EmUido4).HasColumnName("em_uido_4");

                entity.HasOne(d => d.EmRowidAssociatedNavigation)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.EmRowidAssociated)
                    .HasConstraintName("FK__email__em_rowid___282DF8C2");

                entity.HasOne(d => d.EmRowidBankNavigation)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.EmRowidBank)
                    .HasConstraintName("FK__email__em_rowid___245D67DE");

                entity.HasOne(d => d.EmRowidClientNavigation)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.EmRowidClient)
                    .HasConstraintName("FK__email__em_rowid___25518C17");

                entity.HasOne(d => d.EmRowidCosignerNavigation)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.EmRowidCosigner)
                    .HasConstraintName("FK__email__em_rowid___2739D489");

                entity.HasOne(d => d.EmRowidDebtorNavigation)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.EmRowidDebtor)
                    .HasConstraintName("FK__email__em_rowid___2645B050");
            });

            modelBuilder.Entity<FormRight>(entity =>
            {
                entity.HasKey(e => e.FrRowid)
                    .HasName("PK__form_rig__C7738338C35464A5");

                entity.ToTable("form_rights");

                entity.HasIndex(e => e.FrRowidApplicationForm, "fr_rowid_application_form_key");

                entity.HasIndex(e => e.FrRowidOperatorLevel, "fr_rowid_operator_level_key");

                entity.Property(e => e.FrRowid).HasColumnName("fr_rowid");

                entity.Property(e => e.FrAlias)
                    .HasMaxLength(132)
                    .HasColumnName("fr_alias");

                entity.Property(e => e.FrCby)
                    .HasMaxLength(16)
                    .HasColumnName("fr_cby");

                entity.Property(e => e.FrCdate)
                    .HasColumnType("date")
                    .HasColumnName("fr_cdate");

                entity.Property(e => e.FrCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("fr_ctime");

                entity.Property(e => e.FrFormnum).HasColumnName("fr_formnum");

                entity.Property(e => e.FrMax)
                    .HasMaxLength(132)
                    .HasColumnName("fr_max");

                entity.Property(e => e.FrMby)
                    .HasMaxLength(16)
                    .HasColumnName("fr_mby");

                entity.Property(e => e.FrMdate)
                    .HasColumnType("date")
                    .HasColumnName("fr_mdate");

                entity.Property(e => e.FrMin)
                    .HasMaxLength(132)
                    .HasColumnName("fr_min");

                entity.Property(e => e.FrMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("fr_mtime");

                entity.Property(e => e.FrPickListFile)
                    .HasMaxLength(256)
                    .HasColumnName("fr_pick_list_file");

                entity.Property(e => e.FrRights).HasColumnName("fr_rights");

                entity.Property(e => e.FrRowidApplicationForm).HasColumnName("fr_rowid_application_form");

                entity.Property(e => e.FrRowidOperatorLevel).HasColumnName("fr_rowid_operator_level");

                entity.Property(e => e.FrUid).HasColumnName("fr_uid");

                entity.Property(e => e.FrUidm).HasColumnName("fr_uidm");

                entity.Property(e => e.FrUido).HasColumnName("fr_uido");

                entity.Property(e => e.FrUido1).HasColumnName("fr_uido_1");

                entity.Property(e => e.FrUserlevel).HasColumnName("fr_userlevel");

                entity.HasOne(d => d.FrRowidApplicationFormNavigation)
                    .WithMany(p => p.FormRights)
                    .HasForeignKey(d => d.FrRowidApplicationForm)
                    .HasConstraintName("FK__form_righ__fr_ro__339FAB6E");

                entity.HasOne(d => d.FrRowidOperatorLevelNavigation)
                    .WithMany(p => p.FormRights)
                    .HasForeignKey(d => d.FrRowidOperatorLevel)
                    .HasConstraintName("FK__form_righ__fr_ro__3493CFA7");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.InRowid)
                    .HasName("PK__invoice__3A8093B2B73E64A6");

                entity.ToTable("invoice");

                entity.HasIndex(e => e.InDate, "in_date_key");

                entity.HasIndex(e => e.InRowidClient, "in_rowid_client_key");

                entity.Property(e => e.InRowid).HasColumnName("in_rowid");

                entity.Property(e => e.In120Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_120_days");

                entity.Property(e => e.In150Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_150_days");

                entity.Property(e => e.In30Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_30_days");

                entity.Property(e => e.In60Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_60_days");

                entity.Property(e => e.In90Days)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_90_days");

                entity.Property(e => e.InAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_amount_1");

                entity.Property(e => e.InAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_amount_2");

                entity.Property(e => e.InBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_balance");

                entity.Property(e => e.InCby)
                    .HasMaxLength(16)
                    .HasColumnName("in_cby");

                entity.Property(e => e.InCdate)
                    .HasColumnType("date")
                    .HasColumnName("in_cdate");

                entity.Property(e => e.InCheckNumber).HasColumnName("in_check_number");

                entity.Property(e => e.InCommission)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_commission");

                entity.Property(e => e.InCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_commission_rate");

                entity.Property(e => e.InCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("in_ctime");

                entity.Property(e => e.InCurrency).HasColumnName("in_currency");

                entity.Property(e => e.InDate)
                    .HasColumnType("date")
                    .HasColumnName("in_date");

                entity.Property(e => e.InDate1)
                    .HasColumnType("date")
                    .HasColumnName("in_date_1");

                entity.Property(e => e.InDate2)
                    .HasColumnType("date")
                    .HasColumnName("in_date_2");

                entity.Property(e => e.InDirect)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_direct");

                entity.Property(e => e.InDirectComm)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_direct_comm");

                entity.Property(e => e.InDirectTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_direct_tax");

                entity.Property(e => e.InDue)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_due");

                entity.Property(e => e.InFlags1).HasColumnName("in_flags_1");

                entity.Property(e => e.InFlags2).HasColumnName("in_flags_2");

                entity.Property(e => e.InFromDate)
                    .HasColumnType("date")
                    .HasColumnName("in_from_date");

                entity.Property(e => e.InGeneratedBy)
                    .HasMaxLength(16)
                    .HasColumnName("in_generated_by");

                entity.Property(e => e.InGst)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_gst");

                entity.Property(e => e.InMby)
                    .HasMaxLength(16)
                    .HasColumnName("in_mby");

                entity.Property(e => e.InMdate)
                    .HasColumnType("date")
                    .HasColumnName("in_mdate");

                entity.Property(e => e.InMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("in_mtime");

                entity.Property(e => e.InNumber).HasColumnName("in_number");

                entity.Property(e => e.InNumber1).HasColumnName("in_number_1");

                entity.Property(e => e.InNumber2).HasColumnName("in_number_2");

                entity.Property(e => e.InOp1)
                    .HasMaxLength(16)
                    .HasColumnName("in_op_1");

                entity.Property(e => e.InOp2)
                    .HasMaxLength(16)
                    .HasColumnName("in_op_2");

                entity.Property(e => e.InPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_percent_1");

                entity.Property(e => e.InPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_percent_2");

                entity.Property(e => e.InReturned)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_returned");

                entity.Property(e => e.InRowidClient).HasColumnName("in_rowid_client");

                entity.Property(e => e.InSubtotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_subtotal");

                entity.Property(e => e.InToDate)
                    .HasColumnType("date")
                    .HasColumnName("in_to_date");

                entity.Property(e => e.InToUs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_to_us");

                entity.Property(e => e.InTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_total");

                entity.Property(e => e.InTousComm)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_tous_comm");

                entity.Property(e => e.InTousTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("in_tous_tax");

                entity.Property(e => e.InType).HasColumnName("in_type");

                entity.Property(e => e.InUid).HasColumnName("in_uid");

                entity.Property(e => e.InUidm).HasColumnName("in_uidm");

                entity.Property(e => e.InUido).HasColumnName("in_uido");

                entity.HasOne(d => d.InRowidClientNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.InRowidClient)
                    .HasConstraintName("FK__invoice__in_rowi__37703C52");
            });

            modelBuilder.Entity<InvoiceLine>(entity =>
            {
                entity.HasKey(e => e.IlRowid)
                    .HasName("PK__invoice___7ED0E8A8EAD22649");

                entity.ToTable("invoice_line");

                entity.HasIndex(e => e.IlRowidDeTransaction, "il_rowid_de_transaction_key");

                entity.HasIndex(e => e.IlRowidInvoice, "il_rowid_invoice_key");

                entity.Property(e => e.IlRowid).HasColumnName("il_rowid");

                entity.Property(e => e.IlBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_balance");

                entity.Property(e => e.IlCby)
                    .HasMaxLength(16)
                    .HasColumnName("il_cby");

                entity.Property(e => e.IlCdate)
                    .HasColumnType("date")
                    .HasColumnName("il_cdate");

                entity.Property(e => e.IlCommission)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_commission");

                entity.Property(e => e.IlCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_commission_rate");

                entity.Property(e => e.IlCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("il_ctime");

                entity.Property(e => e.IlDate)
                    .HasColumnType("date")
                    .HasColumnName("il_date");

                entity.Property(e => e.IlDebtor)
                    .HasMaxLength(128)
                    .HasColumnName("il_debtor");

                entity.Property(e => e.IlDebtorNumber).HasColumnName("il_debtor_number");

                entity.Property(e => e.IlDescription)
                    .HasMaxLength(128)
                    .HasColumnName("il_description");

                entity.Property(e => e.IlDirect)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_direct");

                entity.Property(e => e.IlMby)
                    .HasMaxLength(16)
                    .HasColumnName("il_mby");

                entity.Property(e => e.IlMdate)
                    .HasColumnType("date")
                    .HasColumnName("il_mdate");

                entity.Property(e => e.IlMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("il_mtime");

                entity.Property(e => e.IlNumber).HasColumnName("il_number");

                entity.Property(e => e.IlReturned)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_returned");

                entity.Property(e => e.IlRowidDeTransaction).HasColumnName("il_rowid_de_transaction");

                entity.Property(e => e.IlRowidInvoice).HasColumnName("il_rowid_invoice");

                entity.Property(e => e.IlTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_tax");

                entity.Property(e => e.IlToUs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("il_to_us");

                entity.Property(e => e.IlUid).HasColumnName("il_uid");

                entity.Property(e => e.IlUidm).HasColumnName("il_uidm");

                entity.Property(e => e.IlUido).HasColumnName("il_uido");

                entity.Property(e => e.IlUido1).HasColumnName("il_uido_1");

                entity.HasOne(d => d.IlRowidDeTransactionNavigation)
                    .WithMany(p => p.InvoiceLines)
                    .HasForeignKey(d => d.IlRowidDeTransaction)
                    .HasConstraintName("FK__invoice_l__il_ro__3E1D39E1");

                entity.HasOne(d => d.IlRowidInvoiceNavigation)
                    .WithMany(p => p.InvoiceLines)
                    .HasForeignKey(d => d.IlRowidInvoice)
                    .HasConstraintName("FK__invoice_l__il_ro__3D2915A8");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.NoRowid)
                    .HasName("PK__notes__DD8F4A220E7F602B");

                entity.ToTable("notes");

                entity.Property(e => e.NoRowid).HasColumnName("no_rowid");

                entity.Property(e => e.NoRowidClient).HasColumnName("no_rowid_client");

                entity.Property(e => e.NoRowidDebtor).HasColumnName("no_rowid_debtor");

                entity.Property(e => e.NoText)
                    .HasMaxLength(160)
                    .HasColumnName("no_text");

                entity.HasOne(d => d.NoRowidClientNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.NoRowidClient)
                    .HasConstraintName("FK__notes__no_rowid___44CA3770");

                entity.HasOne(d => d.NoRowidDebtorNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.NoRowidDebtor)
                    .HasConstraintName("FK__notes__no_rowid___45BE5BA9");
            });

            modelBuilder.Entity<NxOperator>(entity =>
            {
                entity.HasKey(e => e.OpRowid)
                    .HasName("PK__nx_opera__B139D9D36A5C87CE");

                entity.ToTable("nx_operator");

                entity.HasIndex(e => e.OpColor, "op_color_key");

                entity.HasIndex(e => e.OpId, "op_id_key");

                entity.HasIndex(e => e.OpTeam, "op_team_key");

                entity.Property(e => e.OpRowid).HasColumnName("op_rowid");

                entity.Property(e => e.OpActualName)
                    .HasMaxLength(256)
                    .HasColumnName("op_actual_name");

                entity.Property(e => e.OpAddress)
                    .HasMaxLength(160)
                    .HasColumnName("op_address");

                entity.Property(e => e.OpAddress1)
                    .HasMaxLength(256)
                    .HasColumnName("op_address_1");

                entity.Property(e => e.OpCalcFlags).HasColumnName("op_calc_flags");

                entity.Property(e => e.OpCategory).HasColumnName("op_category");

                entity.Property(e => e.OpCategory1).HasColumnName("op_category_1");

                entity.Property(e => e.OpCategory2).HasColumnName("op_category_2");

                entity.Property(e => e.OpCby)
                    .HasMaxLength(16)
                    .HasColumnName("op_cby");

                entity.Property(e => e.OpCdate)
                    .HasColumnType("date")
                    .HasColumnName("op_cdate");

                entity.Property(e => e.OpCity)
                    .HasMaxLength(64)
                    .HasColumnName("op_city");

                entity.Property(e => e.OpColor)
                    .HasMaxLength(32)
                    .HasColumnName("op_color");

                entity.Property(e => e.OpComm1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_comm_1");

                entity.Property(e => e.OpComm2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_comm_2");

                entity.Property(e => e.OpComm3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_comm_3");

                entity.Property(e => e.OpComm4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_comm_4");

                entity.Property(e => e.OpCommRateOptions).HasColumnName("op_comm_rate_options");

                entity.Property(e => e.OpCommRatePlan)
                    .HasMaxLength(16)
                    .HasColumnName("op_comm_rate_plan");

                entity.Property(e => e.OpCommission)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission");

                entity.Property(e => e.OpCommission1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_1");

                entity.Property(e => e.OpCommission10)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_10");

                entity.Property(e => e.OpCommission11)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_11");

                entity.Property(e => e.OpCommission12)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_12");

                entity.Property(e => e.OpCommission13)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_13");

                entity.Property(e => e.OpCommission14)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_14");

                entity.Property(e => e.OpCommission15)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_15");

                entity.Property(e => e.OpCommission16)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_16");

                entity.Property(e => e.OpCommission2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_2");

                entity.Property(e => e.OpCommission3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_3");

                entity.Property(e => e.OpCommission4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_4");

                entity.Property(e => e.OpCommission5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_5");

                entity.Property(e => e.OpCommission6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_6");

                entity.Property(e => e.OpCommission7)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_7");

                entity.Property(e => e.OpCommission8)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_8");

                entity.Property(e => e.OpCommission9)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_commission_9");

                entity.Property(e => e.OpCountry)
                    .HasMaxLength(64)
                    .HasColumnName("op_country");

                entity.Property(e => e.OpCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("op_ctime");

                entity.Property(e => e.OpDate1)
                    .HasColumnType("date")
                    .HasColumnName("op_date1");

                entity.Property(e => e.OpDate2)
                    .HasColumnType("date")
                    .HasColumnName("op_date2");

                entity.Property(e => e.OpEmail)
                    .HasMaxLength(256)
                    .HasColumnName("op_email");

                entity.Property(e => e.OpFlags).HasColumnName("op_flags");

                entity.Property(e => e.OpFlags1).HasColumnName("op_flags1");

                entity.Property(e => e.OpFunction1).HasColumnName("op_function_1");

                entity.Property(e => e.OpFunction10).HasColumnName("op_function_10");

                entity.Property(e => e.OpFunction11).HasColumnName("op_function_11");

                entity.Property(e => e.OpFunction12).HasColumnName("op_function_12");

                entity.Property(e => e.OpFunction13).HasColumnName("op_function_13");

                entity.Property(e => e.OpFunction14).HasColumnName("op_function_14");

                entity.Property(e => e.OpFunction15).HasColumnName("op_function_15");

                entity.Property(e => e.OpFunction16).HasColumnName("op_function_16");

                entity.Property(e => e.OpFunction2).HasColumnName("op_function_2");

                entity.Property(e => e.OpFunction3).HasColumnName("op_function_3");

                entity.Property(e => e.OpFunction4).HasColumnName("op_function_4");

                entity.Property(e => e.OpFunction5).HasColumnName("op_function_5");

                entity.Property(e => e.OpFunction6).HasColumnName("op_function_6");

                entity.Property(e => e.OpFunction7).HasColumnName("op_function_7");

                entity.Property(e => e.OpFunction8).HasColumnName("op_function_8");

                entity.Property(e => e.OpFunction9).HasColumnName("op_function_9");

                entity.Property(e => e.OpGoalNumber).HasColumnName("op_goal_number");

                entity.Property(e => e.OpGoalPercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_goal_percent");

                entity.Property(e => e.OpGoalValue)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_goal_value");

                entity.Property(e => e.OpHourlyCost)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_hourly_cost");

                entity.Property(e => e.OpId)
                    .HasMaxLength(16)
                    .HasColumnName("op_id");

                entity.Property(e => e.OpImpexDat)
                    .HasMaxLength(64)
                    .HasColumnName("op_impex_dat");

                entity.Property(e => e.OpLang).HasColumnName("op_lang");

                entity.Property(e => e.OpLevel).HasColumnName("op_level");

                entity.Property(e => e.OpMailServerIp)
                    .HasMaxLength(128)
                    .HasColumnName("op_mail_server_ip");

                entity.Property(e => e.OpMailSigfile)
                    .HasMaxLength(128)
                    .HasColumnName("op_mail_sigfile");

                entity.Property(e => e.OpMaxFuture).HasColumnName("op_max_future");

                entity.Property(e => e.OpMby)
                    .HasMaxLength(16)
                    .HasColumnName("op_mby");

                entity.Property(e => e.OpMdate)
                    .HasColumnType("date")
                    .HasColumnName("op_mdate");

                entity.Property(e => e.OpMember1)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_1");

                entity.Property(e => e.OpMember10)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_10");

                entity.Property(e => e.OpMember11)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_11");

                entity.Property(e => e.OpMember12)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_12");

                entity.Property(e => e.OpMember13)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_13");

                entity.Property(e => e.OpMember14)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_14");

                entity.Property(e => e.OpMember15)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_15");

                entity.Property(e => e.OpMember16)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_16");

                entity.Property(e => e.OpMember2)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_2");

                entity.Property(e => e.OpMember3)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_3");

                entity.Property(e => e.OpMember4)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_4");

                entity.Property(e => e.OpMember5)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_5");

                entity.Property(e => e.OpMember6)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_6");

                entity.Property(e => e.OpMember7)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_7");

                entity.Property(e => e.OpMember8)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_8");

                entity.Property(e => e.OpMember9)
                    .HasMaxLength(16)
                    .HasColumnName("op_member_9");

                entity.Property(e => e.OpMoney1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_money1");

                entity.Property(e => e.OpMoney2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_money2");

                entity.Property(e => e.OpMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("op_mtime");

                entity.Property(e => e.OpName)
                    .HasMaxLength(256)
                    .HasColumnName("op_name");

                entity.Property(e => e.OpOffice)
                    .HasMaxLength(128)
                    .HasColumnName("op_office");

                entity.Property(e => e.OpOwnedByOp)
                    .HasMaxLength(16)
                    .HasColumnName("op_owned_by_op");

                entity.Property(e => e.OpPassword)
                    .HasMaxLength(48)
                    .HasColumnName("op_password");

                entity.Property(e => e.OpPer1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("op_per1");

                entity.Property(e => e.OpPhone)
                    .HasMaxLength(96)
                    .HasColumnName("op_phone");

                entity.Property(e => e.OpPhoneExt)
                    .HasMaxLength(32)
                    .HasColumnName("op_phone_ext");

                entity.Property(e => e.OpPrintViaBrowserFlag).HasColumnName("op_print_via_browser_flag");

                entity.Property(e => e.OpPrivatePhone)
                    .HasMaxLength(96)
                    .HasColumnName("op_private_phone");

                entity.Property(e => e.OpPrivatePhoneExt)
                    .HasMaxLength(32)
                    .HasColumnName("op_private_phone_ext");

                entity.Property(e => e.OpReportDat)
                    .HasMaxLength(64)
                    .HasColumnName("op_report_dat");

                entity.Property(e => e.OpState)
                    .HasMaxLength(64)
                    .HasColumnName("op_state");

                entity.Property(e => e.OpStreetNumber)
                    .HasMaxLength(48)
                    .HasColumnName("op_street_number");

                entity.Property(e => e.OpSwitches).HasColumnName("op_switches");

                entity.Property(e => e.OpSwitches1).HasColumnName("op_switches1");

                entity.Property(e => e.OpTeam).HasColumnName("op_team");

                entity.Property(e => e.OpTitle)
                    .HasMaxLength(96)
                    .HasColumnName("op_title");

                entity.Property(e => e.OpUid).HasColumnName("op_uid");

                entity.Property(e => e.OpUidm).HasColumnName("op_uidm");

                entity.Property(e => e.OpUido).HasColumnName("op_uido");

                entity.Property(e => e.OpUser1)
                    .HasMaxLength(128)
                    .HasColumnName("op_user1");

                entity.Property(e => e.OpUser2)
                    .HasMaxLength(128)
                    .HasColumnName("op_user2");

                entity.Property(e => e.OpWebPassword)
                    .HasMaxLength(256)
                    .HasColumnName("op_web_password");

                entity.Property(e => e.OpWebUsername)
                    .HasMaxLength(256)
                    .HasColumnName("op_web_username");

                entity.Property(e => e.OpZip)
                    .HasMaxLength(48)
                    .HasColumnName("op_zip");

                entity.Property(e => e.UsHelp).HasColumnName("us_help");
            });

            modelBuilder.Entity<NxUser>(entity =>
            {
                entity.HasKey(e => e.UsRowid)
                    .HasName("PK__nx_user__5ADE809C64EE3C8C");

                entity.ToTable("nx_user");

                entity.Property(e => e.UsRowid).HasColumnName("us_rowid");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.CloseDebtorThreshold).HasColumnName("close_debtor_threshold");

                entity.Property(e => e.UsAddFlags).HasColumnName("us_add_flags");

                entity.Property(e => e.UsAddType).HasColumnName("us_add_type");

                entity.Property(e => e.UsAddress)
                    .HasMaxLength(164)
                    .HasColumnName("us_address");

                entity.Property(e => e.UsAddress2)
                    .HasMaxLength(124)
                    .HasColumnName("us_address_2");

                entity.Property(e => e.UsAddress3)
                    .HasMaxLength(124)
                    .HasColumnName("us_address_3");

                entity.Property(e => e.UsCby)
                    .HasMaxLength(16)
                    .HasColumnName("us_cby");

                entity.Property(e => e.UsCdate)
                    .HasColumnType("date")
                    .HasColumnName("us_cdate");

                entity.Property(e => e.UsCell)
                    .HasMaxLength(56)
                    .HasColumnName("us_cell");

                entity.Property(e => e.UsCellExt)
                    .HasMaxLength(16)
                    .HasColumnName("us_cell_ext");

                entity.Property(e => e.UsClientType).HasColumnName("us_client_type");

                entity.Property(e => e.UsCommFlags).HasColumnName("us_comm_flags");

                entity.Property(e => e.UsCommRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_comm_rate");

                entity.Property(e => e.UsCommRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_comm_rate_1");

                entity.Property(e => e.UsCommRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_comm_rate_2");

                entity.Property(e => e.UsCommRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_comm_rate_3");

                entity.Property(e => e.UsCountry)
                    .HasMaxLength(64)
                    .HasColumnName("us_country");

                entity.Property(e => e.UsCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("us_ctime");

                entity.Property(e => e.UsDate1)
                    .HasColumnType("date")
                    .HasColumnName("us_date_1");

                entity.Property(e => e.UsDate2)
                    .HasColumnType("date")
                    .HasColumnName("us_date_2");

                entity.Property(e => e.UsDbid)
                    .HasMaxLength(32)
                    .HasColumnName("us_dbid");

                entity.Property(e => e.UsEmail)
                    .HasMaxLength(160)
                    .HasColumnName("us_email");

                entity.Property(e => e.UsFax)
                    .HasMaxLength(56)
                    .HasColumnName("us_fax");

                entity.Property(e => e.UsFaxExt)
                    .HasMaxLength(16)
                    .HasColumnName("us_fax_ext");

                entity.Property(e => e.UsFlags).HasColumnName("us_flags");

                entity.Property(e => e.UsFlags1).HasColumnName("us_flags_1");

                entity.Property(e => e.UsFlags2).HasColumnName("us_flags_2");

                entity.Property(e => e.UsGstNumber)
                    .HasMaxLength(124)
                    .HasColumnName("us_gst_number");

                entity.Property(e => e.UsMby)
                    .HasMaxLength(16)
                    .HasColumnName("us_mby");

                entity.Property(e => e.UsMdate)
                    .HasColumnType("date")
                    .HasColumnName("us_mdate");

                entity.Property(e => e.UsMoney1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_money_1");

                entity.Property(e => e.UsMoney2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_money_2");

                entity.Property(e => e.UsMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("us_mtime");

                entity.Property(e => e.UsMultiCurrency).HasColumnName("us_multi_currency");

                entity.Property(e => e.UsName)
                    .HasMaxLength(164)
                    .HasColumnName("us_name");

                entity.Property(e => e.UsNumber1).HasColumnName("us_number_1");

                entity.Property(e => e.UsNumber2).HasColumnName("us_number_2");

                entity.Property(e => e.UsNumber3).HasColumnName("us_number_3");

                entity.Property(e => e.UsOp1)
                    .HasMaxLength(16)
                    .HasColumnName("us_op_1");

                entity.Property(e => e.UsOp2)
                    .HasMaxLength(16)
                    .HasColumnName("us_op_2");

                entity.Property(e => e.UsPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_percent_1");

                entity.Property(e => e.UsPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_percent_2");

                entity.Property(e => e.UsPercent3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_percent_3");

                entity.Property(e => e.UsPhone)
                    .HasMaxLength(56)
                    .HasColumnName("us_phone");

                entity.Property(e => e.UsPhoneExt)
                    .HasMaxLength(16)
                    .HasColumnName("us_phone_ext");

                entity.Property(e => e.UsRepresentative)
                    .HasMaxLength(164)
                    .HasColumnName("us_representative");

                entity.Property(e => e.UsState)
                    .HasMaxLength(64)
                    .HasColumnName("us_state");

                entity.Property(e => e.UsStreetNo)
                    .HasMaxLength(48)
                    .HasColumnName("us_street_no");

                entity.Property(e => e.UsTaxOptions).HasColumnName("us_tax_options");

                entity.Property(e => e.UsTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_tax_rate");

                entity.Property(e => e.UsTaxRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_tax_rate_1");

                entity.Property(e => e.UsTaxRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_tax_rate_2");

                entity.Property(e => e.UsTaxRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("us_tax_rate_3");

                entity.Property(e => e.UsUid).HasColumnName("us_uid");

                entity.Property(e => e.UsUidm).HasColumnName("us_uidm");

                entity.Property(e => e.UsUido).HasColumnName("us_uido");

                entity.Property(e => e.UsUser1)
                    .HasMaxLength(128)
                    .HasColumnName("us_user_1");

                entity.Property(e => e.UsUser2)
                    .HasMaxLength(128)
                    .HasColumnName("us_user_2");

                entity.Property(e => e.UsUser3)
                    .HasMaxLength(128)
                    .HasColumnName("us_user_3");

                entity.Property(e => e.UsUser4)
                    .HasMaxLength(128)
                    .HasColumnName("us_user_4");

                entity.Property(e => e.UsZip)
                    .HasMaxLength(48)
                    .HasColumnName("us_zip");
            });

            modelBuilder.Entity<Nxday>(entity =>
            {
                entity.HasKey(e => e.DaRowid)
                    .HasName("PK__nxday__6D5388C685665335");

                entity.ToTable("nxday");

                entity.HasIndex(e => e.DaDate, "da_date_key");

                entity.Property(e => e.DaRowid).HasColumnName("da_rowid");

                entity.Property(e => e.DaAmount1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_amount_1");

                entity.Property(e => e.DaAmount2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_amount_2");

                entity.Property(e => e.DaBuffer1)
                    .HasMaxLength(510)
                    .HasColumnName("da_buffer_1");

                entity.Property(e => e.DaBuffer2)
                    .HasMaxLength(510)
                    .HasColumnName("da_buffer_2");

                entity.Property(e => e.DaCalls).HasColumnName("da_calls");

                entity.Property(e => e.DaCallsRemaining).HasColumnName("da_calls_remaining");

                entity.Property(e => e.DaCategory).HasColumnName("da_category");

                entity.Property(e => e.DaCategory1).HasColumnName("da_category_1");

                entity.Property(e => e.DaCategory2).HasColumnName("da_category_2");

                entity.Property(e => e.DaCby)
                    .HasMaxLength(16)
                    .HasColumnName("da_cby");

                entity.Property(e => e.DaCdate)
                    .HasColumnType("date")
                    .HasColumnName("da_cdate");

                entity.Property(e => e.DaClientPayments)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_client_payments");

                entity.Property(e => e.DaCommFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_fees");

                entity.Property(e => e.DaCommInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_interest");

                entity.Property(e => e.DaCommLegal).HasColumnName("da_comm_legal");

                entity.Property(e => e.DaCommMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_misc");

                entity.Property(e => e.DaCommOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_other");

                entity.Property(e => e.DaCommPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_comm_principal");

                entity.Property(e => e.DaCommission)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_commission");

                entity.Property(e => e.DaContacts).HasColumnName("da_contacts");

                entity.Property(e => e.DaCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("da_ctime");

                entity.Property(e => e.DaDate)
                    .HasColumnType("date")
                    .HasColumnName("da_date");

                entity.Property(e => e.DaDate1)
                    .HasColumnType("date")
                    .HasColumnName("da_date_1");

                entity.Property(e => e.DaDate2)
                    .HasColumnType("date")
                    .HasColumnName("da_date_2");

                entity.Property(e => e.DaDebtFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_fees");

                entity.Property(e => e.DaDebtInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_interest");

                entity.Property(e => e.DaDebtLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_legal");

                entity.Property(e => e.DaDebtMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_misc");

                entity.Property(e => e.DaDebtOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_other");

                entity.Property(e => e.DaDebtPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_debt_principal");

                entity.Property(e => e.DaFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_fees");

                entity.Property(e => e.DaFlags1).HasColumnName("da_flags_1");

                entity.Property(e => e.DaFlags2).HasColumnName("da_flags_2");

                entity.Property(e => e.DaInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_interest");

                entity.Property(e => e.DaLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_legal");

                entity.Property(e => e.DaMailings).HasColumnName("da_mailings");

                entity.Property(e => e.DaMby)
                    .HasMaxLength(16)
                    .HasColumnName("da_mby");

                entity.Property(e => e.DaMdate)
                    .HasColumnType("date")
                    .HasColumnName("da_mdate");

                entity.Property(e => e.DaMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_misc");

                entity.Property(e => e.DaMonthToDate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_month_to_date");

                entity.Property(e => e.DaMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("da_mtime");

                entity.Property(e => e.DaNumber1).HasColumnName("da_number_1");

                entity.Property(e => e.DaNumber2).HasColumnName("da_number_2");

                entity.Property(e => e.DaNumberOfListings).HasColumnName("da_number_of_listings");

                entity.Property(e => e.DaOp1)
                    .HasMaxLength(16)
                    .HasColumnName("da_op_1");

                entity.Property(e => e.DaOp2)
                    .HasMaxLength(16)
                    .HasColumnName("da_op_2");

                entity.Property(e => e.DaOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_other");

                entity.Property(e => e.DaOthers).HasColumnName("da_others");

                entity.Property(e => e.DaOthersRemaining).HasColumnName("da_others_remaining");

                entity.Property(e => e.DaPaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_paid");

                entity.Property(e => e.DaPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_percent_1");

                entity.Property(e => e.DaPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_percent_2");

                entity.Property(e => e.DaPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_principal");

                entity.Property(e => e.DaPromised)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_promised");

                entity.Property(e => e.DaRemainingContacts).HasColumnName("da_remaining_contacts");

                entity.Property(e => e.DaRemainingMailings).HasColumnName("da_remaining_mailings");

                entity.Property(e => e.DaReviews).HasColumnName("da_reviews");

                entity.Property(e => e.DaReviewsRemaining).HasColumnName("da_reviews_remaining");

                entity.Property(e => e.DaTaxFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_fees");

                entity.Property(e => e.DaTaxInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_interest");

                entity.Property(e => e.DaTaxLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_legal");

                entity.Property(e => e.DaTaxMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_misc");

                entity.Property(e => e.DaTaxOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_other");

                entity.Property(e => e.DaTaxPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_tax_principal");

                entity.Property(e => e.DaTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_total");

                entity.Property(e => e.DaTotalListed)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("da_total_listed");

                entity.Property(e => e.DaUid).HasColumnName("da_uid");

                entity.Property(e => e.DaUidm).HasColumnName("da_uidm");
            });

            modelBuilder.Entity<OperatorLevel>(entity =>
            {
                entity.HasKey(e => e.LeRowid)
                    .HasName("PK__operator__BC745519A41C4B72");

                entity.ToTable("operator_level");

                entity.Property(e => e.LeRowid).HasColumnName("le_rowid");

                entity.Property(e => e.LeCby)
                    .HasMaxLength(16)
                    .HasColumnName("le_cby");

                entity.Property(e => e.LeCdate)
                    .HasColumnType("date")
                    .HasColumnName("le_cdate");

                entity.Property(e => e.LeCode).HasColumnName("le_code");

                entity.Property(e => e.LeCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("le_ctime");

                entity.Property(e => e.LeDescription)
                    .HasMaxLength(84)
                    .HasColumnName("le_description");

                entity.Property(e => e.LeDiarizationLimit).HasColumnName("le_diarization_limit");

                entity.Property(e => e.LeMby)
                    .HasMaxLength(16)
                    .HasColumnName("le_mby");

                entity.Property(e => e.LeMdate)
                    .HasColumnType("date")
                    .HasColumnName("le_mdate");

                entity.Property(e => e.LeMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("le_mtime");

                entity.Property(e => e.LeUid).HasColumnName("le_uid");

                entity.Property(e => e.LeUidm).HasColumnName("le_uidm");

                entity.Property(e => e.LeUido).HasColumnName("le_uido");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasKey(e => e.PhRowid)
                    .HasName("PK__phone__965FCA89D76310A3");

                entity.ToTable("phone");

                entity.HasIndex(e => e.PhCategory, "ph_category_key");

                entity.HasIndex(e => e.PhRowidAssociated, "ph_rowid_associated_key");

                entity.HasIndex(e => e.PhRowidBank, "ph_rowid_bank_key");

                entity.HasIndex(e => e.PhRowidClient, "ph_rowid_client_key");

                entity.HasIndex(e => e.PhRowidCosigner, "ph_rowid_cosigner_key");

                entity.HasIndex(e => e.PhRowidDebtor, "ph_rowid_debtor_key");

                entity.Property(e => e.PhRowid).HasColumnName("ph_rowid");

                entity.Property(e => e.PhCategory).HasColumnName("ph_category");

                entity.Property(e => e.PhCategory1).HasColumnName("ph_category_1");

                entity.Property(e => e.PhCategory2).HasColumnName("ph_category_2");

                entity.Property(e => e.PhCby)
                    .HasMaxLength(16)
                    .HasColumnName("ph_cby");

                entity.Property(e => e.PhCdate)
                    .HasColumnType("date")
                    .HasColumnName("ph_cdate");

                entity.Property(e => e.PhCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_ctime");

                entity.Property(e => e.PhDateReceived)
                    .HasColumnType("date")
                    .HasColumnName("ph_date_received");

                entity.Property(e => e.PhExtension)
                    .HasMaxLength(16)
                    .HasColumnName("ph_extension");

                entity.Property(e => e.PhFlags).HasColumnName("ph_flags");

                entity.Property(e => e.PhMby)
                    .HasMaxLength(16)
                    .HasColumnName("ph_mby");

                entity.Property(e => e.PhMdate)
                    .HasColumnType("date")
                    .HasColumnName("ph_mdate");

                entity.Property(e => e.PhMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_mtime");

                entity.Property(e => e.PhNisDate)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_NIS_date");

                entity.Property(e => e.PhNisId).HasColumnName("ph_NIS_id");

                entity.Property(e => e.PhNisReason).HasColumnName("ph_NIS_reason");

                entity.Property(e => e.PhNumber)
                    .HasMaxLength(48)
                    .HasColumnName("ph_number");

                entity.Property(e => e.PhNumber1).HasColumnName("ph_number_1");

                entity.Property(e => e.PhNumber2).HasColumnName("ph_number_2");

                entity.Property(e => e.PhRowidAssociated).HasColumnName("ph_rowid_associated");

                entity.Property(e => e.PhRowidBank).HasColumnName("ph_rowid_bank");

                entity.Property(e => e.PhRowidClient).HasColumnName("ph_rowid_client");

                entity.Property(e => e.PhRowidCosigner).HasColumnName("ph_rowid_cosigner");

                entity.Property(e => e.PhRowidDebtor).HasColumnName("ph_rowid_debtor");

                entity.Property(e => e.PhSource).HasColumnName("ph_source");

                entity.Property(e => e.PhTimeFrom)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_time_from");

                entity.Property(e => e.PhTimeTo)
                    .HasColumnType("time(0)")
                    .HasColumnName("ph_time_to");

                entity.Property(e => e.PhTimezone).HasColumnName("ph_timezone");

                entity.Property(e => e.PhType).HasColumnName("ph_type");

                entity.Property(e => e.PhUid).HasColumnName("ph_uid");

                entity.Property(e => e.PhUidm).HasColumnName("ph_uidm");

                entity.Property(e => e.PhUido).HasColumnName("ph_uido");

                entity.Property(e => e.PhUido1).HasColumnName("ph_uido_1");

                entity.Property(e => e.PhUido2).HasColumnName("ph_uido_2");

                entity.Property(e => e.PhUido3).HasColumnName("ph_uido_3");

                entity.Property(e => e.PhUido4).HasColumnName("ph_uido_4");

                entity.Property(e => e.PhUser1)
                    .HasMaxLength(60)
                    .HasColumnName("ph_user1");

                entity.Property(e => e.PhUser2)
                    .HasMaxLength(60)
                    .HasColumnName("ph_user2");

                entity.HasOne(d => d.PhRowidAssociatedNavigation)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.PhRowidAssociated)
                    .HasConstraintName("FK__phone__ph_rowid___55F4C372");

                entity.HasOne(d => d.PhRowidBankNavigation)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.PhRowidBank)
                    .HasConstraintName("FK__phone__ph_rowid___5224328E");

                entity.HasOne(d => d.PhRowidClientNavigation)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.PhRowidClient)
                    .HasConstraintName("FK__phone__ph_rowid___531856C7");

                entity.HasOne(d => d.PhRowidCosignerNavigation)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.PhRowidCosigner)
                    .HasConstraintName("FK__phone__ph_rowid___55009F39");

                entity.HasOne(d => d.PhRowidDebtorNavigation)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.PhRowidDebtor)
                    .HasConstraintName("FK__phone__ph_rowid___540C7B00");
            });

            modelBuilder.Entity<RateTable>(entity =>
            {
                entity.HasKey(e => e.RtRowid)
                    .HasName("PK__rate_tab__CBAD0E9726EDFA82");

                entity.ToTable("rate_table");

                entity.HasIndex(e => e.RtId, "rt_id_key");

                entity.Property(e => e.RtRowid).HasColumnName("rt_rowid");

                entity.Property(e => e.RtCby)
                    .HasMaxLength(16)
                    .HasColumnName("rt_cby");

                entity.Property(e => e.RtCdate)
                    .HasColumnType("date")
                    .HasColumnName("rt_cdate");

                entity.Property(e => e.RtCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("rt_ctime");

                entity.Property(e => e.RtDescription)
                    .HasMaxLength(84)
                    .HasColumnName("rt_description");

                entity.Property(e => e.RtExtra1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_extra_1");

                entity.Property(e => e.RtExtra2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_extra_2");

                entity.Property(e => e.RtExtra3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_extra_3");

                entity.Property(e => e.RtExtra4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_extra_4");

                entity.Property(e => e.RtExtra5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_extra_5");

                entity.Property(e => e.RtExtra6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_extra_6");

                entity.Property(e => e.RtFlag1).HasColumnName("rt_flag_1");

                entity.Property(e => e.RtFlag2).HasColumnName("rt_flag_2");

                entity.Property(e => e.RtFlag3).HasColumnName("rt_flag_3");

                entity.Property(e => e.RtFlag4).HasColumnName("rt_flag_4");

                entity.Property(e => e.RtFlag5).HasColumnName("rt_flag_5");

                entity.Property(e => e.RtFlag6).HasColumnName("rt_flag_6");

                entity.Property(e => e.RtFrom1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_from_1");

                entity.Property(e => e.RtFrom2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_from_2");

                entity.Property(e => e.RtFrom3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_from_3");

                entity.Property(e => e.RtFrom4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_from_4");

                entity.Property(e => e.RtFrom5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_from_5");

                entity.Property(e => e.RtFrom6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_from_6");

                entity.Property(e => e.RtId)
                    .HasMaxLength(16)
                    .HasColumnName("rt_id");

                entity.Property(e => e.RtMax1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_max_1");

                entity.Property(e => e.RtMax2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_max_2");

                entity.Property(e => e.RtMax3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_max_3");

                entity.Property(e => e.RtMax4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_max_4");

                entity.Property(e => e.RtMax5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_max_5");

                entity.Property(e => e.RtMax6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_max_6");

                entity.Property(e => e.RtMby)
                    .HasMaxLength(16)
                    .HasColumnName("rt_mby");

                entity.Property(e => e.RtMdate)
                    .HasColumnType("date")
                    .HasColumnName("rt_mdate");

                entity.Property(e => e.RtMin1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_min_1");

                entity.Property(e => e.RtMin2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_min_2");

                entity.Property(e => e.RtMin3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_min_3");

                entity.Property(e => e.RtMin4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_min_4");

                entity.Property(e => e.RtMin5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_min_5");

                entity.Property(e => e.RtMin6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_min_6");

                entity.Property(e => e.RtMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("rt_mtime");

                entity.Property(e => e.RtRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_rate_1");

                entity.Property(e => e.RtRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_rate_2");

                entity.Property(e => e.RtRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_rate_3");

                entity.Property(e => e.RtRate4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_rate_4");

                entity.Property(e => e.RtRate5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_rate_5");

                entity.Property(e => e.RtRate6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_rate_6");

                entity.Property(e => e.RtTo1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_to_1");

                entity.Property(e => e.RtTo2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_to_2");

                entity.Property(e => e.RtTo3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_to_3");

                entity.Property(e => e.RtTo4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_to_4");

                entity.Property(e => e.RtTo5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_to_5");

                entity.Property(e => e.RtTo6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rt_to_6");

                entity.Property(e => e.RtType).HasColumnName("rt_type");

                entity.Property(e => e.RtUid).HasColumnName("rt_uid");

                entity.Property(e => e.RtUidm).HasColumnName("rt_uidm");

                entity.Property(e => e.RtUido).HasColumnName("rt_uido");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("states");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_states_countries");
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.HasKey(e => e.TtRowid)
                    .HasName("PK__transact__7A68D5C6E0A35006");

                entity.ToTable("transaction_type");

                entity.HasIndex(e => e.TtCategory1, "tt_category_1_key");

                entity.HasIndex(e => e.TtCategory, "tt_category_key");

                entity.HasIndex(e => e.TtCode, "tt_code_key");

                entity.Property(e => e.TtRowid).HasColumnName("tt_rowid");

                entity.Property(e => e.TtAccount).HasColumnName("tt_account");

                entity.Property(e => e.TtAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_adjustment");

                entity.Property(e => e.TtAssignmentFlag).HasColumnName("tt_assignment_flag");

                entity.Property(e => e.TtCalcType).HasColumnName("tt_calc_type");

                entity.Property(e => e.TtCategory).HasColumnName("tt_category");

                entity.Property(e => e.TtCategory1).HasColumnName("tt_category_1");

                entity.Property(e => e.TtCategory2).HasColumnName("tt_category_2");

                entity.Property(e => e.TtCby)
                    .HasMaxLength(16)
                    .HasColumnName("tt_cby");

                entity.Property(e => e.TtCdate)
                    .HasColumnType("date")
                    .HasColumnName("tt_cdate");

                entity.Property(e => e.TtCode)
                    .HasMaxLength(20)
                    .HasColumnName("tt_code");

                entity.Property(e => e.TtCommRateFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_comm_rate_fees");

                entity.Property(e => e.TtCommRateInt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_comm_rate_int");

                entity.Property(e => e.TtCommRateLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_comm_rate_legal");

                entity.Property(e => e.TtCommRateMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_comm_rate_misc");

                entity.Property(e => e.TtCommRateOptions).HasColumnName("tt_comm_rate_options");

                entity.Property(e => e.TtCommRateOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_comm_rate_other");

                entity.Property(e => e.TtCommRatePrinc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_comm_rate_princ");

                entity.Property(e => e.TtCommission)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_commission");

                entity.Property(e => e.TtCommissionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_commission_rate");

                entity.Property(e => e.TtCommissionRate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_commission_rate_1");

                entity.Property(e => e.TtCommissionRate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_commission_rate_2");

                entity.Property(e => e.TtCommissionRate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_commission_rate_3");

                entity.Property(e => e.TtCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tt_ctime");

                entity.Property(e => e.TtDate1)
                    .HasColumnType("date")
                    .HasColumnName("tt_date_1");

                entity.Property(e => e.TtDate2)
                    .HasColumnType("date")
                    .HasColumnName("tt_date_2");

                entity.Property(e => e.TtDepositTo)
                    .HasMaxLength(16)
                    .HasColumnName("tt_deposit_to");

                entity.Property(e => e.TtDescription)
                    .HasMaxLength(160)
                    .HasColumnName("tt_description");

                entity.Property(e => e.TtDirect)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_direct");

                entity.Property(e => e.TtFees)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_fees");

                entity.Property(e => e.TtFlags).HasColumnName("tt_flags");

                entity.Property(e => e.TtFlags1).HasColumnName("tt_flags_1");

                entity.Property(e => e.TtFlags2).HasColumnName("tt_flags_2");

                entity.Property(e => e.TtHideTousDirect).HasColumnName("tt_hide_tous_direct");

                entity.Property(e => e.TtInterest)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_interest");

                entity.Property(e => e.TtLegal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_legal");

                entity.Property(e => e.TtMby)
                    .HasMaxLength(16)
                    .HasColumnName("tt_mby");

                entity.Property(e => e.TtMdate)
                    .HasColumnType("date")
                    .HasColumnName("tt_mdate");

                entity.Property(e => e.TtMisc)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_misc");

                entity.Property(e => e.TtMtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tt_mtime");

                entity.Property(e => e.TtNumber1).HasColumnName("tt_number_1");

                entity.Property(e => e.TtNumber2).HasColumnName("tt_number_2");

                entity.Property(e => e.TtOp1)
                    .HasMaxLength(16)
                    .HasColumnName("tt_op_1");

                entity.Property(e => e.TtOp2)
                    .HasMaxLength(16)
                    .HasColumnName("tt_op_2");

                entity.Property(e => e.TtOperator)
                    .HasMaxLength(16)
                    .HasColumnName("tt_operator");

                entity.Property(e => e.TtOptions).HasColumnName("tt_options");

                entity.Property(e => e.TtOther)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_other");

                entity.Property(e => e.TtPercent1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_percent_1");

                entity.Property(e => e.TtPercent2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_percent_2");

                entity.Property(e => e.TtPlan)
                    .HasMaxLength(16)
                    .HasColumnName("tt_plan");

                entity.Property(e => e.TtPrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_principal");

                entity.Property(e => e.TtSales)
                    .HasMaxLength(16)
                    .HasColumnName("tt_sales");

                entity.Property(e => e.TtTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_tax");

                entity.Property(e => e.TtTax1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_tax_1");

                entity.Property(e => e.TtTax2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_tax_2");

                entity.Property(e => e.TtTax3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_tax_3");

                entity.Property(e => e.TtTaxOptions).HasColumnName("tt_tax_options");

                entity.Property(e => e.TtToAgency)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("tt_to_agency");

                entity.Property(e => e.TtUid).HasColumnName("tt_uid");

                entity.Property(e => e.TtUidm).HasColumnName("tt_uidm");

                entity.Property(e => e.TtWithdrawFrom)
                    .HasMaxLength(16)
                    .HasColumnName("tt_withdraw_from");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

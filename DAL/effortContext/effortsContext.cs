using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.effortdb;

namespace DAL.effortContext
{
    public partial class effortsContext : DbContext
    {
        public effortsContext()
        {
        }

        public effortsContext(DbContextOptions<effortsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acr> Acrs { get; set; } = null!;
        public virtual DbSet<Acr2> Acr2s { get; set; } = null!;
        public virtual DbSet<BackupPrmscld> BackupPrmsclds { get; set; } = null!;
        public virtual DbSet<InvalidNumbersDataset> InvalidNumbersDatasets { get; set; } = null!;
        public virtual DbSet<OpGoal> OpGoals { get; set; } = null!;
        public virtual DbSet<Promiseclosed> Promisecloseds { get; set; } = null!;
        public virtual DbSet<PromiseclosedBtw1322> PromiseclosedBtw1322s { get; set; } = null!;
        public virtual DbSet<Promiseclosedddd> Promiseclosedddds { get; set; } = null!;
        public virtual DbSet<Rcvd> Rcvds { get; set; } = null!;
        public virtual DbSet<Sendgrid> Sendgrids { get; set; } = null!;
        public virtual DbSet<Sendgridall> Sendgridalls { get; set; } = null!;
        public virtual DbSet<Sm> Sms { get; set; } = null!;
        public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Thrio> Thrios { get; set; } = null!;
        public virtual DbSet<Thrio1> Thrio1s { get; set; } = null!;
        public virtual DbSet<Vm> Vms { get; set; } = null!;
        public virtual DbSet<WhatsappCampaign> WhatsappCampaigns { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.20.90;Database=efforts;User Id=root;password=Qwerty1234567890;Trusted_Connection = False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACR");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.AmountDue).HasColumnName("AMOUNT_DUE");

                entity.Property(e => e.ArUserNotes)
                    .IsUnicode(false)
                    .HasColumnName("AR_USER_NOTES");

                entity.Property(e => e.CustomerCategory)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_CATEGORY");

                entity.Property(e => e.CustomerDebtorFile)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Debtor_File");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.InvoiceNumber)
                    .IsUnicode(false)
                    .HasColumnName("INVOICE_NUMBER");

                entity.Property(e => e.TotalAmount).HasColumnName("TOTAL_AMOUNT");

                entity.Property(e => e.TransactionType)
                    .IsUnicode(false)
                    .HasColumnName("Transaction_Type");
            });

            modelBuilder.Entity<Acr2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACR2");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.AmountDue).HasColumnName("AMOUNT_DUE");

                entity.Property(e => e.ArUserNotes)
                    .IsUnicode(false)
                    .HasColumnName("AR_USER_NOTES");

                entity.Property(e => e.CustomerCategory)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_CATEGORY");

                entity.Property(e => e.CustomerDebtorFile)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Debtor-File");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.InvoiceNumber)
                    .IsUnicode(false)
                    .HasColumnName("INVOICE_NUMBER");

                entity.Property(e => e.TotalAmount).HasColumnName("TOTAL_AMOUNT");

                entity.Property(e => e.TransactionType)
                    .IsUnicode(false)
                    .HasColumnName("Transaction_Type");
            });

            modelBuilder.Entity<BackupPrmscld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("backup_Prmscld");

                entity.Property(e => e.By)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PromiseDate).HasColumnType("date");
            });

            modelBuilder.Entity<InvalidNumbersDataset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invalid_Numbers_dataset");

                entity.Property(e => e.Dispos)
                    .HasMaxLength(50)
                    .HasColumnName("dispos");

                entity.Property(e => e.EffortNumber).HasColumnName("effort_number");

                entity.Property(e => e.Filenumber).HasColumnName("filenumber");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<OpGoal>(entity =>
            {
                entity.HasKey(e => e.OgRowid)
                    .HasName("PK__op_goals__5AAA47E5C752009C");

                entity.ToTable("op_goals");

                entity.Property(e => e.OgRowid).HasColumnName("og_rowid");

                entity.Property(e => e.OgDate)
                    .HasColumnType("date")
                    .HasColumnName("og_date");

                entity.Property(e => e.OgGoal).HasColumnName("og_goal");

                entity.Property(e => e.OgOperator)
                    .HasMaxLength(256)
                    .HasColumnName("og_operator");
            });

            modelBuilder.Entity<Promiseclosed>(entity =>
            {
                entity.ToTable("Promiseclosed");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.By)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PromiseDate).HasColumnType("date");
            });

            modelBuilder.Entity<PromiseclosedBtw1322>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("promiseclosed_btw_13_22");

                entity.Property(e => e.By)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PromiseDate).HasColumnType("date");
            });

            modelBuilder.Entity<Promiseclosedddd>(entity =>
            {
                entity.ToTable("Promiseclosedddd");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.By)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PromiseDate).HasColumnType("date");
            });

            modelBuilder.Entity<Rcvd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rcvd");

                entity.Property(e => e.AdvanceOverpayments)
                    .HasMaxLength(255)
                    .HasColumnName("Advance_overpayments");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AssignedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Assigned_by");

                entity.Property(e => e.Attachment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.C1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.C2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.C3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cby).HasMaxLength(255);

                entity.Property(e => e.Class).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Client).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientAccount)
                    .HasMaxLength(255)
                    .HasColumnName("Client_Account_#");

                entity.Property(e => e.Collector).HasMaxLength(255);

                entity.Property(e => e.Completed).HasMaxLength(255);

                entity.Property(e => e.Copy).HasMaxLength(255);

                entity.Property(e => e.CreateCopyOnRepeat)
                    .HasMaxLength(255)
                    .HasColumnName("Create_copy_on_repeat");

                entity.Property(e => e.Created).HasColumnType("date");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("Created_date");

                entity.Property(e => e.CreatedTime).HasColumnName("Created_time");

                entity.Property(e => e.Date1)
                    .HasColumnType("date")
                    .HasColumnName("Date_1");

                entity.Property(e => e.Date2)
                    .HasColumnType("date")
                    .HasColumnName("Date_2");

                entity.Property(e => e.Day).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Dl)
                    .HasMaxLength(255)
                    .HasColumnName("DL");

                entity.Property(e => e.DoNotAutodelete)
                    .HasMaxLength(255)
                    .HasColumnName("Do_not_autodelete");

                entity.Property(e => e.Done).HasMaxLength(255);

                entity.Property(e => e.DoneBy)
                    .HasMaxLength(255)
                    .HasColumnName("Done_by");

                entity.Property(e => e.DoneDate)
                    .HasColumnType("date")
                    .HasColumnName("Done_date");

                entity.Property(e => e.DoneTime).HasColumnName("Done_time");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("Due_date");

                entity.Property(e => e.Elapsed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Estimate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.File).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(255)
                    .HasColumnName("Home_Phone");

                entity.Property(e => e.InProgress)
                    .HasMaxLength(255)
                    .HasColumnName("In_progress");

                entity.Property(e => e.LogRepeatToNotes)
                    .HasMaxLength(255)
                    .HasColumnName("Log_repeat_to_notes");

                entity.Property(e => e.Mby).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("date");

                entity.Property(e => e.NoAutocomplete)
                    .HasMaxLength(255)
                    .HasColumnName("No_autocomplete");

                entity.Property(e => e.NumberOfDays)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Number_of_days");

                entity.Property(e => e.NumberOfPayments)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Number_of_payments");

                entity.Property(e => e.Originator).HasMaxLength(255);

                entity.Property(e => e.Processed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Promised).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RcvdStatus)
                    .HasMaxLength(255)
                    .HasColumnName("RCVD_Status");

                entity.Property(e => e.RecordEventHistory)
                    .HasMaxLength(255)
                    .HasColumnName("Record_event_history");

                entity.Property(e => e.Repeat).HasMaxLength(255);

                entity.Property(e => e.RunPlanOnCompletion)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Run_plan_on_completion");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(255)
                    .HasColumnName("SSN");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.Time).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.Uid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UID");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(255)
                    .HasColumnName("Work_Phone");
            });

            modelBuilder.Entity<Sendgrid>(entity =>
            {
                entity.ToTable("sendgrid");

                entity.HasIndex(e => e.Email, "email_key");

                entity.HasIndex(e => e.FileNum, "file_num_key");

                entity.HasIndex(e => e.Email, "idx_sendgrid_email");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiKeyId)
                    .HasMaxLength(255)
                    .HasColumnName("api_key_id");

                entity.Property(e => e.AsmGroupId).HasColumnName("asm_group_id");

                entity.Property(e => e.Attempt)
                    .HasMaxLength(255)
                    .HasColumnName("attempt");

                entity.Property(e => e.Categories)
                    .HasMaxLength(255)
                    .HasColumnName("categories");

                entity.Property(e => e.CredentialId)
                    .HasMaxLength(255)
                    .HasColumnName("credential_id");

                entity.Property(e => e.DeGroupId).HasColumnName("de_group_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Event)
                    .HasMaxLength(255)
                    .HasColumnName("event");

                entity.Property(e => e.FileNum).HasColumnName("File_num");

                entity.Property(e => e.From)
                    .HasMaxLength(255)
                    .HasColumnName("from");

                entity.Property(e => e.IsUnique)
                    .HasMaxLength(10)
                    .HasColumnName("is_unique");

                entity.Property(e => e.MarketingCampaignId).HasColumnName("marketing_campaign_id");

                entity.Property(e => e.MarketingCampaignName)
                    .HasMaxLength(255)
                    .HasColumnName("marketing_campaign_name");

                entity.Property(e => e.MarketingCampaignSplitId)
                    .HasMaxLength(255)
                    .HasColumnName("marketing_campaign_split_id");

                entity.Property(e => e.MarketingCampaignVersion)
                    .HasMaxLength(255)
                    .HasColumnName("marketing_campaign_version");

                entity.Property(e => e.MessageId)
                    .HasMaxLength(255)
                    .HasColumnName("message_id");

                entity.Property(e => e.Mx)
                    .HasMaxLength(255)
                    .HasColumnName("mx");

                entity.Property(e => e.OriginatingIp)
                    .HasMaxLength(255)
                    .HasColumnName("originating_ip");

                entity.Property(e => e.OutboundIp)
                    .HasMaxLength(255)
                    .HasColumnName("outbound_ip");

                entity.Property(e => e.OutboundIpType)
                    .HasMaxLength(255)
                    .HasColumnName("outbound_ip_type");

                entity.Property(e => e.Processed).HasColumnName("processed");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.RecvMessageId)
                    .HasMaxLength(255)
                    .HasColumnName("recv_message_id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .HasColumnName("subject");

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(255)
                    .HasColumnName("template_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UniqueArgs).HasColumnName("unique_args");

                entity.Property(e => e.Url)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.UserAgent)
                    .IsUnicode(false)
                    .HasColumnName("user_agent");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Sendgridall>(entity =>
            {
                entity.ToTable("sendgridall");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Click).HasColumnName("click");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasColumnName("email");

                entity.Property(e => e.FileNum).HasColumnName("file_num");

                entity.Property(e => e.GrandTotal).HasColumnName("Grand_Total");

                entity.Property(e => e.Open).HasColumnName("open");
            });

            modelBuilder.Entity<Sm>(entity =>
            {
                entity.ToTable("SMS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColAcct).HasColumnName("COL_Acct");

                entity.Property(e => e.ColClient)
                    .HasMaxLength(255)
                    .HasColumnName("COL_Client");

                entity.Property(e => e.ColClientNumber)
                    .HasMaxLength(255)
                    .HasColumnName("COL_ClientNumber");

                entity.Property(e => e.ColNameFirst)
                    .HasMaxLength(255)
                    .HasColumnName("COL_NameFirst");

                entity.Property(e => e.ColPhoneHome)
                    .HasMaxLength(255)
                    .HasColumnName("COL_PhoneHome");

                entity.Property(e => e.ColType).HasColumnName("COL_Type");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Template).HasMaxLength(255);
            });

            modelBuilder.Entity<Sysdiagram>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK__sysdiagr__C2B05B61B144118F");

                entity.ToTable("sysdiagrams");

                entity.HasIndex(e => new { e.PrincipalId, e.Name }, "UK_principal_name")
                    .IsUnique();

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test");

                entity.Property(e => e.AbandonTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Abandon Time\"");

                entity.Property(e => e.Agent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Agent\"");

                entity.Property(e => e.CallId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Call Id\"");

                entity.Property(e => e.CreatedAt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Created At\"");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Disposition\"");

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Duration\"");

                entity.Property(e => e.FileNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("file_num");

                entity.Property(e => e.From)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"From\"");

                entity.Property(e => e.HandleTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Handle Time\"");

                entity.Property(e => e.HoldTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Hold Time\"");

                entity.Property(e => e.InReviewTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"In Review Time\"");

                entity.Property(e => e.IvrTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"IVR Time\"");

                entity.Property(e => e.Minutes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Minutes\"");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Name\"");

                entity.Property(e => e.Queue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Queue\"");

                entity.Property(e => e.RingTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Ring Time\"");

                entity.Property(e => e.TalkTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Talk Time\"");

                entity.Property(e => e.To)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"To\"");

                entity.Property(e => e.Total)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Total\"");

                entity.Property(e => e.TotalQueueTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Total Queue Time\"");

                entity.Property(e => e.Transferred)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Transferred\"");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Type\"");

                entity.Property(e => e.WrapupTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Wrapup Time\"");
            });

            modelBuilder.Entity<Thrio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("thrio");

                entity.Property(e => e.AbandonTime)
                    .HasMaxLength(255)
                    .HasColumnName("Abandon_Time");

                entity.Property(e => e.Agent).HasMaxLength(255);

                entity.Property(e => e.CallId)
                    .HasMaxLength(255)
                    .HasColumnName("Call_Id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_At");

                entity.Property(e => e.Disposition).HasMaxLength(255);

                entity.Property(e => e.Duration).HasMaxLength(255);

                entity.Property(e => e.FileNum).HasColumnName("File_num");

                entity.Property(e => e.From).HasMaxLength(255);

                entity.Property(e => e.HandleTime)
                    .HasMaxLength(255)
                    .HasColumnName("Handle_Time");

                entity.Property(e => e.HoldTime)
                    .HasMaxLength(255)
                    .HasColumnName("Hold_Time");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InReviewTime)
                    .HasMaxLength(255)
                    .HasColumnName("In_Review_Time");

                entity.Property(e => e.IvrTime)
                    .HasMaxLength(255)
                    .HasColumnName("IVR_Time");

                entity.Property(e => e.ModFrom)
                    .HasMaxLength(255)
                    .HasColumnName("mod_from");

                entity.Property(e => e.ModTo)
                    .HasMaxLength(255)
                    .HasColumnName("mod_to");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Queue).HasMaxLength(255);

                entity.Property(e => e.RingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Ring_Time");

                entity.Property(e => e.TalkTime)
                    .HasMaxLength(255)
                    .HasColumnName("Talk_Time");

                entity.Property(e => e.To).HasMaxLength(255);

                entity.Property(e => e.TotalQueueTime)
                    .HasMaxLength(255)
                    .HasColumnName("Total_Queue_Time");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.WrapupTime)
                    .HasMaxLength(255)
                    .HasColumnName("Wrapup_Time");
            });

            modelBuilder.Entity<Thrio1>(entity =>
            {
                entity.ToTable("thrio1");

                entity.HasIndex(e => e.FileNum, "file_num_key");

                entity.HasIndex(e => e.From, "from_key");

                entity.HasIndex(e => e.To, "to_key");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbandonTime)
                    .HasMaxLength(255)
                    .HasColumnName("Abandon_Time");

                entity.Property(e => e.Agent).HasMaxLength(255);

                entity.Property(e => e.CallId)
                    .HasMaxLength(255)
                    .HasColumnName("Call_Id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_At");

                entity.Property(e => e.DeGroupId).HasColumnName("de_group_id");

                entity.Property(e => e.Disposition).HasMaxLength(255);

                entity.Property(e => e.Duration).HasMaxLength(255);

                entity.Property(e => e.FileNum).HasColumnName("File_num");

                entity.Property(e => e.From).HasMaxLength(255);

                entity.Property(e => e.HandleTime)
                    .HasMaxLength(255)
                    .HasColumnName("Handle_Time");

                entity.Property(e => e.HoldTime)
                    .HasMaxLength(255)
                    .HasColumnName("Hold_Time");

                entity.Property(e => e.InReviewTime)
                    .HasMaxLength(255)
                    .HasColumnName("In_Review_Time");

                entity.Property(e => e.IvrTime)
                    .HasMaxLength(255)
                    .HasColumnName("IVR_Time");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Queue).HasMaxLength(255);

                entity.Property(e => e.RingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Ring_Time");

                entity.Property(e => e.TalkTime)
                    .HasMaxLength(255)
                    .HasColumnName("Talk_Time");

                entity.Property(e => e.To).HasMaxLength(255);

                entity.Property(e => e.TotalQueueTime)
                    .HasMaxLength(255)
                    .HasColumnName("Total_Queue_Time");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.WrapupTime)
                    .HasMaxLength(255)
                    .HasColumnName("Wrapup_Time");
            });

            modelBuilder.Entity<Vm>(entity =>
            {
                entity.ToTable("vm");

                entity.HasIndex(e => e.CallTo, "call_to_key");

                entity.HasIndex(e => e.FileNum, "file_num_key");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Audio).HasMaxLength(255);

                entity.Property(e => e.CallTime).HasColumnName("call_time");

                entity.Property(e => e.CallTo).HasColumnName("Call_To");

                entity.Property(e => e.CallerId).HasColumnName("Caller_Id");

                entity.Property(e => e.Carrier).HasMaxLength(255);

                entity.Property(e => e.CarrierType)
                    .HasMaxLength(255)
                    .HasColumnName("Carrier_Type");

                entity.Property(e => e.DeGroupId).HasColumnName("de_group_id");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Delivery_Status");

                entity.Property(e => e.FileNum).HasColumnName("File_num");

                entity.Property(e => e.ReasonForFailure)
                    .HasMaxLength(255)
                    .HasColumnName("Reason_for_Failure");
            });

            modelBuilder.Entity<WhatsappCampaign>(entity =>
            {
                entity.ToTable("whatsapp_campaign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColAcct)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_Acct");

                entity.Property(e => e.ColClient).HasColumnName("COL_Client");

                entity.Property(e => e.ColClientNumber).HasColumnName("COL_ClientNumber");

                entity.Property(e => e.ColEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_Email");

                entity.Property(e => e.ColFileNumber).HasColumnName("COL_FileNumber");

                entity.Property(e => e.ColListed).HasColumnName("COL_Listed");

                entity.Property(e => e.ColNameFirst)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_NameFirst");

                entity.Property(e => e.ColNameLast)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_NameLast");

                entity.Property(e => e.ColOwing).HasColumnName("COL_Owing");

                entity.Property(e => e.ColPhoneCell)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_PhoneCell");

                entity.Property(e => e.ColPhoneHome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_PhoneHome");

                entity.Property(e => e.ColPhoneOther)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_PhoneOther");

                entity.Property(e => e.ColPhonePoe).HasColumnName("COL_PhonePOE#");

                entity.Property(e => e.ColStates)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_States");

                entity.Property(e => e.ColStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_Status");

                entity.Property(e => e.ColType).HasColumnName("COL_Type");

                entity.Property(e => e.ColZipCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COL_ZipCode");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ListName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("List_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.aPortalModel;

namespace DAL.aPortalContext
{
    public partial class aPortalContext : DbContext
    {
        public aPortalContext()
        {
        }

        public aPortalContext(DbContextOptions<aPortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<APromise> APromises { get; set; } = null!;
        public virtual DbSet<AcknoledgmentTable> AcknoledgmentTables { get; set; } = null!;
        public virtual DbSet<AgentsAndManager> AgentsAndManagers { get; set; } = null!;
        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; } = null!;
        public virtual DbSet<BprFile> BprFiles { get; set; } = null!;
        public virtual DbSet<CareemTable> CareemTables { get; set; } = null!;
        public virtual DbSet<CareemTablePre> CareemTablePres { get; set; } = null!;
        public virtual DbSet<CartClientInfo> CartClientInfos { get; set; } = null!;
        public virtual DbSet<CedarOperator> CedarOperators { get; set; } = null!;
        public virtual DbSet<CedarportalPortalpaymentuser> CedarportalPortalpaymentusers { get; set; } = null!;
        public virtual DbSet<ClientEngagementDatum> ClientEngagementData { get; set; } = null!;
        public virtual DbSet<ClientTrend> ClientTrends { get; set; } = null!;
        public virtual DbSet<ContactDescription> ContactDescriptions { get; set; } = null!;
        public virtual DbSet<Counter> Counters { get; set; } = null!;
        public virtual DbSet<CrmPlacementTrend> CrmPlacementTrends { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<DataTicketsNote> DataTicketsNotes { get; set; } = null!;
        public virtual DbSet<DebtorDataTable> DebtorDataTables { get; set; } = null!;
        public virtual DbSet<Departmentfivefifteen> Departmentfivefifteens { get; set; } = null!;
        public virtual DbSet<Departmentfivefifteen1> Departmentfivefifteen1s { get; set; } = null!;
        public virtual DbSet<EcvOfPlacement> EcvOfPlacements { get; set; } = null!;
        public virtual DbSet<EmailcampAutomation> EmailcampAutomations { get; set; } = null!;
        public virtual DbSet<EmailsToken> EmailsTokens { get; set; } = null!;
        public virtual DbSet<FileNumber> FileNumbers { get; set; } = null!;
        public virtual DbSet<FilePenDataClient> FilePenDataClients { get; set; } = null!;
        public virtual DbSet<FilePenDatum> FilePenData { get; set; } = null!;
        public virtual DbSet<FilterDatum> FilterData { get; set; } = null!;
        public virtual DbSet<Form1> Form1s { get; set; } = null!;
        public virtual DbSet<Form2> Form2s { get; set; } = null!;
        public virtual DbSet<Form3> Form3s { get; set; } = null!;
        public virtual DbSet<Form4> Form4s { get; set; } = null!;
        public virtual DbSet<Hash> Hashes { get; set; } = null!;
        public virtual DbSet<IbLog> IbLogs { get; set; } = null!;
        public virtual DbSet<IbeventLog> IbeventLogs { get; set; } = null!;
        public virtual DbSet<IbinvoiceLog> IbinvoiceLogs { get; set; } = null!;
        public virtual DbSet<InvalidNumbersDataset> InvalidNumbersDatasets { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<JobParameter> JobParameters { get; set; } = null!;
        public virtual DbSet<JobQueue> JobQueues { get; set; } = null!;
        public virtual DbSet<JustinReport> JustinReports { get; set; } = null!;
        public virtual DbSet<LastSixMonthDialCompaign> LastSixMonthDialCompaigns { get; set; } = null!;
        public virtual DbSet<LiquidatinDebtor> LiquidatinDebtors { get; set; } = null!;
        public virtual DbSet<LiquidationPending> LiquidationPendings { get; set; } = null!;
        public virtual DbSet<LiquidationTransaction> LiquidationTransactions { get; set; } = null!;
        public virtual DbSet<List> Lists { get; set; } = null!;
        public virtual DbSet<LowellStatusCode> LowellStatusCodes { get; set; } = null!;
        public virtual DbSet<Mytable> Mytables { get; set; } = null!;
        public virtual DbSet<NewPromise> NewPromises { get; set; } = null!;
        public virtual DbSet<NewShoppingCartCsv> NewShoppingCartCsvs { get; set; } = null!;
        public virtual DbSet<Notdialeddatum> Notdialeddata { get; set; } = null!;
        public virtual DbSet<NotesApi> NotesApis { get; set; } = null!;
        public virtual DbSet<PayFile> PayFiles { get; set; } = null!;
        public virtual DbSet<Pending> Pendings { get; set; } = null!;
        public virtual DbSet<PlacementTable> PlacementTables { get; set; } = null!;
        public virtual DbSet<PromiseBackup> PromiseBackups { get; set; } = null!;
        public virtual DbSet<PromiseTable> PromiseTables { get; set; } = null!;
        public virtual DbSet<PythonPromise> PythonPromises { get; set; } = null!;
        public virtual DbSet<Qbdatum> Qbdata { get; set; } = null!;
        public virtual DbSet<Remark> Remarks { get; set; } = null!;
        public virtual DbSet<RestOffDialCompaign> RestOffDialCompaigns { get; set; } = null!;
        public virtual DbSet<Schema> Schemas { get; set; } = null!;
        public virtual DbSet<SendgridDomain> SendgridDomains { get; set; } = null!;
        public virtual DbSet<Server> Servers { get; set; } = null!;
        public virtual DbSet<Set> Sets { get; set; } = null!;
        public virtual DbSet<Shan> Shans { get; set; } = null!;
        public virtual DbSet<ShoppingCartLog> ShoppingCartLogs { get; set; } = null!;
        public virtual DbSet<SimpleLog> SimpleLogs { get; set; } = null!;
        public virtual DbSet<SpamEmail> SpamEmails { get; set; } = null!;
        public virtual DbSet<SpinifyAvgCallsPerHour> SpinifyAvgCallsPerHours { get; set; } = null!;
        public virtual DbSet<SpinifyGrossCollection> SpinifyGrossCollections { get; set; } = null!;
        public virtual DbSet<SpinifyNoOfPayment> SpinifyNoOfPayments { get; set; } = null!;
        public virtual DbSet<SpinifyPerToGoal> SpinifyPerToGoals { get; set; } = null!;
        public virtual DbSet<SpinifyPromisesCreated> SpinifyPromisesCreateds { get; set; } = null!;
        public virtual DbSet<SpinifyRevenue> SpinifyRevenues { get; set; } = null!;
        public virtual DbSet<SpinifyRpcClosed> SpinifyRpcCloseds { get; set; } = null!;
        public virtual DbSet<SpinifyRpcClosedRate> SpinifyRpcClosedRates { get; set; } = null!;
        public virtual DbSet<SpinifyTotalCall> SpinifyTotalCalls { get; set; } = null!;
        public virtual DbSet<SpinifyTotalRpc> SpinifyTotalRpcs { get; set; } = null!;
        public virtual DbSet<SqllabPatientsThatCanBeSentToCollectionsAndSentToCedar20211026t185903> SqllabPatientsThatCanBeSentToCollectionsAndSentToCedar20211026t185903s { get; set; } = null!;
        public virtual DbSet<Staffaug> Staffaugs { get; set; } = null!;
        public virtual DbSet<StaffingServicesIncome> StaffingServicesIncomes { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<StateInterestRate> StateInterestRates { get; set; } = null!;
        public virtual DbSet<TblTask> TblTasks { get; set; } = null!;
        public virtual DbSet<TemporarySunsetNotSensorCallDatum> TemporarySunsetNotSensorCallData { get; set; } = null!;
        public virtual DbSet<TemporarySunsetSensorCallDatum> TemporarySunsetSensorCallData { get; set; } = null!;
        public virtual DbSet<ThrioAgentDisposition> ThrioAgentDispositions { get; set; } = null!;
        public virtual DbSet<ThrioAgentDispositionDetail> ThrioAgentDispositionDetails { get; set; } = null!;
        public virtual DbSet<ThrioAgentRpc> ThrioAgentRpcs { get; set; } = null!;
        public virtual DbSet<ThrioAgentRpcDetail> ThrioAgentRpcDetails { get; set; } = null!;
        public virtual DbSet<ThrioCallDetail> ThrioCallDetails { get; set; } = null!;
        public virtual DbSet<ThrioCompainDisposition> ThrioCompainDispositions { get; set; } = null!;
        public virtual DbSet<ThrioCompainDispositionLog> ThrioCompainDispositionLogs { get; set; } = null!;
        public virtual DbSet<ThrioDailyDisposition> ThrioDailyDispositions { get; set; } = null!;
        public virtual DbSet<ThrioDatum> ThrioData { get; set; } = null!;
        public virtual DbSet<ThrioDetail> ThrioDetails { get; set; } = null!;
        public virtual DbSet<Timezone> Timezones { get; set; } = null!;
        public virtual DbSet<TopClientDialCompaign> TopClientDialCompaigns { get; set; } = null!;
        public virtual DbSet<TransactionReport> TransactionReports { get; set; } = null!;
        public virtual DbSet<TwilioSm> TwilioSms { get; set; } = null!;
        public virtual DbSet<WaldenReport> WaldenReports { get; set; } = null!;
        public virtual DbSet<WaldenReportDirectPay> WaldenReportDirectPays { get; set; } = null!;
        public virtual DbSet<ZeeJudgmentsInStatuteWith> ZeeJudgmentsInStatuteWiths { get; set; } = null!;
        public virtual DbSet<_1stPriorityCompaignPriority1> _1stPriorityCompaignPriority1s { get; set; } = null!;
        public virtual DbSet<_1stPriorityCompaignPriority2> _1stPriorityCompaignPriority2s { get; set; } = null!;
        public virtual DbSet<_1stPriorityCompaignPriority3> _1stPriorityCompaignPriority3s { get; set; } = null!;
        public virtual DbSet<_1stPriorityCompaignPriority4> _1stPriorityCompaignPriority4s { get; set; } = null!;
        public virtual DbSet<_2ndPriorityCompaignPriority1> _2ndPriorityCompaignPriority1s { get; set; } = null!;
        public virtual DbSet<_2ndPriorityCompaignPriority2> _2ndPriorityCompaignPriority2s { get; set; } = null!;
        public virtual DbSet<_3rdPriorityCompaignPriority1> _3rdPriorityCompaignPriority1s { get; set; } = null!;
        public virtual DbSet<_3rdPriorityCompaignPriority2> _3rdPriorityCompaignPriority2s { get; set; } = null!;
        public virtual DbSet<_3rdPriorityCompaignPriority3> _3rdPriorityCompaignPriority3s { get; set; } = null!;
        public virtual DbSet<_3rdPriorityCompaignPriority4> _3rdPriorityCompaignPriority4s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.20.90;Database=aPortal;User Id=root;password=Qwerty1234567890;Trusted_Connection = false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APromise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("a_promise");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("firstname");
            });

            modelBuilder.Entity<AcknoledgmentTable>(entity =>
            {
                entity.ToTable("Acknoledgment_table");

                entity.Property(e => e.ActualFinish)
                    .HasColumnType("date")
                    .HasColumnName("actual_finish");

                entity.Property(e => e.AssignedTo)
                    .IsUnicode(false)
                    .HasColumnName("assigned_to");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.EstimatedFinish)
                    .HasColumnType("date")
                    .HasColumnName("estimated_finish");

                entity.Property(e => e.EstimatedStart)
                    .HasColumnType("date")
                    .HasColumnName("estimated_start");

                entity.Property(e => e.FeatureName)
                    .IsUnicode(false)
                    .HasColumnName("feature_name");

                entity.Property(e => e.FollowUp)
                    .IsUnicode(false)
                    .HasColumnName("follow_up");

                entity.Property(e => e.PrjCtgryPhase)
                    .IsUnicode(false)
                    .HasColumnName("prj_ctgry_phase");

                entity.Property(e => e.RequestedBy)
                    .IsUnicode(false)
                    .HasColumnName("requested_by");

                entity.Property(e => e.RqstrVrfdDate)
                    .HasColumnType("date")
                    .HasColumnName("rqstr_vrfd_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TesterName)
                    .IsUnicode(false)
                    .HasColumnName("tester_name");

                entity.Property(e => e.TesterVrfdDate)
                    .HasColumnType("date")
                    .HasColumnName("tester_vrfd_date");
            });

            modelBuilder.Entity<AgentsAndManager>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentName).HasMaxLength(100);

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.ManagerEmail).HasMaxLength(255);

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(50)
                    .HasColumnName("ManagerID");

                entity.Property(e => e.Vpemail)
                    .HasMaxLength(255)
                    .HasColumnName("VPEmail");

                entity.Property(e => e.Vpid)
                    .HasMaxLength(50)
                    .HasColumnName("VPID");
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<BprFile>(entity =>
            {
                entity.ToTable("bpr_files");

                entity.Property(e => e.ClName)
                    .HasMaxLength(128)
                    .HasColumnName("cl_name");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.ClOp2)
                    .HasMaxLength(16)
                    .HasColumnName("cl_op_2");

                entity.Property(e => e.CollectedAmnt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("collected_amnt");

                entity.Property(e => e.DeActive)
                    .HasMaxLength(12)
                    .HasColumnName("de_active");

                entity.Property(e => e.DeCollector)
                    .HasMaxLength(16)
                    .HasColumnName("de_collector");

                entity.Property(e => e.DeCountry)
                    .HasMaxLength(64)
                    .HasColumnName("de_country");

                entity.Property(e => e.DeLastPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_payment_date");

                entity.Property(e => e.DeLastWorkedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_worked_date");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeName)
                    .HasMaxLength(128)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_owing");

                entity.Property(e => e.DePaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_paid");

                entity.Property(e => e.DePrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_principal");

                entity.Property(e => e.DeStatus)
                    .HasMaxLength(20)
                    .HasColumnName("de_status");
            });

            modelBuilder.Entity<CareemTable>(entity =>
            {
                entity.ToTable("Careem_Table");

                entity.Property(e => e.Aging).HasMaxLength(150);

                entity.Property(e => e.CaptainBalanceLocal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Captain_balance_local");

                entity.Property(e => e.CaptainBalanceUsd)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Captain_balance_usd");

                entity.Property(e => e.CaptainId)
                    .HasMaxLength(150)
                    .HasColumnName("Captain_id");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(150);

                entity.Property(e => e.Date1).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date10).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date11).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date2).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date3).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date4).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date5).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date6).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date7).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date8).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date9).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UsdBuckets)
                    .HasMaxLength(150)
                    .HasColumnName("USD_buckets");
            });

            modelBuilder.Entity<CareemTablePre>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("Careem_Table_Pre");

                entity.Property(e => e.PId).HasColumnName("p_Id");

                entity.Property(e => e.PAging)
                    .HasMaxLength(150)
                    .HasColumnName("p_Aging");

                entity.Property(e => e.PCaptainBalanceLocal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Captain_balance_local");

                entity.Property(e => e.PCaptainBalanceUsd)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Captain_balance_usd");

                entity.Property(e => e.PCaptainId)
                    .HasMaxLength(150)
                    .HasColumnName("p_Captain_id");

                entity.Property(e => e.PCity)
                    .HasMaxLength(50)
                    .HasColumnName("p_City");

                entity.Property(e => e.PCountry)
                    .HasMaxLength(150)
                    .HasColumnName("p_Country");

                entity.Property(e => e.PDate1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date1");

                entity.Property(e => e.PDate10)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date10");

                entity.Property(e => e.PDate11)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date11");

                entity.Property(e => e.PDate2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date2");

                entity.Property(e => e.PDate3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date3");

                entity.Property(e => e.PDate4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date4");

                entity.Property(e => e.PDate5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date5");

                entity.Property(e => e.PDate6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date6");

                entity.Property(e => e.PDate7)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date7");

                entity.Property(e => e.PDate8)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date8");

                entity.Property(e => e.PDate9)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("p_Date9");

                entity.Property(e => e.PUsdBuckets)
                    .HasMaxLength(150)
                    .HasColumnName("p_USD_buckets");
            });

            modelBuilder.Entity<CartClientInfo>(entity =>
            {
                entity.ToTable("CartClientInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Caddress)
                    .HasMaxLength(100)
                    .HasColumnName("caddress")
                    .IsFixedLength();

                entity.Property(e => e.Cemail)
                    .HasMaxLength(100)
                    .HasColumnName("cemail")
                    .IsFixedLength();

                entity.Property(e => e.Cname)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Cphone)
                    .HasMaxLength(100)
                    .HasColumnName("cphone")
                    .IsFixedLength();

                entity.Property(e => e.DeAddress)
                    .HasMaxLength(100)
                    .HasColumnName("de_address")
                    .IsFixedLength();

                entity.Property(e => e.DeDob)
                    .HasMaxLength(100)
                    .HasColumnName("de_dob")
                    .IsFixedLength();

                entity.Property(e => e.DeEmail)
                    .HasMaxLength(100)
                    .HasColumnName("de_email")
                    .IsFixedLength();

                entity.Property(e => e.DeName)
                    .HasMaxLength(100)
                    .HasColumnName("de_name")
                    .IsFixedLength();

                entity.Property(e => e.DePhone)
                    .HasMaxLength(100)
                    .HasColumnName("de_phone")
                    .IsFixedLength();

                entity.Property(e => e.DeSs)
                    .HasMaxLength(100)
                    .HasColumnName("de_ss")
                    .IsFixedLength();

                entity.Property(e => e.Pname)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<CedarOperator>(entity =>
            {
                entity.ToTable("CedarOperator");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CimgUrl).HasColumnName("cimg_url");

                entity.Property(e => e.CopCdate)
                    .HasColumnType("date")
                    .HasColumnName("cop_cdate");

                entity.Property(e => e.CopId)
                    .HasMaxLength(50)
                    .HasColumnName("cop_id");

                entity.Property(e => e.CopPassword)
                    .HasMaxLength(50)
                    .HasColumnName("cop_password");
            });

            modelBuilder.Entity<CedarportalPortalpaymentuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cedarportal.portalpaymentuser");

                entity.Property(e => e.Column10)
                    .HasMaxLength(1)
                    .HasColumnName("column10");

                entity.Property(e => e.Column11)
                    .HasMaxLength(1)
                    .HasColumnName("column11");

                entity.Property(e => e.Column12)
                    .HasMaxLength(1)
                    .HasColumnName("column12");

                entity.Property(e => e.Column13)
                    .HasMaxLength(1)
                    .HasColumnName("column13");

                entity.Property(e => e.Column14)
                    .HasMaxLength(1)
                    .HasColumnName("column14");

                entity.Property(e => e.Column15)
                    .HasMaxLength(1)
                    .HasColumnName("column15");

                entity.Property(e => e.Column16)
                    .HasMaxLength(1)
                    .HasColumnName("column16");

                entity.Property(e => e.Column2)
                    .HasMaxLength(1)
                    .HasColumnName("column2");

                entity.Property(e => e.Column3)
                    .HasMaxLength(1)
                    .HasColumnName("column3");

                entity.Property(e => e.Column4)
                    .HasMaxLength(1)
                    .HasColumnName("column4");

                entity.Property(e => e.Column5)
                    .HasMaxLength(1)
                    .HasColumnName("column5");

                entity.Property(e => e.Column6)
                    .HasMaxLength(1)
                    .HasColumnName("column6");

                entity.Property(e => e.Column7)
                    .HasMaxLength(1)
                    .HasColumnName("column7");

                entity.Property(e => e.Column8)
                    .HasMaxLength(1)
                    .HasColumnName("column8");

                entity.Property(e => e.Column9)
                    .HasMaxLength(1)
                    .HasColumnName("column9");

                entity.Property(e => e.FileId).HasColumnName("fileId");
            });

            modelBuilder.Entity<ClientEngagementDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cdate).HasColumnType("date");

                entity.Property(e => e.ClName).HasMaxLength(128);

                entity.Property(e => e.ClRowId).HasColumnName("ClRowID");

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ribbon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOperator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientTrend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClientTrend");

                entity.Property(e => e.ActiveAcctPrincipal).HasColumnType("money");

                entity.Property(e => e.AvgPrincipalPerPlacement).HasColumnType("money");

                entity.Property(e => e.Cdate).HasColumnType("datetime");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.ClientRowId).HasColumnName("ClientRowID");

                entity.Property(e => e.CrmOperator).HasMaxLength(255);

                entity.Property(e => e.EarnFeePerAnum).HasColumnType("money");

                entity.Property(e => e.FirstPlacement).HasColumnType("datetime");

                entity.Property(e => e.LastPlacement).HasColumnType("datetime");

                entity.Property(e => e.Ribbon).HasMaxLength(255);

                entity.Property(e => e.Score).HasMaxLength(255);

                entity.Property(e => e.SuccessRate).HasColumnName("successRate");

                entity.Property(e => e.TotalAcctPrincipal).HasColumnType("money");
            });

            modelBuilder.Entity<ContactDescription>(entity =>
            {
                entity.HasKey(e => e.CoRowid);

                entity.ToTable("contact_descriptions");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_category");

                entity.Property(e => e.CoDescription)
                    .IsUnicode(false)
                    .HasColumnName("co_description");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_Counter");

                entity.ToTable("Counter", "HangFire");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmPlacementTrend>(entity =>
            {
                entity.ToTable("CrmPlacementTrend");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActiveAcctPrincipal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AvgAcctPerPlacement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AvgPrincipalPerPlacement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cdate).HasColumnType("date");

                entity.Property(e => e.ClientName).IsUnicode(false);

                entity.Property(e => e.ClientRowId).HasColumnName("ClientRowID");

                entity.Property(e => e.CrmOperator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EarnFeePerAnum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EcvOfPlacement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EcvPerAnum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstPlacement).HasColumnType("date");

                entity.Property(e => e.LastPlacement).HasColumnType("date");

                entity.Property(e => e.Ribbon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Score)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuccessRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAcctPrincipal).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.Int);

                entity.ToTable("Currency");

                entity.Property(e => e.Int).HasColumnName("int");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<DataTicketsNote>(entity =>
            {
                entity.ToTable("DataTickets_Notes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(200)
                    .HasColumnName("Cell_Phone");

                entity.Property(e => e.Citation).HasMaxLength(50);

                entity.Property(e => e.CitationCode).HasMaxLength(50);

                entity.Property(e => e.DebtorName)
                    .HasMaxLength(200)
                    .HasColumnName("Debtor_Name");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(200)
                    .HasColumnName("Home_Phone");

                entity.Property(e => e.NoteDate)
                    .HasColumnType("date")
                    .HasColumnName("Note_Date");

                entity.Property(e => e.NoteText).HasColumnName("Note_Text");

                entity.Property(e => e.NoteTime)
                    .HasMaxLength(50)
                    .HasColumnName("Note_Time");

                entity.Property(e => e.OtherPhone)
                    .HasMaxLength(250)
                    .HasColumnName("Other_Phone");

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(250)
                    .HasColumnName("Work_Phone");

                entity.Property(e => e.Zip).HasMaxLength(200);
            });

            modelBuilder.Entity<DebtorDataTable>(entity =>
            {
                entity.HasKey(e => e.DeRowid)
                    .HasName("PK__DebtorDa__D042D9C7BA07CC4D");

                entity.ToTable("DebtorDataTable");

                entity.Property(e => e.DeRowid)
                    .ValueGeneratedNever()
                    .HasColumnName("de_rowid");

                entity.Property(e => e.AmountPaid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Amount Paid");

                entity.Property(e => e.ConsentedEmails).HasColumnName("Consented Emails");

                entity.Property(e => e.CurrentSubstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Current Substatus");

                entity.Property(e => e.CustomerTenure).HasColumnName("Customer Tenure");

                entity.Property(e => e.DaysSinceLastInteraction).HasColumnName("Days Since Last Interaction");

                entity.Property(e => e.DaysSinceLastPhoneCall).HasColumnName("Days Since Last Phone Call");

                entity.Property(e => e.DebtorAge).HasColumnName("Debtor Age");

                entity.Property(e => e.EmailSend).HasColumnName("Email Send");

                entity.Property(e => e.InitialDebtAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Initial Debt Amount");

                entity.Property(e => e.LastPromise).HasColumnName("Last Promise");

                entity.Property(e => e.NonConsentedEmail).HasColumnName("NonConsented Email");

                entity.Property(e => e.PartialRepaymentStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Partial Repayment Status")
                    .IsFixedLength();

                entity.Property(e => e.PreviousCollectionSuccess)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Previous Collection Success")
                    .IsFixedLength();

                entity.Property(e => e.ProductType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Product Type");

                entity.Property(e => e.Rpc).HasColumnName("RPC");

                entity.Property(e => e.Sms).HasColumnName("SMS");

                entity.Property(e => e.TotalContacts).HasColumnName("Total Contacts");

                entity.Property(e => e.VerifiedAddress).HasColumnName("Verified Address");

                entity.Property(e => e.VerifiedEmail).HasColumnName("Verified Email");

                entity.Property(e => e.VerifiedPhone).HasColumnName("Verified Phone");
            });

            modelBuilder.Entity<Departmentfivefifteen>(entity =>
            {
                entity.ToTable("departmentfivefifteen");

                entity.Property(e => e.AgentName).HasMaxLength(100);

                entity.Property(e => e.Ceonotes).HasColumnName("CEONotes");

                entity.Property(e => e.Coonotes).HasColumnName("COONotes");

                entity.Property(e => e.Cosnotes).HasColumnName("COSNotes");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.Vpnotes).HasColumnName("VPNotes");

                entity.Property(e => e._515id).HasColumnName("515id");
            });

            modelBuilder.Entity<Departmentfivefifteen1>(entity =>
            {
                entity.ToTable("departmentfivefifteen1");

                entity.Property(e => e.AgentName).HasMaxLength(100);

                entity.Property(e => e.Ceonotes).HasColumnName("CEONotes");

                entity.Property(e => e.Coonotes).HasColumnName("COONotes");

                entity.Property(e => e.Cosnotes).HasColumnName("COSNotes");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.ManagerApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.ManagerDepartment).HasMaxLength(100);

                entity.Property(e => e.ManagerEmail).HasMaxLength(100);

                entity.Property(e => e.ManagerName).HasMaxLength(100);

                entity.Property(e => e.Vpnotes).HasColumnName("VPNotes");

                entity.Property(e => e._515id).HasColumnName("515id");
            });

            modelBuilder.Entity<EcvOfPlacement>(entity =>
            {
                entity.ToTable("EcvOfPlacement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientCreatedDate).HasColumnType("date");

                entity.Property(e => e.ClientName).HasMaxLength(100);

                entity.Property(e => e.ClientPaid).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.ClientRowId).HasColumnName("ClientRowID");

                entity.Property(e => e.ClientSuccesRate).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.CntractValue).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.CommissionToDate).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.CrmOp).HasMaxLength(50);

                entity.Property(e => e.Ecv).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.EcvCdate)
                    .HasColumnType("date")
                    .HasColumnName("Ecv_cdate");

                entity.Property(e => e.EcvOfPlacment).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.EcvOfPlacmentPerAnum).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.Fee).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.FeeA).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.OpType).HasMaxLength(50);

                entity.Property(e => e.SalesOp).HasMaxLength(50);

                entity.Property(e => e.SectorSuccessRate).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.Success).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.TotalValue).HasColumnType("decimal(25, 6)");
            });

            modelBuilder.Entity<EmailcampAutomation>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("emailcampAutomation");

                entity.Property(e => e.Cid).HasColumnName("cid");
            });

            modelBuilder.Entity<EmailsToken>(entity =>
            {
                entity.HasKey(e => e.TokenId);

                entity.ToTable("EmailsToken");

                entity.Property(e => e.TokenId).ValueGeneratedNever();

                entity.Property(e => e.DebtorEmail).HasMaxLength(150);

                entity.Property(e => e.FileNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<FileNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("file_numbers");

                entity.Property(e => e.ColFileNumber).HasColumnName("COL_FileNumber");
            });

            modelBuilder.Entity<FilePenDataClient>(entity =>
            {
                entity.ToTable("FilePenDataClient");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cbrcount).HasColumnName("CBRCount");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Liq).IsUnicode(false);

                entity.Property(e => e.Report)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smscount).HasColumnName("SMSCount");
            });

            modelBuilder.Entity<FilePenDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cbrcount).HasColumnName("CBRCount");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Liq).IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smscount).HasColumnName("SMSCount");

                entity.Property(e => e.SubSector).IsUnicode(false);
            });

            modelBuilder.Entity<FilterDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("filter_data");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<Form1>(entity =>
            {
                entity.ToTable("Form1");

                entity.Property(e => e.AdditionalInfo).IsUnicode(false);

                entity.Property(e => e.Amount).IsUnicode(false);

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.DebtFrom).IsUnicode(false);

                entity.Property(e => e.DebtLocation).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.HearOption).IsUnicode(false);

                entity.Property(e => e.JobTitle).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.TotalAccounts).IsUnicode(false);
            });

            modelBuilder.Entity<Form2>(entity =>
            {
                entity.ToTable("Form2");

                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Form3>(entity =>
            {
                entity.ToTable("Form3");

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);
            });

            modelBuilder.Entity<Form4>(entity =>
            {
                entity.ToTable("Form4");

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);

                entity.Property(e => e.TotalAccounts).HasMaxLength(50);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<IbLog>(entity =>
            {
                entity.ToTable("ib_logs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EventDate)
                    .HasColumnType("date")
                    .HasColumnName("event_date");

                entity.Property(e => e.EventTime).HasColumnName("event_time");

                entity.Property(e => e.EventType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("event_type");

                entity.Property(e => e.IbId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ib_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<IbeventLog>(entity =>
            {
                entity.ToTable("IBEventLogs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(120)
                    .HasColumnName("client_name");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.EventType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("event_type");

                entity.Property(e => e.IbId).HasColumnName("ib_id");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(120)
                    .HasColumnName("patient_name");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<IbinvoiceLog>(entity =>
            {
                entity.ToTable("IBInvoiceLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdminOrgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("admin_org_name");

                entity.Property(e => e.AdminOrganizationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("admin_organization_id");

                entity.Property(e => e.EnterpriseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enterprise_id");

                entity.Property(e => e.EnterpriseName)
                    .IsUnicode(false)
                    .HasColumnName("enterprise_name");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_id");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("patient_id");

                entity.Property(e => e.SentToCollectionsAt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sent_to_collections_at");
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

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<JustinReport>(entity =>
            {
                entity.ToTable("justin_report");

                entity.Property(e => e.ClName)
                    .HasMaxLength(128)
                    .HasColumnName("cl_name");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeCellPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_cell_phone");

                entity.Property(e => e.DeChargeDate)
                    .HasColumnType("date")
                    .HasColumnName("de_charge_date");

                entity.Property(e => e.DeClAccount)
                    .HasMaxLength(160)
                    .HasColumnName("de_cl_account");

                entity.Property(e => e.DeEmail)
                    .HasMaxLength(160)
                    .HasColumnName("de_email");

                entity.Property(e => e.DeHomePhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_home_phone");

                entity.Property(e => e.DeLastWorkedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_worked_date");

                entity.Property(e => e.DeName)
                    .HasMaxLength(128)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOtherPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_other_phone");

                entity.Property(e => e.DeOwing)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .HasMaxLength(20)
                    .HasColumnName("de_status");

                entity.Property(e => e.DeType)
                    .HasMaxLength(64)
                    .HasColumnName("de_type");

                entity.Property(e => e.DeWorkPhone)
                    .HasMaxLength(48)
                    .HasColumnName("de_work_phone");

                entity.Property(e => e.ListedDate)
                    .HasColumnType("date")
                    .HasColumnName("listed_date");

                entity.Property(e => e.PhType).HasColumnName("ph_type");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<LastSixMonthDialCompaign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("last_six_month_dial_compaign");

                entity.Property(e => e.DeActive)
                    .IsUnicode(false)
                    .HasColumnName("de_active");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");
            });

            modelBuilder.Entity<LiquidatinDebtor>(entity =>
            {
                entity.ToTable("Liquidatin_debtor");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.NewFiles).HasColumnName("new_files");

                entity.Property(e => e.NewFilesBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("new_files_balance");

                entity.Property(e => e.NoOfActiveFiles).HasColumnName("no_of_active_files");

                entity.Property(e => e.NoOfClosedFiles).HasColumnName("no_of_closed_files");

                entity.Property(e => e.NoOfDisputesFiles).HasColumnName("no_of_disputes_files");

                entity.Property(e => e.NoOfPaidFiles).HasColumnName("no_of_paid_files");

                entity.Property(e => e.OutPlacementsBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("out_placements_balance");

                entity.Property(e => e.OutPlacementsFiles).HasColumnName("out_placements_files");

                entity.Property(e => e.TotalActiveFilesAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("total_active_files_amount");

                entity.Property(e => e.WeekDate).HasColumnName("week_date");
            });

            modelBuilder.Entity<LiquidationPending>(entity =>
            {
                entity.ToTable("liquidation_pending");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.NoOfPendingPrmsFiles).HasColumnName("no_of_pending_prms_files");

                entity.Property(e => e.PendingFilesAmnt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("pending_files_amnt");

                entity.Property(e => e.WeekDate).HasColumnName("week_date");
            });

            modelBuilder.Entity<LiquidationTransaction>(entity =>
            {
                entity.ToTable("Liquidation_transaction");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.MnthlyRcvrdAmnt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("mnthly_rcvrd_amnt");

                entity.Property(e => e.WeekDate).HasColumnName("week_date");

                entity.Property(e => e.WeeklyRcvrdAmnt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("weekly_rcvrd_amnt");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<LowellStatusCode>(entity =>
            {
                entity.ToTable("Lowell_Status_Codes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CedarStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cedar_status");

                entity.Property(e => e.LowellCode).HasColumnName("lowell_code");
            });

            modelBuilder.Entity<Mytable>(entity =>
            {
                entity.HasKey(e => e.DeNumber)
                    .HasName("PK__mytable__81C9A652D9179929");

                entity.ToTable("mytable");

                entity.Property(e => e.DeNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("de_number");

                entity.Property(e => e.CoAmount)
                    .HasColumnType("numeric(9, 4)")
                    .HasColumnName("co_amount");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCommisionRate)
                    .HasColumnType("numeric(7, 4)")
                    .HasColumnName("co_commision_rate");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDescription)
                    .HasMaxLength(52)
                    .IsUnicode(false)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.DeName)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("de_name");
            });

            modelBuilder.Entity<NewPromise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_Promise");

                entity.Property(e => e.CoAmount).HasColumnName("co_amount");

                entity.Property(e => e.CoCby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDescription)
                    .IsUnicode(false)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_who");

                entity.Property(e => e.DeCommisionRate).HasColumnName("de_commision_rate");

                entity.Property(e => e.DeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");
            });

            modelBuilder.Entity<NewShoppingCartCsv>(entity =>
            {
                entity.HasKey(e => e.Productid);

                entity.ToTable("NewShoppingCartCSV");

                entity.Property(e => e.Column15)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("column15")
                    .IsFixedLength();

                entity.Property(e => e.CompletedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Completed_by");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InformationTech)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Information_Tech")
                    .IsFixedLength();

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.NoitifyAccount)
                    .HasMaxLength(50)
                    .HasColumnName("Noitify_Account");

                entity.Property(e => e.NotifyCompliance)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Notify_Compliance")
                    .IsFixedLength();

                entity.Property(e => e.NotifyCsm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Notify_CSM")
                    .IsFixedLength();

                entity.Property(e => e.NotifyDomestic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Notify_domestic")
                    .IsFixedLength();

                entity.Property(e => e.NotifyInternational)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Notify_International")
                    .IsFixedLength();

                entity.Property(e => e.NotifyMis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Notify_MIS")
                    .IsFixedLength();

                entity.Property(e => e.Requirements).HasMaxLength(150);

                entity.Property(e => e.ServiceItem)
                    .HasMaxLength(150)
                    .HasColumnName("Service_item");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Notdialeddatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("notdialeddata");

                entity.Property(e => e.Feb)
                    .HasMaxLength(50)
                    .HasColumnName("feb");

                entity.Property(e => e.Filenumber).HasColumnName("filenumber");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<NotesApi>(entity =>
            {
                entity.ToTable("Notes_api");

                entity.Property(e => e.FormId).HasColumnName("form_id");

                entity.Property(e => e.NotesPortal).HasColumnName("Notes_portal");
            });

            modelBuilder.Entity<PayFile>(entity =>
            {
                entity.ToTable("pay_files");

                entity.Property(e => e.ClName)
                    .HasMaxLength(128)
                    .HasColumnName("cl_name");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.ClOp2)
                    .HasMaxLength(16)
                    .HasColumnName("cl_op_2");

                entity.Property(e => e.CollectedAmnt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("collected_amnt");

                entity.Property(e => e.DeActive)
                    .HasMaxLength(12)
                    .HasColumnName("de_active");

                entity.Property(e => e.DeCollector)
                    .HasMaxLength(16)
                    .HasColumnName("de_collector");

                entity.Property(e => e.DeCountry)
                    .HasMaxLength(64)
                    .HasColumnName("de_country");

                entity.Property(e => e.DeLastPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_payment_date");

                entity.Property(e => e.DeLastWorkedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_last_worked_date");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeName)
                    .HasMaxLength(128)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_owing");

                entity.Property(e => e.DePaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_paid");

                entity.Property(e => e.DePrincipal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("de_principal");

                entity.Property(e => e.DeStatus)
                    .HasMaxLength(20)
                    .HasColumnName("de_status");
            });

            modelBuilder.Entity<Pending>(entity =>
            {
                entity.ToTable("pendings");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.ListedDate)
                    .HasColumnType("date")
                    .HasColumnName("listed_date");

                entity.Property(e => e.NoOfPendingPrmsFiles).HasColumnName("no_of_pending_prms_files");

                entity.Property(e => e.PendingFilesAmnt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("pending_files_amnt");
            });

            modelBuilder.Entity<PlacementTable>(entity =>
            {
                entity.ToTable("placement_table");

                entity.Property(e => e.ClListedDate)
                    .HasColumnType("date")
                    .HasColumnName("cl_listed_date");

                entity.Property(e => e.ClName)
                    .HasMaxLength(128)
                    .HasColumnName("cl_name");

                entity.Property(e => e.ClNumOfActiveAccounts).HasColumnName("cl_num_of_active_accounts");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.ClOp1)
                    .HasMaxLength(16)
                    .HasColumnName("cl_op_1");

                entity.Property(e => e.ClOp2)
                    .HasMaxLength(16)
                    .HasColumnName("cl_op_2");

                entity.Property(e => e.ClOwnedbyNumber).HasColumnName("cl_ownedby_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeRowidClient).HasColumnName("de_rowid_client");

                entity.Property(e => e.TotalAccounts).HasColumnName("total_accounts");

                entity.Property(e => e._2ndListedDate)
                    .HasColumnType("date")
                    .HasColumnName("2nd_listed_date");
            });

            modelBuilder.Entity<PromiseBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("promise_backup");

                entity.Property(e => e.CoAmount).HasColumnName("co_amount");

                entity.Property(e => e.CoCby)
                    .IsUnicode(false)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDescription)
                    .IsUnicode(false)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_who");

                entity.Property(e => e.DeCommissionRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("de_commission_rate");

                entity.Property(e => e.DeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.OpTeam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("op_team");
            });

            modelBuilder.Entity<PromiseTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Promise_table");

                entity.Property(e => e.CoAmount).HasColumnName("co_amount");

                entity.Property(e => e.CoCby)
                    .IsUnicode(false)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoCompleted).HasColumnName("co_completed");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDescription)
                    .IsUnicode(false)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_who");

                entity.Property(e => e.DeCommissionRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("de_commission_rate");

                entity.Property(e => e.DeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.OpTeam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("op_team");
            });

            modelBuilder.Entity<PythonPromise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Python_Promise");

                entity.Property(e => e.CoAmount).HasColumnName("co_amount");

                entity.Property(e => e.CoCby)
                    .IsUnicode(false)
                    .HasColumnName("co_cby");

                entity.Property(e => e.CoCdate)
                    .HasColumnType("date")
                    .HasColumnName("co_cdate");

                entity.Property(e => e.CoDate)
                    .HasColumnType("date")
                    .HasColumnName("co_date");

                entity.Property(e => e.CoDescription)
                    .IsUnicode(false)
                    .HasColumnName("co_description");

                entity.Property(e => e.CoMby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_mby");

                entity.Property(e => e.CoMdate)
                    .HasColumnType("date")
                    .HasColumnName("co_mdate");

                entity.Property(e => e.CoOriginator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_originator");

                entity.Property(e => e.CoRowid).HasColumnName("co_rowid");

                entity.Property(e => e.CoWho)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("co_who");

                entity.Property(e => e.DeCommissionRate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("de_commission_rate");

                entity.Property(e => e.DeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("de_name");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Qbdatum>(entity =>
            {
                entity.ToTable("QBData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Remark>(entity =>
            {
                entity.Property(e => e.RemarkId)
                    .ValueGeneratedNever()
                    .HasColumnName("RemarkID");

                entity.Property(e => e.OpId).HasMaxLength(50);

                entity.Property(e => e.RemarkDateTime).HasColumnType("datetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<RestOffDialCompaign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rest_off_dial_compaign");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeActive)
                    .IsUnicode(false)
                    .HasColumnName("de_active");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<SendgridDomain>(entity =>
            {
                entity.HasKey(e => e.SdId)
                    .HasName("PK__SpamSour__A445C6A2EAADD212");

                entity.Property(e => e.SdId)
                    .ValueGeneratedNever()
                    .HasColumnName("sd_id");

                entity.Property(e => e.SdDomains)
                    .HasMaxLength(255)
                    .HasColumnName("sd_domains");

                entity.Property(e => e.SdName)
                    .HasMaxLength(255)
                    .HasColumnName("sd_name");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Shan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("shan");

                entity.Property(e => e.AccNumber)
                    .IsUnicode(false)
                    .HasColumnName("acc_number");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<ShoppingCartLog>(entity =>
            {
                entity.ToTable("ShoppingCartLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Cost)
                    .IsUnicode(false)
                    .HasColumnName("cost");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.DebtorId).HasColumnName("debtor_id");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("op_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SalesId).HasColumnName("sales_id");

                entity.Property(e => e.ServiceItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service_item");
            });

            modelBuilder.Entity<SimpleLog>(entity =>
            {
                entity.ToTable("simple_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("op_id");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("time");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SpamEmail>(entity =>
            {
                entity.HasKey(e => e.SeId)
                    .HasName("PK__SpamEmai__C359D5B389788257");

                entity.HasIndex(e => e.SeEmail, "UQ__SpamEmai__D9A1719465B90782")
                    .IsUnique();

                entity.Property(e => e.SeId).HasColumnName("se_id");

                entity.Property(e => e.SeDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("se_date");

                entity.Property(e => e.SeEmail)
                    .HasMaxLength(255)
                    .HasColumnName("se_email");

                entity.Property(e => e.SeSource).HasColumnName("se_source");
            });

            modelBuilder.Entity<SpinifyAvgCallsPerHour>(entity =>
            {
                entity.ToTable("SpinifyAvgCallsPerHour");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ac_ctime");

                entity.Property(e => e.AcDate).HasColumnType("date");

                entity.Property(e => e.AvgCallsPerHour).HasColumnType("decimal(35, 2)");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);
            });

            modelBuilder.Entity<SpinifyGrossCollection>(entity =>
            {
                entity.ToTable("SpinifyGrossCollection");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GcCdate)
                    .HasColumnType("date")
                    .HasColumnName("gc_cdate");

                entity.Property(e => e.GcCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("gc_ctime");

                entity.Property(e => e.GcRowid).HasColumnName("gc_rowid");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpGrossCollection).HasColumnType("decimal(22, 2)");

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);
            });

            modelBuilder.Entity<SpinifyNoOfPayment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NpCdate)
                    .HasColumnType("date")
                    .HasColumnName("np_cdate");

                entity.Property(e => e.NpCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("np_ctime");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);
            });

            modelBuilder.Entity<SpinifyPerToGoal>(entity =>
            {
                entity.ToTable("SpinifyPerToGoal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cdate)
                    .HasColumnType("date")
                    .HasColumnName("cdate");

                entity.Property(e => e.Ctime)
                    .HasColumnType("time(0)")
                    .HasColumnName("ctime");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);

                entity.Property(e => e.PerToGoal).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SpinifyPromisesCreated>(entity =>
            {
                entity.ToTable("SpinifyPromisesCreated");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);

                entity.Property(e => e.PcCdate)
                    .HasColumnType("date")
                    .HasColumnName("pc_cdate");

                entity.Property(e => e.PcCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("pc_ctime");
            });

            modelBuilder.Entity<SpinifyRevenue>(entity =>
            {
                entity.ToTable("SpinifyRevenue");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);

                entity.Property(e => e.OpRevenue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("Rev_ctime");

                entity.Property(e => e.RevDate).HasColumnType("date");
            });

            modelBuilder.Entity<SpinifyRpcClosed>(entity =>
            {
                entity.ToTable("SpinifyRpcClosed");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);

                entity.Property(e => e.RclCdate)
                    .HasColumnType("date")
                    .HasColumnName("rcl_cdate");

                entity.Property(e => e.RclCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("rcl_ctime");
            });

            modelBuilder.Entity<SpinifyRpcClosedRate>(entity =>
            {
                entity.ToTable("SpinifyRpcClosedRate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);

                entity.Property(e => e.RcCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("rc_ctime");

                entity.Property(e => e.RclrateCdate)
                    .HasColumnType("date")
                    .HasColumnName("rclrate_cdate");

                entity.Property(e => e.RpcClosedRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SpinifyTotalCall>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);

                entity.Property(e => e.TcCdate)
                    .HasColumnType("date")
                    .HasColumnName("tc_cdate");

                entity.Property(e => e.TcCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("tc_ctime");
            });

            modelBuilder.Entity<SpinifyTotalRpc>(entity =>
            {
                entity.ToTable("SpinifyTotalRpc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OpEmail).HasMaxLength(50);

                entity.Property(e => e.OpId)
                    .HasMaxLength(50)
                    .HasColumnName("OpID");

                entity.Property(e => e.OpName).HasMaxLength(50);

                entity.Property(e => e.TotalRpc).HasColumnName("TotalRPC");

                entity.Property(e => e.TrpcCdate)
                    .HasColumnType("date")
                    .HasColumnName("trpc_cdate");

                entity.Property(e => e.TrpcCtime)
                    .HasColumnType("time(0)")
                    .HasColumnName("trpc_ctime");
            });

            modelBuilder.Entity<SqllabPatientsThatCanBeSentToCollectionsAndSentToCedar20211026t185903>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sqllab_patients_that_can_be_sent_to_collections_and_sent_to_cedar_20211026T185903");

                entity.Property(e => e.AdminOrgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("admin_org_name");

                entity.Property(e => e.AdminOrganizationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("admin_organization_id");

                entity.Property(e => e.EnterpriseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enterprise_id");

                entity.Property(e => e.EnterpriseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enterprise_name");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_id");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("patient_id");

                entity.Property(e => e.SentToCollectionsAt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sent_to_collections_at");
            });

            modelBuilder.Entity<Staffaug>(entity =>
            {
                entity.ToTable("staffaug");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("avg_amount");

                entity.Property(e => e.AvgAmountPkr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("avg_amount_pkr");

                entity.Property(e => e.ClentNumber).HasColumnName("clent_number");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(150)
                    .HasColumnName("client_name")
                    .IsFixedLength();

                entity.Property(e => e.Crm)
                    .HasMaxLength(10)
                    .HasColumnName("CRM")
                    .IsFixedLength();

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_amount");

                entity.Property(e => e.TotalAmountPkr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_amount_pkr");
            });

            modelBuilder.Entity<StaffingServicesIncome>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Staffing_Services_Income");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(250)
                    .HasColumnName("Document_Number");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(250);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);
            });

            modelBuilder.Entity<StateInterestRate>(entity =>
            {
                entity.ToTable("state_interest_rates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InterestRate1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("interest_rate_1");

                entity.Property(e => e.InterestRate2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("interest_rate_2");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state_name");
            });

            modelBuilder.Entity<TblTask>(entity =>
            {
                entity.ToTable("tbl_task");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Attachments).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IssueType).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RequestedEta)
                    .HasColumnType("date")
                    .HasColumnName("RequestedETA");

                entity.Property(e => e.RequestedPriority).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.TicketType).HasMaxLength(50);
            });

            modelBuilder.Entity<TemporarySunsetNotSensorCallDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temporary_sunset.not_sensor_call_data");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.PhoneNumber)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<TemporarySunsetSensorCallDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temporary_sunset.sensor_call_data");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.PhoneNumber)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<ThrioAgentDisposition>(entity =>
            {
                entity.ToTable("ThrioAgentDisposition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateC)
                    .HasColumnType("date")
                    .HasColumnName("dateC");

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.EmailRpchot).HasColumnName("EmailRPCHot");

                entity.Property(e => e.EmailRpcother).HasColumnName("EmailRPCOther");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("label");

                entity.Property(e => e.Na).HasColumnName("NA");

                entity.Property(e => e.Nis).HasColumnName("NIS");

                entity.Property(e => e.NoRpc3rdPartyAnswered).HasColumnName("NoRPC3rdPartyAnswered");

                entity.Property(e => e.NoRpcsms).HasColumnName("NoRPCSMS");

                entity.Property(e => e.Norpcdisconnected).HasColumnName("NORPCDisconnected");

                entity.Property(e => e.NorpcgenericEmailSent).HasColumnName("NORPCGenericEmailSent");

                entity.Property(e => e.NorpchangUp).HasColumnName("NORPCHangUp");

                entity.Property(e => e.NorpcleftVoicemail).HasColumnName("NORPCLeftVoicemail");

                entity.Property(e => e.NorpcnoAnswer).HasColumnName("NORPCNoAnswer");

                entity.Property(e => e.Norpcskp).HasColumnName("NORPCSKP");

                entity.Property(e => e.NorpcwrongNumber).HasColumnName("NORPCWrongNumber");

                entity.Property(e => e.Optout).HasColumnName("OPTOUT");

                entity.Property(e => e.QbnoAnswer).HasColumnName("QBNoAnswer");

                entity.Property(e => e.RpcCvhangUp).HasColumnName("RpcCVHangUp");

                entity.Property(e => e.RpcDis).HasColumnName("RpcDIS");

                entity.Property(e => e.Rpccallbackanotherday).HasColumnName("RPCcallbackanotherday");

                entity.Property(e => e.Rpchot).HasColumnName("RPCHot");

                entity.Property(e => e.Rpcprp).HasColumnName("RPCPRP");

                entity.Property(e => e.Rpcsms).HasColumnName("RPCSMS");

                entity.Property(e => e.SalesFunnelCawa).HasColumnName("SalesFunnelCAWA");

                entity.Property(e => e.SalesFunnelCclo).HasColumnName("SalesFunnelCCLO");

                entity.Property(e => e.SalesFunnelChot).HasColumnName("SalesFunnelCHOT");

                entity.Property(e => e.SalesFunnelCitp).HasColumnName("SalesFunnelCITP");

                entity.Property(e => e.SalesFunnelCwon).HasColumnName("SalesFunnelCWON");

                entity.Property(e => e.SalesInquiryHotemailSent).HasColumnName("SalesInquiryHOTEmailSent");

                entity.Property(e => e.SalesInquiryItp).HasColumnName("SalesInquiryITP");

                entity.Property(e => e.SalesInquiryVmleft).HasColumnName("SalesInquiryVMLeft");

                entity.Property(e => e.SmsblockedUndelivered).HasColumnName("SMSBlockedUndelivered");

                entity.Property(e => e.SmspaymentReminder).HasColumnName("SMSPaymentReminder");

                entity.Property(e => e.Smssent).HasColumnName("SMSSent");

                entity.Property(e => e.SvPrp).HasColumnName("SvPRP");

                entity.Property(e => e.Svpay).HasColumnName("SVPay");
            });

            modelBuilder.Entity<ThrioAgentDispositionDetail>(entity =>
            {
                entity.ToTable("ThrioAgentDispositionDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateC)
                    .HasColumnType("date")
                    .HasColumnName("dateC");

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.EmailRpchot).HasColumnName("EmailRPCHot");

                entity.Property(e => e.EmailRpcother).HasColumnName("EmailRPCOther");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("label");

                entity.Property(e => e.Na).HasColumnName("NA");

                entity.Property(e => e.Nis).HasColumnName("NIS");

                entity.Property(e => e.NoRpc3rdPartyAnswered).HasColumnName("NoRPC3rdPartyAnswered");

                entity.Property(e => e.NoRpcsms).HasColumnName("NoRPCSMS");

                entity.Property(e => e.Norpcdisconnected).HasColumnName("NORPCDisconnected");

                entity.Property(e => e.NorpcgenericEmailSent).HasColumnName("NORPCGenericEmailSent");

                entity.Property(e => e.NorpchangUp).HasColumnName("NORPCHangUp");

                entity.Property(e => e.NorpcleftVoicemail).HasColumnName("NORPCLeftVoicemail");

                entity.Property(e => e.NorpcnoAnswer).HasColumnName("NORPCNoAnswer");

                entity.Property(e => e.Norpcskp).HasColumnName("NORPCSKP");

                entity.Property(e => e.NorpcwrongNumber).HasColumnName("NORPCWrongNumber");

                entity.Property(e => e.Optout).HasColumnName("OPTOUT");

                entity.Property(e => e.QbnoAnswer).HasColumnName("QBNoAnswer");

                entity.Property(e => e.RpcCvhangUp).HasColumnName("RpcCVHangUp");

                entity.Property(e => e.RpcDis).HasColumnName("RpcDIS");

                entity.Property(e => e.Rpccallbackanotherday).HasColumnName("RPCcallbackanotherday");

                entity.Property(e => e.Rpchot).HasColumnName("RPCHot");

                entity.Property(e => e.Rpcprp).HasColumnName("RPCPRP");

                entity.Property(e => e.Rpcsms).HasColumnName("RPCSMS");

                entity.Property(e => e.SalesFunnelCawa).HasColumnName("SalesFunnelCAWA");

                entity.Property(e => e.SalesFunnelCclo).HasColumnName("SalesFunnelCCLO");

                entity.Property(e => e.SalesFunnelChot).HasColumnName("SalesFunnelCHOT");

                entity.Property(e => e.SalesFunnelCitp).HasColumnName("SalesFunnelCITP");

                entity.Property(e => e.SalesFunnelCwon).HasColumnName("SalesFunnelCWON");

                entity.Property(e => e.SalesInquiryHotemailSent).HasColumnName("SalesInquiryHOTEmailSent");

                entity.Property(e => e.SalesInquiryItp).HasColumnName("SalesInquiryITP");

                entity.Property(e => e.SalesInquiryVmleft).HasColumnName("SalesInquiryVMLeft");

                entity.Property(e => e.SmsblockedUndelivered).HasColumnName("SMSBlockedUndelivered");

                entity.Property(e => e.SmspaymentReminder).HasColumnName("SMSPaymentReminder");

                entity.Property(e => e.Smssent).HasColumnName("SMSSent");

                entity.Property(e => e.SvPrp).HasColumnName("SvPRP");

                entity.Property(e => e.Svpay).HasColumnName("SVPay");
            });

            modelBuilder.Entity<ThrioAgentRpc>(entity =>
            {
                entity.ToTable("ThrioAgentRPC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgCallsPerHour)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("avgCallsPerHour");

                entity.Property(e => e.AvgTalkTime)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("avgTalkTime");

                entity.Property(e => e.AvgWrapupTime)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("avgWrapupTime");

                entity.Property(e => e.DateB)
                    .HasColumnType("date")
                    .HasColumnName("dateB");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("label");

                entity.Property(e => e.PercentageRpccalls)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("percentageRPCCalls");

                entity.Property(e => e.PercentageRpccloseRate)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("percentageRPCCloseRate");

                entity.Property(e => e.TalkTime).HasColumnName("talkTime");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalRpccalls).HasColumnName("totalRPCCalls");

                entity.Property(e => e.TotalRpccloseCalls).HasColumnName("totalRPCCloseCalls");

                entity.Property(e => e.TotalWorkinghours)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("totalWorkinghours");

                entity.Property(e => e.WrapupTime).HasColumnName("wrapupTime");
            });

            modelBuilder.Entity<ThrioAgentRpcDetail>(entity =>
            {
                entity.ToTable("ThrioAgentRpcDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgCallsPerHour)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("avgCallsPerHour");

                entity.Property(e => e.AvgTalkTime)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("avgTalkTime");

                entity.Property(e => e.AvgWrapupTime)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("avgWrapupTime");

                entity.Property(e => e.DateB)
                    .HasColumnType("date")
                    .HasColumnName("dateB");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .HasColumnName("label");

                entity.Property(e => e.PercentageRpccalls)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("percentageRPCCalls");

                entity.Property(e => e.PercentageRpccloseRate)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("percentageRPCCloseRate");

                entity.Property(e => e.TalkTime).HasColumnName("talkTime");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalRpccalls).HasColumnName("totalRPCCalls");

                entity.Property(e => e.TotalRpccloseCalls).HasColumnName("totalRPCCloseCalls");

                entity.Property(e => e.TotalWorkinghours)
                    .HasColumnType("decimal(25, 2)")
                    .HasColumnName("totalWorkinghours");

                entity.Property(e => e.WrapupTime).HasColumnName("wrapupTime");
            });

            modelBuilder.Entity<ThrioCallDetail>(entity =>
            {
                entity.ToTable("ThrioCallDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbandonTime).HasColumnName("abandonTime");

                entity.Property(e => e.Agentname).HasColumnName("agentname");

                entity.Property(e => e.CallId).HasColumnName("callId");

                entity.Property(e => e.Cdate).HasColumnType("date");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cost");

                entity.Property(e => e.CreatedAt).HasColumnName("createdAt");

                entity.Property(e => e.Disposition).HasColumnName("disposition");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.File).HasColumnName("file");

                entity.Property(e => e.From).HasColumnName("from");

                entity.Property(e => e.HandleTime).HasColumnName("handleTime");

                entity.Property(e => e.HoldTime).HasColumnName("holdTime");

                entity.Property(e => e.InReviewTime).HasColumnName("inReviewTime");

                entity.Property(e => e.IvrTime).HasColumnName("ivrTime");

                entity.Property(e => e.Label).HasColumnName("label");

                entity.Property(e => e.Minutes).HasColumnName("minutes");

                entity.Property(e => e.RecordingDuration).HasColumnName("recordingDuration");

                entity.Property(e => e.RingTime).HasColumnName("ringTime");

                entity.Property(e => e.TalkTime).HasColumnName("talkTime");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalQueueTime).HasColumnName("totalQueueTime");

                entity.Property(e => e.Transferred).HasColumnName("transferred");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.WrapupTime).HasColumnName("wrapupTime");
            });

            modelBuilder.Entity<ThrioCompainDisposition>(entity =>
            {
                entity.HasKey(e => e.IdA)
                    .HasName("PK_ThrioCompainDisposition_1");

                entity.ToTable("ThrioCompainDisposition");

                entity.Property(e => e.IdA).HasColumnName("id_A");

                entity.Property(e => e.Campaign)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campaign");

                entity.Property(e => e.CreatedAt).HasColumnName("createdAt");

                entity.Property(e => e.DateD)
                    .HasColumnType("date")
                    .HasColumnName("dateD");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("disposition");

                entity.Property(e => e.Duration)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("duration");

                entity.Property(e => e.From)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("from");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label");

                entity.Property(e => e.To)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("to");
            });

            modelBuilder.Entity<ThrioCompainDispositionLog>(entity =>
            {
                entity.ToTable("ThrioCompainDispositionLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Campaign)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campaign");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("date")
                    .HasColumnName("createdAt");

                entity.Property(e => e.DateD)
                    .HasColumnType("date")
                    .HasColumnName("dateD");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("disposition");

                entity.Property(e => e.Duration)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("duration");

                entity.Property(e => e.From)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("from");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label");

                entity.Property(e => e.To)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("to");
            });

            modelBuilder.Entity<ThrioDailyDisposition>(entity =>
            {
                entity.ToTable("ThrioDailyDisposition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.Label).HasColumnName("label");
            });

            modelBuilder.Entity<ThrioDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.InboundSms).HasColumnName("InboundSMS");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label");

                entity.Property(e => e.OutboundSms).HasColumnName("OutboundSMS");
            });

            modelBuilder.Entity<ThrioDetail>(entity =>
            {
                entity.ToTable("ThrioDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.InboundSms).HasColumnName("InboundSMS");

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label");

                entity.Property(e => e.OutboundSms).HasColumnName("OutboundSMS");
            });

            modelBuilder.Entity<Timezone>(entity =>
            {
                entity.ToTable("Timezone");

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Offset).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Timezonenumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("timezonenumber");
            });

            modelBuilder.Entity<TopClientDialCompaign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("top_client_dial_compaign");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeActive)
                    .IsUnicode(false)
                    .HasColumnName("de_active");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");
            });

            modelBuilder.Entity<TransactionReport>(entity =>
            {
                entity.ToTable("transaction_report");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.DirectPaymentCount).HasColumnName("direct_payment_count");

                entity.Property(e => e.DirectPaymentSum)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("direct_payment_sum");

                entity.Property(e => e.ListedDate)
                    .HasColumnType("date")
                    .HasColumnName("listed_date");

                entity.Property(e => e.MnthlyRcvrdAmnt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("mnthly_rcvrd_amnt");

                entity.Property(e => e.WeeklyRcvrdAmnt)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("weekly_rcvrd_amnt");
            });

            modelBuilder.Entity<TwilioSm>(entity =>
            {
                entity.HasKey(e => e.SmsId);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Direction).HasMaxLength(50);

                entity.Property(e => e.Disposition).HasMaxLength(150);

                entity.Property(e => e.From).HasMaxLength(50);

                entity.Property(e => e.Sid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.To).HasMaxLength(50);

                entity.Property(e => e.ViewBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WaldenReport>(entity =>
            {
                entity.ToTable("walden_report");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.DirectPaymentCount).HasColumnName("direct_payment_count");

                entity.Property(e => e.DirectPaymentSum)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("direct_payment_sum");

                entity.Property(e => e.ListedDate)
                    .HasColumnType("date")
                    .HasColumnName("listed_date");

                entity.Property(e => e.NoOfActiveFiles).HasColumnName("no_of_active_files");

                entity.Property(e => e.NoOfClosedFiles).HasColumnName("no_of_closed_files");

                entity.Property(e => e.NoOfDisputesFiles).HasColumnName("no_of_disputes_files");

                entity.Property(e => e.NoOfPaidFiles).HasColumnName("no_of_paid_files");

                entity.Property(e => e.TotalActiveFilesAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("total_active_files_amount");
            });

            modelBuilder.Entity<WaldenReportDirectPay>(entity =>
            {
                entity.ToTable("walden_report_direct_pay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.DirectPayCount).HasColumnName("direct_pay_count");

                entity.Property(e => e.DirectPaySum)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("direct_pay_sum");

                entity.Property(e => e.ListedDate)
                    .HasColumnType("date")
                    .HasColumnName("listed_date");
            });

            modelBuilder.Entity<ZeeJudgmentsInStatuteWith>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'Zee judgments in statute (with $'");

                entity.Property(e => e.AccNumber).HasColumnName("acc_number");
            });

            modelBuilder.Entity<_1stPriorityCompaignPriority1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("1st_priority_compaign.priority_1");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_1stPriorityCompaignPriority2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("1st_priority_compaign.priority_2");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_1stPriorityCompaignPriority3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("1st_priority_compaign.priority_3");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_1stPriorityCompaignPriority4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("1st_priority_compaign.priority_4");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_2ndPriorityCompaignPriority1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("2nd_priority_compaign.priority_1");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_2ndPriorityCompaignPriority2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("2nd_priority_compaign.priority_2");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_3rdPriorityCompaignPriority1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("3rd_priority_compaign.priority_1");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_3rdPriorityCompaignPriority2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("3rd_priority_compaign.priority_2");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_3rdPriorityCompaignPriority3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("3rd_priority_compaign.priority_3");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            modelBuilder.Entity<_3rdPriorityCompaignPriority4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("3rd_priority_compaign.priority_4");

                entity.Property(e => e.ClNumber).HasColumnName("cl_number");

                entity.Property(e => e.DeListedDate)
                    .HasColumnType("date")
                    .HasColumnName("de_listed_date");

                entity.Property(e => e.DeNumber).HasColumnName("de_number");

                entity.Property(e => e.DeOwing).HasColumnName("de_owing");

                entity.Property(e => e.DeStatus)
                    .IsUnicode(false)
                    .HasColumnName("de_status");

                entity.Property(e => e.Rpc).HasColumnName("RPC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

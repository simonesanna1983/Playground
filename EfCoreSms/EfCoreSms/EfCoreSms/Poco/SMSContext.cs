using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EfCoreSms.Poco
{
    public partial class SMSContext : DbContext
    {
        public SMSContext()
        {
        }

        public SMSContext(DbContextOptions<SMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<Dbversion> Dbversion { get; set; }
        public virtual DbSet<Dbversion1> Dbversion1 { get; set; }
        public virtual DbSet<GenStatus> GenStatus { get; set; }
        public virtual DbSet<GenType> GenType { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<StdAddCategoryAccessibility> StdAddCategoryAccessibility { get; set; }
        public virtual DbSet<StdAddCategoryCatering> StdAddCategoryCatering { get; set; }
        public virtual DbSet<StdAddCategoryConnectivity> StdAddCategoryConnectivity { get; set; }
        public virtual DbSet<StdAddCategoryGiantScreens> StdAddCategoryGiantScreens { get; set; }
        public virtual DbSet<StdAddCategoryLeisure> StdAddCategoryLeisure { get; set; }
        public virtual DbSet<StdAddCategoryPitch> StdAddCategoryPitch { get; set; }
        public virtual DbSet<StdAddCategorySustainability> StdAddCategorySustainability { get; set; }
        public virtual DbSet<StdAddress> StdAddress { get; set; }
        public virtual DbSet<StdAirportsRelated> StdAirportsRelated { get; set; }
        public virtual DbSet<StdAssignment> StdAssignment { get; set; }
        public virtual DbSet<StdAttachment> StdAttachment { get; set; }
        public virtual DbSet<StdCategory> StdCategory { get; set; }
        public virtual DbSet<StdCompletion> StdCompletion { get; set; }
        public virtual DbSet<StdContacts> StdContacts { get; set; }
        public virtual DbSet<StdDesignation> StdDesignation { get; set; }
        public virtual DbSet<StdFloodlight> StdFloodlight { get; set; }
        public virtual DbSet<StdIndoorFacilities> StdIndoorFacilities { get; set; }
        public virtual DbSet<StdInfrastructure> StdInfrastructure { get; set; }
        public virtual DbSet<StdInspection> StdInspection { get; set; }
        public virtual DbSet<StdMediaCameraPlatforms> StdMediaCameraPlatforms { get; set; }
        public virtual DbSet<StdMediaFacilities> StdMediaFacilities { get; set; }
        public virtual DbSet<StdMediaTribune> StdMediaTribune { get; set; }
        public virtual DbSet<StdMediaTvCommentaryPositions> StdMediaTvCommentaryPositions { get; set; }
        public virtual DbSet<StdOrganizationRelated> StdOrganizationRelated { get; set; }
        public virtual DbSet<StdPitch> StdPitch { get; set; }
        public virtual DbSet<StdSafetyCertificate> StdSafetyCertificate { get; set; }
        public virtual DbSet<StdSpectator> StdSpectator { get; set; }
        public virtual DbSet<StdStadium> StdStadium { get; set; }
        public virtual DbSet<StdStadiumCompetition> StdStadiumCompetition { get; set; }
        public virtual DbSet<StdStadiumLog> StdStadiumLog { get; set; }
        public virtual DbSet<StdStadiumMeta> StdStadiumMeta { get; set; }
        public virtual DbSet<StdUser> StdUser { get; set; }
        public virtual DbSet<XedsOrganization> XedsOrganization { get; set; }
        public virtual DbSet<XgeoCountry> XgeoCountry { get; set; }
        public virtual DbSet<XgeoVenue> XgeoVenue { get; set; }

        // Unable to generate entity type for table 'soa_stad_mng_hangfire.Counter'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SI-FDPR-03\\FOOTBALL;Initial Catalog=SMS;User ID=sa;Password=sharm");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "soa_stad_mng_hangfire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dbversion>(entity =>
            {
                entity.ToTable("dbversion", "soa_noteng_ts");

                entity.HasIndex(e => new { e.Major, e.Minor, e.Build, e.Revision })
                    .HasName("IX_Unique_Ver")
                    .IsUnique();

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateInsert).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dbversion1>(entity =>
            {
                entity.ToTable("dbversion", "soa_stad_mng");

                entity.HasIndex(e => new { e.Major, e.Minor, e.Build, e.Revision })
                    .HasName("IX_Unique_Ver")
                    .IsUnique();

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateInsert).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenStatus>(entity =>
            {
                entity.HasKey(e => new { e.Status, e.StatusId })
                    .HasName("PK_xgenStatus");

                entity.ToTable("genStatus", "soa_stad_mng");

                entity.Property(e => e.Status)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ChkStatus)
                    .HasColumnName("chkStatus")
                    .HasComputedColumnSql("(checksum([Status]))");

                entity.Property(e => e.StatusDescr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusIdparent).HasColumnName("StatusIDParent");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StatusNameAbbr)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatusParent)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRelated)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenType>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.TypeId })
                    .HasName("PK_xgenType");

                entity.ToTable("genType", "soa_stad_mng");

                entity.Property(e => e.Type)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.ChkType)
                    .HasColumnName("chkType")
                    .HasComputedColumnSql("(checksum([Type]))");

                entity.Property(e => e.TypeDescr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TypeIdparent).HasColumnName("TypeIDParent");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TypeNameAbbr)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeParent)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "soa_stad_mng_hangfire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "soa_stad_mng_hangfire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "soa_stad_mng_hangfire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "soa_stad_mng_hangfire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "soa_stad_mng_hangfire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "soa_stad_mng_hangfire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "soa_stad_mng_hangfire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "soa_stad_mng_hangfire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score })
                    .HasName("IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "soa_stad_mng_hangfire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<StdAddCategoryAccessibility>(entity =>
            {
                entity.ToTable("stdAddCategoryAccessibility", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdAddCategoryAccessibility")
                    .IsUnique();

                entity.Property(e => e.StdAddCategoryAccessibilityId).HasColumnName("stdAddCategoryAccessibilityID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdAddCategoryAccessibility)
                    .HasForeignKey<StdAddCategoryAccessibility>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAddCategoryAccessibility_stdStadium");
            });

            modelBuilder.Entity<StdAddCategoryCatering>(entity =>
            {
                entity.ToTable("stdAddCategoryCatering", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdAddCategoryCatering")
                    .IsUnique();

                entity.Property(e => e.StdAddCategoryCateringId).HasColumnName("stdAddCategoryCateringID");

                entity.Property(e => e.KindShopsDescription).HasMaxLength(1000);

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdAddCategoryCatering)
                    .HasForeignKey<StdAddCategoryCatering>(d => d.StdStadiumId)
                    .HasConstraintName("FK_[stdAddCategoryCatering_stdStadium");
            });

            modelBuilder.Entity<StdAddCategoryConnectivity>(entity =>
            {
                entity.ToTable("stdAddCategoryConnectivity", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdAddCategoryConnectivity")
                    .IsUnique();

                entity.Property(e => e.StdAddCategoryConnectivityId).HasColumnName("stdAddCategoryConnectivityID");

                entity.Property(e => e.AppWebsiteDescription).HasMaxLength(1000);

                entity.Property(e => e.CashlessPaymentName).HasMaxLength(1000);

                entity.Property(e => e.PaperlessTicketsName).HasMaxLength(1000);

                entity.Property(e => e.SocialMediaDescription).HasMaxLength(1000);

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdAddCategoryConnectivity)
                    .HasForeignKey<StdAddCategoryConnectivity>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAddCategoryConnectivity_stdStadium");
            });

            modelBuilder.Entity<StdAddCategoryGiantScreens>(entity =>
            {
                entity.ToTable("stdAddCategoryGiantScreens", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdAddCategoryGiantScreens")
                    .IsUnique();

                entity.Property(e => e.StdAddCategoryGiantScreensId).HasColumnName("stdAddCategoryGiantScreensID");

                entity.Property(e => e.IsLedperimeter).HasColumnName("IsLEDperimeter");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.UseDescription).HasMaxLength(1000);

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdAddCategoryGiantScreens)
                    .HasForeignKey<StdAddCategoryGiantScreens>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAddCategoryGiantScreens_stdStadium");
            });

            modelBuilder.Entity<StdAddCategoryLeisure>(entity =>
            {
                entity.ToTable("stdAddCategoryLeisure", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdAddCategoryLeisure")
                    .IsUnique();

                entity.Property(e => e.StdAddCategoryLeisureId).HasColumnName("stdAddCategoryLeisureID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdAddCategoryLeisure)
                    .HasForeignKey<StdAddCategoryLeisure>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAddCategoryLeisure_stdStadium");
            });

            modelBuilder.Entity<StdAddCategoryPitch>(entity =>
            {
                entity.ToTable("stdAddCategoryPitch", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdAddCategoryPitch")
                    .IsUnique();

                entity.Property(e => e.StdAddCategoryPitchId).HasColumnName("stdAddCategoryPitchID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdAddCategoryPitch)
                    .HasForeignKey<StdAddCategoryPitch>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAddCategoryPitch_stdStadium");
            });

            modelBuilder.Entity<StdAddCategorySustainability>(entity =>
            {
                entity.ToTable("stdAddCategorySustainability", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdAddCategorySustainability")
                    .IsUnique();

                entity.Property(e => e.StdAddCategorySustainabilityId).HasColumnName("stdAddCategorySustainabilityID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.StorageWaterDescription).HasMaxLength(1000);

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdAddCategorySustainability)
                    .HasForeignKey<StdAddCategorySustainability>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAddCategorySustainability_stdStadium");
            });

            modelBuilder.Entity<StdAddress>(entity =>
            {
                entity.ToTable("stdAddress", "soa_stad_mng");

                entity.Property(e => e.StdAddressId).HasColumnName("stdAddressID");

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBox")
                    .HasMaxLength(6);

                entity.Property(e => e.PostCode).HasMaxLength(20);

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.Street).HasMaxLength(500);

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdAddress)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAddress_stdStadium");
            });

            modelBuilder.Entity<StdAirportsRelated>(entity =>
            {
                entity.ToTable("stdAirportsRelated", "soa_stad_mng");

                entity.Property(e => e.StdAirportsRelatedId).HasColumnName("stdAirportsRelatedID");

                entity.Property(e => e.PlaceName).HasMaxLength(120);

                entity.Property(e => e.ShortName).HasMaxLength(30);

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.XgeoPlaceId).HasColumnName("xgeoPlaceID");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdAirportsRelated)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAirportsRelated_stdStadium");
            });

            modelBuilder.Entity<StdAssignment>(entity =>
            {
                entity.ToTable("stdAssignment", "soa_stad_mng");

                entity.HasIndex(e => new { e.StdStadiumId, e.XedsPersonId })
                    .HasName("IX_stdAssignment")
                    .IsUnique();

                entity.Property(e => e.StdAssignmentId).HasColumnName("stdAssignmentID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.XedsPersonId).HasColumnName("xedsPersonID");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdAssignment)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdAssignment_stdStadium");
            });

            modelBuilder.Entity<StdAttachment>(entity =>
            {
                entity.ToTable("stdAttachment", "soa_stad_mng");

                entity.HasIndex(e => e.FileName)
                    .HasName("IX_FileName");

                entity.HasIndex(e => e.Guid)
                    .HasName("IX_Guid")
                    .IsUnique();

                entity.HasIndex(e => new { e.RelatedId, e.TypeRelated })
                    .HasName("IX_RelatedID_TypeRelated");

                entity.Property(e => e.StdAttachmentId).HasColumnName("stdAttachmentID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FameUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.RelatedId).HasColumnName("RelatedID");
            });

            modelBuilder.Entity<StdCategory>(entity =>
            {
                entity.ToTable("stdCategory", "soa_stad_mng");

                entity.Property(e => e.StdCategoryId)
                    .HasColumnName("stdCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(120);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameAbbr).HasMaxLength(5);
            });

            modelBuilder.Entity<StdCompletion>(entity =>
            {
                entity.ToTable("stdCompletion", "soa_stad_mng");

                entity.Property(e => e.StdCompletionId).HasColumnName("stdCompletionID");

                entity.Property(e => e.StdInspectionId).HasColumnName("stdInspectionID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdCompletion)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdCompletion_stdStadium");
            });

            modelBuilder.Entity<StdContacts>(entity =>
            {
                entity.ToTable("stdContacts", "soa_stad_mng");

                entity.Property(e => e.StdContactsId).HasColumnName("stdContactsID");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.FirstName).HasMaxLength(500);

                entity.Property(e => e.LastName).HasMaxLength(500);

                entity.Property(e => e.Mobile).HasMaxLength(500);

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdContacts)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdContacts_stdStadium");
            });

            modelBuilder.Entity<StdDesignation>(entity =>
            {
                entity.ToTable("stdDesignation", "soa_stad_mng");

                entity.HasIndex(e => e.StdInspectionId)
                    .HasName("IX_stdDesignation")
                    .IsUnique();

                entity.Property(e => e.StdDesignationId).HasColumnName("stdDesignationID");

                entity.Property(e => e.FoffDesignationId).HasColumnName("foffDesignationID");

                entity.Property(e => e.StdInspectionId).HasColumnName("stdInspectionID");

                entity.Property(e => e.XedsPersonId).HasColumnName("xedsPersonID");

                entity.HasOne(d => d.StdInspection)
                    .WithOne(p => p.StdDesignation)
                    .HasForeignKey<StdDesignation>(d => d.StdInspectionId)
                    .HasConstraintName("FK_stdDesignation_stdInspection");
            });

            modelBuilder.Entity<StdFloodlight>(entity =>
            {
                entity.ToTable("stdFloodlight", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdFloodlight")
                    .IsUnique();

                entity.Property(e => e.StdFloodlightId).HasColumnName("stdFloodlightID");

                entity.Property(e => e.DateLightingCertif).HasColumnType("datetime");

                entity.Property(e => e.EmergencyPowerField).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.HorizontalU1).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.HorizontalU2).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.LuxAvEh).HasColumnName("LuxAvEH");

                entity.Property(e => e.LuxAvEv).HasColumnName("LuxAvEV");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.VerticalU1).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.VerticalU2).HasColumnType("decimal(4, 2)");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdFloodlight)
                    .HasForeignKey<StdFloodlight>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdFloodlight_stdStadium");
            });

            modelBuilder.Entity<StdIndoorFacilities>(entity =>
            {
                entity.ToTable("stdIndoorFacilities", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdIndoorFacilities")
                    .IsUnique();

                entity.Property(e => e.StdIndoorFacilitiesId).HasColumnName("stdIndoorFacilitiesID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdIndoorFacilities)
                    .HasForeignKey<StdIndoorFacilities>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdIndoorFacilities_stdStadium");
            });

            modelBuilder.Entity<StdInfrastructure>(entity =>
            {
                entity.ToTable("stdInfrastructure", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdInfrastructure")
                    .IsUnique();

                entity.Property(e => e.StdInfrastructureId).HasColumnName("stdInfrastructureID");

                entity.Property(e => e.DateConstruction).HasColumnType("datetime");

                entity.Property(e => e.DateOfTheTest).HasColumnType("datetime");

                entity.Property(e => e.DateRenovation).HasColumnType("datetime");

                entity.Property(e => e.IsFifavartechnologyTestComplete).HasColumnName("IsFIFAVARTechnologyTestComplete");

                entity.Property(e => e.IsGlt).HasColumnName("IsGLT");

                entity.Property(e => e.IsVarfacilities).HasColumnName("IsVARFacilities");

                entity.Property(e => e.RenovationSummary).HasMaxLength(1000);

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdInfrastructure)
                    .HasForeignKey<StdInfrastructure>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdInfrastructure_stdStadium");
            });

            modelBuilder.Entity<StdInspection>(entity =>
            {
                entity.ToTable("stdInspection", "soa_stad_mng");

                entity.Property(e => e.StdInspectionId).HasColumnName("stdInspectionID");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedUtc)
                    .HasColumnName("DateCreatedUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateInspection).HasColumnType("datetime");

                entity.Property(e => e.DateUpdateUtc)
                    .HasColumnName("DateUpdateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsMediaTribuneUefacompliant).HasColumnName("IsMediaTribuneUEFACompliant");

                entity.Property(e => e.IsTvcommentaryPositionsCompliant).HasColumnName("IsTVCommentaryPositionsCompliant");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.TvmediaFacilitiesShortSummary).HasColumnName("TVMediaFacilitiesShortSummary");

                entity.Property(e => e.UserCreatedId).HasColumnName("UserCreatedID");

                entity.Property(e => e.UserUpdateId).HasColumnName("UserUpdateID");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdInspection)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdInspection_stdStadium");
            });

            modelBuilder.Entity<StdMediaCameraPlatforms>(entity =>
            {
                entity.ToTable("stdMediaCameraPlatforms", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdMediaCameraPlatforms")
                    .IsUnique();

                entity.Property(e => e.StdMediaCameraPlatformsId).HasColumnName("stdMediaCameraPlatformsID");

                entity.Property(e => e.MainDepth).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.MainWidth).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdMediaCameraPlatforms)
                    .HasForeignKey<StdMediaCameraPlatforms>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdMediaCameraPlatforms_stdStadium");
            });

            modelBuilder.Entity<StdMediaFacilities>(entity =>
            {
                entity.ToTable("stdMediaFacilities", "soa_stad_mng");

                entity.HasIndex(e => e.StdMediaFacilitiesId)
                    .HasName("IX_stdSpectator")
                    .IsUnique();

                entity.Property(e => e.StdMediaFacilitiesId).HasColumnName("stdMediaFacilitiesID");

                entity.Property(e => e.CapacityIndoorTvstudios).HasColumnName("CapacityIndoorTVStudios");

                entity.Property(e => e.CapacityViewTvstudios).HasColumnName("CapacityViewTVStudios");

                entity.Property(e => e.DimTvcompound)
                    .HasColumnName("DimTVCompound")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.IsIndoorTvstudios).HasColumnName("IsIndoorTVStudios");

                entity.Property(e => e.IsPitchViewTvstudios).HasColumnName("IsPitchViewTVStudios");

                entity.Property(e => e.IsTvcompound).HasColumnName("IsTVCompound");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdMediaFacilities)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdMediaFacilities_stdStadium");
            });

            modelBuilder.Entity<StdMediaTribune>(entity =>
            {
                entity.ToTable("stdMediaTribune", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdMediaTribune")
                    .IsUnique();

                entity.Property(e => e.StdMediaTribuneId).HasColumnName("stdMediaTribuneID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdMediaTribune)
                    .HasForeignKey<StdMediaTribune>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdMediaTribune_stdStadium");
            });

            modelBuilder.Entity<StdMediaTvCommentaryPositions>(entity =>
            {
                entity.ToTable("stdMediaTvCommentaryPositions", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdMediaTvCommentaryPositions")
                    .IsUnique();

                entity.Property(e => e.StdMediaTvCommentaryPositionsId).HasColumnName("stdMediaTvCommentaryPositionsID");

                entity.Property(e => e.IsTvcommentaryPositions).HasColumnName("IsTVCommentaryPositions");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdMediaTvCommentaryPositions)
                    .HasForeignKey<StdMediaTvCommentaryPositions>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdMediaTvCommentaryPositions_stdStadium");
            });

            modelBuilder.Entity<StdOrganizationRelated>(entity =>
            {
                entity.ToTable("stdOrganizationRelated", "soa_stad_mng");

                entity.HasIndex(e => new { e.StdStadiumId, e.XedsOrganizationId })
                    .HasName("IX_stdOrganizationRelated")
                    .IsUnique();

                entity.Property(e => e.StdOrganizationRelatedId).HasColumnName("stdOrganizationRelatedID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.XedsOrganizationId).HasColumnName("xedsOrganizationID");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdOrganizationRelated)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdOrganizationRelated_stdStadium");

                entity.HasOne(d => d.XedsOrganization)
                    .WithMany(p => p.StdOrganizationRelated)
                    .HasPrincipalKey(p => p.XedsOrganizationId)
                    .HasForeignKey(d => d.XedsOrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stdOrganizationRelated_xedsOrganization");
            });

            modelBuilder.Entity<StdPitch>(entity =>
            {
                entity.ToTable("stdPitch", "soa_stad_mng");

                entity.Property(e => e.StdPitchId).HasColumnName("stdPitchID");

                entity.Property(e => e.DateExpiry).HasColumnType("datetime");

                entity.Property(e => e.DimPitchLength).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.DimPitchWidth).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.IrrigationSystemDescription).HasMaxLength(500);

                entity.Property(e => e.IsGoalCompliantIfab).HasColumnName("IsGoalCompliantIFAB");

                entity.Property(e => e.ProtectionFrostDescription).HasMaxLength(500);

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.TypeFifacategory).HasColumnName("TypeFIFACategory");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdPitch)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdPitch_stdStadium");
            });

            modelBuilder.Entity<StdSafetyCertificate>(entity =>
            {
                entity.ToTable("stdSafetyCertificate", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdSafetyCertificate")
                    .IsUnique();

                entity.Property(e => e.StdSafetyCertificateId).HasColumnName("stdSafetyCertificateID");

                entity.Property(e => e.DateOfExpiry).HasColumnType("date");

                entity.Property(e => e.DateOfIssue).HasColumnType("date");

                entity.Property(e => e.NafacilitiesDescription)
                    .HasColumnName("NAFacilitiesDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdSafetyCertificate)
                    .HasForeignKey<StdSafetyCertificate>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdSafetyCertificate_stdStadium");
            });

            modelBuilder.Entity<StdSpectator>(entity =>
            {
                entity.ToTable("stdSpectator", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdSpectator")
                    .IsUnique();

                entity.Property(e => e.StdSpectatorId).HasColumnName("stdSpectatorID");

                entity.Property(e => e.IsCctvavailable).HasColumnName("IsCCTVAvailable");

                entity.Property(e => e.IsDedicatedHospitalityVip).HasColumnName("IsDedicatedHospitalityVIP");

                entity.Property(e => e.NumVvipSeats).HasColumnName("NumVVipSeats");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdSpectator)
                    .HasForeignKey<StdSpectator>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdSpectator_stdStadium");
            });

            modelBuilder.Entity<StdStadium>(entity =>
            {
                entity.ToTable("stdStadium", "soa_stad_mng");

                entity.Property(e => e.StdStadiumId)
                    .HasColumnName("stdStadiumID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FcompStadiumId).HasColumnName("fcompStadiumID");

                entity.Property(e => e.MediaName).HasMaxLength(500);

                entity.Property(e => e.NormalizeName).HasMaxLength(500);

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.OfficialName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProposedCategoryId).HasColumnName("ProposedCategoryID");

                entity.Property(e => e.SpecialEventsName).HasMaxLength(500);

                entity.Property(e => e.SponsorName).HasMaxLength(500);

                entity.Property(e => e.StadiumOwnerFreeText).HasMaxLength(500);

                entity.Property(e => e.StdCategoryId).HasColumnName("stdCategoryID");

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.StdCategory)
                    .WithMany(p => p.StdStadium)
                    .HasForeignKey(d => d.StdCategoryId)
                    .HasConstraintName("FK_stdStadium_stdCategory");
            });

            modelBuilder.Entity<StdStadiumCompetition>(entity =>
            {
                entity.ToTable("stdStadiumCompetition", "soa_stad_mng");

                entity.HasIndex(e => new { e.StdStadiumId, e.FcompCompetitionId })
                    .HasName("IX_stdStadiumCompetition")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompetitionName).HasMaxLength(80);

                entity.Property(e => e.CompetitionShortName).HasMaxLength(50);

                entity.Property(e => e.CompetitionTypeAcronymName).HasMaxLength(50);

                entity.Property(e => e.CompetitionTypeName).HasMaxLength(80);

                entity.Property(e => e.CompetitionTypeShortName).HasMaxLength(50);

                entity.Property(e => e.ConfederationId).HasColumnName("ConfederationID");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.FcompCompetitionId).HasColumnName("fcompCompetitionID");

                entity.Property(e => e.FcompCompetitionTypeId).HasColumnName("fcompCompetitionTypeID");

                entity.Property(e => e.OrganizationShortName).HasMaxLength(20);

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.XmlRounds).HasColumnType("xml");

                entity.Property(e => e.XmlTeams).HasColumnType("xml");
            });

            modelBuilder.Entity<StdStadiumLog>(entity =>
            {
                entity.ToTable("stdStadiumLog", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumLogId)
                    .HasName("IX_stdStadiumLog")
                    .IsUnique();

                entity.Property(e => e.StdStadiumLogId).HasColumnName("stdStadiumLogID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.StdStadium)
                    .WithMany(p => p.StdStadiumLog)
                    .HasForeignKey(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdStadiumLog_stdStadium");
            });

            modelBuilder.Entity<StdStadiumMeta>(entity =>
            {
                entity.ToTable("stdStadiumMeta", "soa_stad_mng");

                entity.HasIndex(e => e.StdStadiumId)
                    .HasName("IX_stdStadiumMeta")
                    .IsUnique();

                entity.Property(e => e.StdStadiumMetaId).HasColumnName("stdStadiumMetaID");

                entity.Property(e => e.DateCreatedUtc)
                    .HasColumnName("DateCreatedUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdateUtc)
                    .HasColumnName("DateUpdateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.StdStadiumId).HasColumnName("stdStadiumID");

                entity.Property(e => e.UserCreatedId).HasColumnName("UserCreatedID");

                entity.Property(e => e.UserUpdateId).HasColumnName("UserUpdateID");

                entity.HasOne(d => d.StdStadium)
                    .WithOne(p => p.StdStadiumMeta)
                    .HasForeignKey<StdStadiumMeta>(d => d.StdStadiumId)
                    .HasConstraintName("FK_stdStadiumMeta_stdStadium");
            });

            modelBuilder.Entity<StdUser>(entity =>
            {
                entity.ToTable("stdUser", "soa_stad_mng");

                entity.HasIndex(e => e.Login)
                    .HasName("IX_stdUserLogin")
                    .IsUnique();

                entity.HasIndex(e => e.StdUserId)
                    .HasName("IX_stdUserID")
                    .IsUnique();

                entity.Property(e => e.StdUserId).HasColumnName("stdUserID");

                entity.Property(e => e.FirstName).HasMaxLength(80);

                entity.Property(e => e.LastName).HasMaxLength(80);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.RealOrganizationId).HasColumnName("realOrganizationID");

                entity.Property(e => e.TypeTeamBw).HasColumnName("TypeTeamBW");

                entity.Property(e => e.XedsOrganizationId).HasColumnName("xedsOrganizationID");

                entity.Property(e => e.XedsPersonId).HasColumnName("xedsPersonID");
            });

            modelBuilder.Entity<XedsOrganization>(entity =>
            {
                entity.ToTable("xedsOrganization", "soa_stad_mng");

                entity.HasIndex(e => e.XedsOrganizationId)
                    .HasName("IX_xedsOrganization")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FootballNormalizeName).HasMaxLength(255);

                entity.Property(e => e.NormalizeName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.XedsOrganizationId).HasColumnName("xedsOrganizationID");

                entity.Property(e => e.XgeoCountryId).HasColumnName("xgeoCountryID");
            });

            modelBuilder.Entity<XgeoCountry>(entity =>
            {
                entity.ToTable("xgeoCountry", "soa_stad_mng");

                entity.Property(e => e.XgeoCountryId)
                    .HasColumnName("xgeoCountryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Ioccode)
                    .HasColumnName("IOCcode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.JoinedCountryId).HasColumnName("JoinedCountryID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.NormalizeName).HasMaxLength(50);
            });

            modelBuilder.Entity<XgeoVenue>(entity =>
            {
                entity.ToTable("xgeoVenue", "soa_stad_mng");

                entity.HasIndex(e => e.XgeoVenueId)
                    .HasName("IX_xgeoVenue")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NormalizeName).HasMaxLength(50);

                entity.Property(e => e.VenueCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VenueName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.XgeoCountryId).HasColumnName("xgeoCountryID");

                entity.Property(e => e.XgeoVenueId).HasColumnName("xgeoVenueID");
            });
        }
    }
}

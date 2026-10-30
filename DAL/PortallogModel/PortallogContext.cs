using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.PortallogModel
{
    public partial class PortallogContext : DbContext
    {
        public PortallogContext()
        {
        }

        public PortallogContext(DbContextOptions<PortallogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<ElmahError> ElmahErrors { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<Support> Supports { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.20.93;Initial Catalog=PortalLog;persist security info=True;User id=sa;Password=sa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity1)
                    .HasMaxLength(50)
                    .HasColumnName("activity");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LoginTime).HasColumnName("loginTime");

                entity.Property(e => e.LogoutTime).HasColumnName("logoutTime");

                entity.Property(e => e.MacAddress)
                    .HasMaxLength(100)
                    .HasColumnName("mac_address");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .HasColumnName("url");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ElmahError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ELMAH_Error");

                entity.Property(e => e.AllXml).HasColumnType("ntext");

                entity.Property(e => e.Application).HasMaxLength(60);

                entity.Property(e => e.Host).HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(500);

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

                entity.Property(e => e.Source).HasMaxLength(60);

                entity.Property(e => e.TimeUtc).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.User).HasMaxLength(50);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("Holiday");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Approved)
                    .HasMaxLength(50)
                    .HasColumnName("approved");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.Office)
                    .HasMaxLength(50)
                    .HasColumnName("office");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");
            });

            modelBuilder.Entity<Support>(entity =>
            {
                entity.ToTable("Support");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .HasMaxLength(50)
                    .HasColumnName("activity");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ErrorOnLine).HasMaxLength(50);

                entity.Property(e => e.FixedBy).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .HasColumnName("subject");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .HasColumnName("time");

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .HasColumnName("url");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

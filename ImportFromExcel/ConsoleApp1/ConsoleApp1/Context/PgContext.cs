using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace ConsoleApp1.Model
{
    public partial class PgContext : DbContext
    {
        public PgContext()
        {
        }

        public PgContext(DbContextOptions<PgContext> options)
            : base(options)
        {
        }

        public static readonly ILoggerFactory loggerFactory
            = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name
                        && level == LogLevel.Information)
                    .AddConsole();
            });

        public virtual DbSet<Cities> CitiesDbSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLoggerFactory(loggerFactory);

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=ec2-54-247-82-14.eu-west-1.compute.amazonaws.com;Database=d50v72eskuarqg;Username=fnttdvuyxzgnyo;Password=04a2c1365634d1ee37a6f60f1d29b8940ceae1607cdfe04fb054004414fa37c0;SSL Mode=Require;Trust Server Certificate=true");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("cities", "sis");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.CodiceCatastale).HasColumnType("character varying");

                entity.Property(e => e.CodiceComune).HasColumnType("character varying");

                entity.Property(e => e.DenominazioneAltraLingua).HasColumnType("character varying");

                entity.Property(e => e.DenominazioneItaliana).HasColumnType("character varying");

                entity.Property(e => e.DenominazioneItalianaStraniera).HasColumnType("character varying");

                entity.Property(e => e.DenominazioneRegione).HasColumnType("character varying");

                entity.Property(e => e.DenominazioneUnita).HasColumnType("character varying");

                entity.Property(e => e.Nuts1)
                    .HasColumnName("NUTS1")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nuts2)
                    .HasColumnName("NUTS2")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nuts3)
                    .HasColumnName("NUTS3")
                    .HasColumnType("character varying");

                entity.Property(e => e.RipartizioneGeografica).HasColumnType("character varying");

                entity.Property(e => e.SiglaAutomobilistica).HasColumnType("character varying");
            });
        }
    }
}

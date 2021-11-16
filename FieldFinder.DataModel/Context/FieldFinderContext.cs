using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FieldFinder.DataModel.Model;

#nullable disable

namespace FieldFinder.DataModel.Context
{
    public partial class FieldFinderContext : DbContext
    {
        public FieldFinderContext()
        {
        }

        public FieldFinderContext(DbContextOptions<FieldFinderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FieldSchedule> FieldSchedules { get; set; }
        public virtual DbSet<RefFieldType> RefFieldTypes { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }
        public virtual DbSet<VenueAddress> VenueAddresses { get; set; }
        public virtual DbSet<VenueField> VenueFields { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=GERBOT\\ASSASINS13;Database=FieldFinder;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<FieldSchedule>(entity =>
            {
                entity.ToTable("FieldSchedule");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.DayNight)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Discount)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsBooked)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IsSystemCopy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OverridePrice).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.ScheduleDt).HasColumnType("date");

                entity.HasOne(d => d.VenueField)
                    .WithMany(p => p.FieldSchedules)
                    .HasForeignKey(d => d.VenueFieldId)
                    .HasConstraintName("FK__FieldSche__Venue__2F10007B");
            });

            modelBuilder.Entity<RefFieldType>(entity =>
            {
                entity.ToTable("RefFieldType");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.FieldTypeCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FieldTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Venue>(entity =>
            {
                entity.ToTable("Venue");

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstablishedDt).HasColumnType("date");

                entity.Property(e => e.VenueName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VenueOwner)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VenueAddress>(entity =>
            {
                entity.ToTable("VenueAddress");

                entity.Property(e => e.AddressDetail)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.District)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.VenueAddresses)
                    .HasForeignKey(d => d.VenueId)
                    .HasConstraintName("FK__VenueAddr__Venue__267ABA7A");
            });

            modelBuilder.Entity<VenueField>(entity =>
            {
                entity.ToTable("VenueField");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(17, 2)");

                entity.HasOne(d => d.RefFieldType)
                    .WithMany(p => p.VenueFields)
                    .HasForeignKey(d => d.RefFieldTypeId)
                    .HasConstraintName("FK__VenueFiel__RefFi__2C3393D0");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.VenueFields)
                    .HasForeignKey(d => d.VenueId)
                    .HasConstraintName("FK__VenueFiel__Venue__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

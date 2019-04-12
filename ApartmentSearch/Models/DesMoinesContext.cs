using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace ApartmentSearch.Models
{
    public partial class DesMoinesContext : DbContext
    {
        public DesMoinesContext(DbContextOptions<DesMoinesContext> options) : base(options)
        {
        }

        public virtual DbSet<ApartmentComplexAddresses> ApartmentComplexAddresses { get; set; }
        public virtual DbSet<ApartmentComplexContacts> ApartmentComplexContacts { get; set; }
        public virtual DbSet<ApartmentComplexFees> ApartmentComplexFees { get; set; }
        public virtual DbSet<ApartmentComplexUtilities> ApartmentComplexUtilities { get; set; }
        public virtual DbSet<ApartmentComplexes> ApartmentComplexes { get; set; }
        public virtual DbSet<ApartmentFloorPlan> ApartmentFloorPlan { get; set; }
        public virtual DbSet<ApartmentRating> ApartmentRating { get; set; }
        public virtual DbSet<ApartmentStyle> ApartmentStyle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<ApartmentComplexAddresses>(entity =>
            {
                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine2).HasMaxLength(50);

                entity.Property(e => e.AddressLine3).HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<ApartmentComplexContacts>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ApartmentComplexFees>(entity =>
            {
                entity.Property(e => e.AdministrativeFee).HasColumnType("money");

                entity.Property(e => e.ApplicationFee).HasColumnType("money");

                entity.Property(e => e.GarageFee).HasColumnType("money");

                entity.Property(e => e.PetFee).HasColumnType("money");

                entity.Property(e => e.PetRent).HasColumnType("money");

                entity.Property(e => e.SecurityDeposit).HasColumnType("money");

                entity.HasOne(d => d.Utility)
                    .WithMany(p => p.ApartmentComplexFees)
                    .HasForeignKey(d => d.UtilityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ApartmentComplexFees_ApartmentComplexUtilities");
            });

            modelBuilder.Entity<ApartmentComplexUtilities>(entity =>
            {
                entity.Property(e => e.Cable).HasColumnType("money");

                entity.Property(e => e.Electricity).HasColumnType("money");

                entity.Property(e => e.Garbage).HasColumnType("money");

                entity.Property(e => e.Gas).HasColumnType("money");

                entity.Property(e => e.Internet).HasColumnType("money");

                entity.Property(e => e.Water).HasColumnType("money");
            });

            modelBuilder.Entity<ApartmentComplexes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ApartmentComplexes)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_ApartmentComplexes_ApartmentComplexAddresses");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ApartmentComplexes)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_ApartmentComplexes_ApartmentComplexContacts");

                entity.HasOne(d => d.Fees)
                    .WithMany(p => p.ApartmentComplexes)
                    .HasForeignKey(d => d.FeesId)
                    .HasConstraintName("FK_ApartmentComplexes_ApartmentComplexFees");
            });

            modelBuilder.Entity<ApartmentFloorPlan>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rent).HasColumnType("money");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.ApartmentFloorPlan)
                    .HasForeignKey(d => d.RatingId)
                    .HasConstraintName("FK_ApartmentFloorPlan_ApartmentRating");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.ApartmentFloorPlan)
                    .HasForeignKey(d => d.StyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApartmentFloorPlan_ApartmentStyle");
            });

            modelBuilder.Entity<ApartmentRating>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<ApartmentStyle>(entity =>
            {
                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}

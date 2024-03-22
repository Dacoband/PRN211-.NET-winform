using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace PetStore_MaVanMeo_Repository.Models
{
    public partial class PetShop2023DBContext : DbContext
    {
        public PetShop2023DBContext()
        {
        }

        public PetShop2023DBContext(DbContextOptions<PetShop2023DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pet> Pets { get; set; } = null!;
        public virtual DbSet<PetGroup> PetGroups { get; set; } = null!;
        public virtual DbSet<PetShopMember> PetShopMembers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
            var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];

            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>(entity =>
            {
                entity.ToTable("Pet");

                entity.Property(e => e.PetId).ValueGeneratedNever();

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.PetDescription).HasMaxLength(220);

                entity.Property(e => e.PetGroupId).HasMaxLength(20);

                entity.Property(e => e.PetName).HasMaxLength(200);

                entity.HasOne(d => d.PetGroup)
                    .WithMany(p => p.Pets)
                    .HasForeignKey(d => d.PetGroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Pet__PetGroupId__29572725");
            });

            modelBuilder.Entity<PetGroup>(entity =>
            {
                entity.ToTable("PetGroup");

                entity.Property(e => e.PetGroupId).HasMaxLength(20);

                entity.Property(e => e.GroupDescription).HasMaxLength(150);

                entity.Property(e => e.OriginalSource).HasMaxLength(60);

                entity.Property(e => e.PetGroupName).HasMaxLength(80);
            });

            modelBuilder.Entity<PetShopMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__PetShopM__0CF04B380AFADED4");

                entity.ToTable("PetShopMember");

                entity.HasIndex(e => e.EmailAddress, "UQ__PetShopM__49A14740F07EED01")
                    .IsUnique();

                entity.Property(e => e.MemberId)
                    .HasMaxLength(20)
                    .HasColumnName("MemberID");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(80);

                entity.Property(e => e.MemberPassword).HasMaxLength(80);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

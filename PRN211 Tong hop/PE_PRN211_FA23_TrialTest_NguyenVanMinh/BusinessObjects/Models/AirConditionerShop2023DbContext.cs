using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects.Models;

public partial class AirConditionerShop2023DbContext : DbContext
{
    public AirConditionerShop2023DbContext()
    {
    }

    public AirConditionerShop2023DbContext(DbContextOptions<AirConditionerShop2023DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AirConditioner> AirConditioners { get; set; }

    public virtual DbSet<StaffMember> StaffMembers { get; set; }

    public virtual DbSet<SupplierCompany> SupplierCompanies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(GetConnectionString());

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AirConditioner>(entity =>
        {
            entity.HasKey(e => e.AirConditionerId).HasName("PK__AirCondi__EE2EB739BAB334E2");

            entity.ToTable("AirConditioner");

            entity.Property(e => e.AirConditionerId).ValueGeneratedNever();
            entity.Property(e => e.AirConditionerName).HasMaxLength(200);
            entity.Property(e => e.FeatureFunction).HasMaxLength(250);
            entity.Property(e => e.SoundPressureLevel).HasMaxLength(80);
            entity.Property(e => e.SupplierId).HasMaxLength(20);
            entity.Property(e => e.Warranty).HasMaxLength(60);

            entity.HasOne(d => d.Supplier).WithMany(p => p.AirConditioners)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__AirCondit__Suppl__4E88ABD4");
        });

        modelBuilder.Entity<StaffMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__StaffMem__0CF04B38A996683B");

            entity.ToTable("StaffMember");

            entity.HasIndex(e => e.EmailAddress, "UQ__StaffMem__49A1474009F91F3D").IsUnique();

            entity.Property(e => e.MemberId)
                .ValueGeneratedNever()
                .HasColumnName("MemberID");
            entity.Property(e => e.EmailAddress).HasMaxLength(60);
            entity.Property(e => e.FullName).HasMaxLength(60);
            entity.Property(e => e.Password).HasMaxLength(40);
        });

        modelBuilder.Entity<SupplierCompany>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE666B4B46B8A59");

            entity.ToTable("SupplierCompany");

            entity.Property(e => e.SupplierId).HasMaxLength(20);
            entity.Property(e => e.PlaceOfOrigin).HasMaxLength(60);
            entity.Property(e => e.SupplierDescription).HasMaxLength(250);
            entity.Property(e => e.SupplierName).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    private string GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DBDefault"];
    }
}

using CTC.Core.Entitys;
using Microsoft.EntityFrameworkCore;

namespace CTC.Infrastructure
{
    public class CongestionTaxDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<CongestionTaxRate> CongestionTaxRates { get; set; }
        public DbSet<ExemptVehicleType> ExemptVehicleTypes { get; set; }
        public DbSet<CongestionTaxEntry> CongestionTaxEntries { get; set; }
        public DbSet<TaxCalculationResult> TaxCalculationResults { get; set; }

        public CongestionTaxDbContext(DbContextOptions<CongestionTaxDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Vehicle entity
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<Vehicle>()
                .HasKey(v => v.Id);
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.VehicleType.ToString())
                .WithMany();

            // Configure the CongestionTaxRate entity
            modelBuilder.Entity<CongestionTaxRate>().ToTable("CongestionTaxRates");
            modelBuilder.Entity<CongestionTaxRate>()
                .HasKey(t => t.Id);

            // Configure the ExemptVehicleType entity
            modelBuilder.Entity<ExemptVehicleType>().ToTable("ExemptVehicleTypes");
            modelBuilder.Entity<ExemptVehicleType>()
                .HasKey(e => e.Id);

            // Configure the CongestionTaxEntry entity
            modelBuilder.Entity<CongestionTaxEntry>().ToTable("CongestionTaxEntries");
            modelBuilder.Entity<CongestionTaxEntry>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<CongestionTaxEntry>()
                .HasOne(c => c.Vehicle)
                .WithMany()
                .HasForeignKey(c => c.Vehicle.Id);

            // Configure the TaxCalculationResult entity
            modelBuilder.Entity<TaxCalculationResult>().ToTable("TaxCalculationResults");
            modelBuilder.Entity<TaxCalculationResult>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<TaxCalculationResult>()
                .HasOne(t => t.Entry)
                .WithOne()
                .HasForeignKey<TaxCalculationResult>(t => t.Id);


            base.OnModelCreating(modelBuilder);
        }
    }


}
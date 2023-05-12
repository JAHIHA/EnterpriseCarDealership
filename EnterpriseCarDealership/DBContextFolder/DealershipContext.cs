using EnterpriseCarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCarDealership.DBContextFolder
{
    public class DealershipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Secret.GetConnectionString);

        }
        public virtual DbSet<Bike> Bike
        {
            get; set;
        }
        public virtual DbSet<Car> Car
        {
            get; set;
        }
        public virtual DbSet<CarBooking> CarBooking { get; set; }
        public virtual DbSet<BikeBooking> BikeBooking { get; set; }
        public virtual DbSet<Medarbejder> Medarbejder { get; set; }
        public virtual DbSet<Kunde> Kunde { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<CarPayment> CarPayment { get; set; }
        public virtual DbSet<BikePayment> BikePayment { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Bike>()
    .HasKey(b => b.NextId);

            modelBuilder.Entity<Bike>()
                .Property(b => b.NextId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Car>()
.HasKey(b => b.NextId);

            modelBuilder.Entity<Car>()
                .Property(b => b.NextId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Medarbejder>()
.HasKey(b => b.NextId);

            modelBuilder.Entity<Medarbejder>()
                .Property(b => b.NextId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Kunde>()
.HasKey(b => b.NextId);

            modelBuilder.Entity<Kunde>()
                .Property(b => b.NextId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Manager>()
.HasKey(b => b.NextId);

            modelBuilder.Entity<Manager>()
                .Property(b => b.NextId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<BikePayment>()
.HasKey(b => b.NextId);

            modelBuilder.Entity<BikePayment>()
                .Property(b => b.NextId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<CarPayment>()
.HasKey(b => b.NextId);

            modelBuilder.Entity<CarPayment>()
                .Property(b => b.NextId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();



            modelBuilder
                .Entity<Bike>()
                .Property(b => b.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (MotorType)Enum.Parse(typeof(MotorType), v));


        }
    }

}

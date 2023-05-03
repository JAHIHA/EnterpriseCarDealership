using EnterpriseCarDealership.Models;
using Microsoft.EntityFrameworkCore;
namespace EnterpriseCarDealership.DBContextFolder
{
    public class DealershipContext:DbContext
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
        public virtual DbSet<BikeBooking> BBooking { get; set; }
        public virtual DbSet<Medarbejder> Medarbejder{ get; set; }

    }
}
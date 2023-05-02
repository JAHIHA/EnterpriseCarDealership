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
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Medarbejder> Medarbejder{ get; set; }

    }
}
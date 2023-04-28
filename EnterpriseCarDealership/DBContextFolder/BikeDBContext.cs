using EnterpriseCarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCarDealership.DBContextFolder
{
    public class BikeDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Secret.GetConnectionString);
        }
        public virtual DbSet<Bike> Bike
        {
            get; set;
        }
    }
}

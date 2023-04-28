using EnterpriseCarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCarDealership.DBContextFolder
{
    public class BookingDBContext:DbContext
    {
        
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(Secret.GetConnectionString);
            }
            public virtual DbSet<Booking> Booking { get; set; }
        
    }
}

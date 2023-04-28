using Microsoft.EntityFrameworkCore;
namespace EnterpriseCarDealership.DBContextFolder
{
    public class DBContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Secret.GetConnectionString);
        }
    }
}
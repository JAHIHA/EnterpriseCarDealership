using EnterpriseCarDealership.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EnterpriseCarDealership.DBContextFolder
{
    public class CarDBContext : DBContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Secret.GetConnectionString);
        }
        public virtual DbSet<Car> Car { get; set; }

    }
}


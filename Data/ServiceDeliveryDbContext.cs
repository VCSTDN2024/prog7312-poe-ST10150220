using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDeliveryPOE.Data
{
    public class ServiceDeliveryDbContext : DbContext
    {
        public DbSet<Report> Reports { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ServiceDeliveryDb"].ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}

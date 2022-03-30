using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruckTravelsCRUD.Models;

namespace TruckTravelsCRUD.Models
{
    public class DataBase : DbContext
    {
        public DbSet<Truck> Trucks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\sqlexpress;Initial Catalog=CrudTruck;Integrated Security=True");
        }
        public DbSet<TruckTravelsCRUD.Models.Driver> Driver { get; set; }
        public DbSet<TruckTravelsCRUD.Models.Travel> Travel { get; set; }
    }
}

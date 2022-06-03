using BiletRezervasyon.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletRezervasyon.Data.Concrete.EFcore
{
    public class BookingContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BookingDb");
        }
    }
}

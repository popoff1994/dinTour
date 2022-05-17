using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dinTour.Models
{
    public class dinTourDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dinTourDB; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        }

        public DbSet<Parkering> Parkering { get; set; }
        public DbSet<Deltager> Deltagere { get; set; }
        public DbSet<Begivenhed> Begivenheder { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Bookning> Booknings { get; set; }

        public DbSet<VIP> VIPs { get; set; }



    }
}

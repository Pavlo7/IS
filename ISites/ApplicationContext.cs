using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISites.Models;
using Microsoft.EntityFrameworkCore;

namespace ISites
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SITES;Trusted_Connection=True;");
        }
    }
}

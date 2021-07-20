using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISites.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;

namespace ISites
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Issuer> Issuer { get; set; }
        public DbSet<Pos> Pos { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<IssuerProduct> IssuerProduct { get; set; }
        public DbSet<PosIssuer> PosIssuer { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
          //  Database.SetCommandTimeout(1500000);
          //  Database.EnsureDeleted();
          //  Database.EnsureCreated();
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
              //optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            base.OnModelCreating(modelBuilder);
        }
    }

    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            // получаем конфигурацию из файла appsettings.json
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            // получаем строку подключения из файла appsettings.json
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}

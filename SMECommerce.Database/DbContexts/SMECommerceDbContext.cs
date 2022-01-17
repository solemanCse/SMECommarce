using Microsoft.EntityFrameworkCore;
using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Database.DbContexts
{
    public class SMECommerceDbContext : DbContext
    {
        public SMECommerceDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = "Server=(local);Database=SMECommerceDB; Integrated Security=true;";
            //optionsBuilder.UseSqlServer(connectionString);
        }

    }
}

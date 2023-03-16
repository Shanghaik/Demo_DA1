using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class ShopDbContext : DbContext
    {
        public ShopDbContext() { }
        public ShopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source=SHANGHAIK;Initial Catalog=Demo;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new GiohangchitietConfiguration());
            //modelBuilder.ApplyConfiguration(new SanphamConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly
                (Assembly.GetExecutingAssembly());

        }
    }
}

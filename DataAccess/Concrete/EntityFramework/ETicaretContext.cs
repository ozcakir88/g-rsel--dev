using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ETicaretContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Eticaret;Trusted_Connection=true");
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Category> categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Citys> Cities { get; set; }

        public DbSet<Adress> Adress { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
     

    }
}

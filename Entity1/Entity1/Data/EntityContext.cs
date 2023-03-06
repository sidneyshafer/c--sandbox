using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add the following namespaces :
using Entity1.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity1.Data
{
    public class EntityContext : DbContext
    {
        //Each DbSet<> maps to a table in the database
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EntityPractice;Integrated Security=True");
        }
    }
}

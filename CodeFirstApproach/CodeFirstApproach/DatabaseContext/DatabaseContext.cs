using CodeFirstApproach.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CodeFirstApproach.DatabaseContext
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SCH-EBHSQLTST-01.EvansDel.com;Initial Catalog=cfoTest;Persist Security Info=True; User Id=sa;Password=TA88id!;Integrated Security=True; Trusted_Connection=False; TrustServerCertificate=True; Encrypt=True;");
        }
    }
}

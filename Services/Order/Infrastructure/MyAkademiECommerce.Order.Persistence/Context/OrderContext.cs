using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MyAkademiECommerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Persistence.Context
{
   public class OrderContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;database=ECommerceDiscountDB;user=sa;password=123456aA*");
        }
        public DbSet<Ordering>Orderings { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}

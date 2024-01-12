using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyAkademiECommerce.Discount.Models;
using System.Data;

namespace MyAkademiECommerce.Discount.Context
{
    public class DapperContext:DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAADET\\SQLEXPRESS01;initial catalog=ECommerceDiscountDB;integrated Security=True;");
        }
        public DbSet<Coupon> Coupones { get; set; }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}

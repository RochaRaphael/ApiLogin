using ApiLogin.Data.Mapping;
using ApiLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLogin.Data
{
    public class ApiLoginDataContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=ApiLogin;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoginMap());
        }
    }
}

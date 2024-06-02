using Manabank.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Manabank
{
    public class AppDbContext : DbContext
    {
        public DbSet<AccountVM> Accounts { get; set; } = null!;
        public DbSet<UsersVM> Users { get; set; } = null!;
        public DbSet<CardVM> Cards { get; set; } = null!;
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=manabank;";

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 34)));
        }



    }
}

using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.Data
{
    public class BankDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<AccountDet> AccountDets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=Database_1P;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Userdb1");
            modelBuilder.Entity<AccountDet>().ToTable("AccountDets");
        }

        public DbSet<Transfer_via_accountno> TransferViaAccountnos { get; set; } = null!;
        public DbSet<Transfer_via_phoneno> TransferViaPhonenos { get; set; } = null!;
    }
}

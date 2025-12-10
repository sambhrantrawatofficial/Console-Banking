using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.Data
{
    public class BankDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=Database_2P;Trusted_Connection=True;");
        }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<AccountDet> AccountDets { get; set; } = null!;
        public DbSet<Transfer_via_accountno> TransferViaAccountnos { get; set; } = null!;
        public DbSet<Transfer_via_phoneno> TransferViaPhonenos { get; set; } = null!;
        public DbSet<Loan> Loans { get; set; } = null!;



    }
}

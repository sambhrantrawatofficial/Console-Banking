using Practice.Data;
using Practice.Models;
using System;
using System.Linq;

namespace Practice.Services
{
    internal class AccountService
    {
        private readonly BankDbContext _db;

        public AccountService()
        {
            _db = new BankDbContext();
        }

        // View account details by username with additional info from Users table
        public void ViewAccountDetails(string username)
        {
            var result = from account in _db.AccountDets
                         join user in _db.Users
                         on account.Name equals user.Name
                         where account.Name == username
                         select new
                         {
                             Name = account.Name,
                             AccountNumber = account.Account_No,
                             Balance = account.Balance,
                             Mobile = user.PhoneNumber,
                             Email = user.Email
                         };

            var accInfo = result.FirstOrDefault();

            foreach (var acc in result)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("User Name: " + accInfo.Name);
                Console.WriteLine("Account Number: " + accInfo.AccountNumber);
                Console.WriteLine("Balance: " + accInfo.Balance);
                Console.WriteLine("Mobile Number: " + accInfo.Mobile);
                Console.WriteLine("Email: " + accInfo.Email);
                Console.WriteLine("-----------------------------");
            }
        }
    }
}

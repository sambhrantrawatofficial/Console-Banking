using Practice.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Services
{
    internal class CibilService
    {
        public int CanGetLoan(string username)
        {
            using var db = new BankDbContext();

            var account = db.AccountDets.Where(x => x.Name == username).FirstOrDefault();
            var loanamount = db.Loans.Where(x => x.Name == username).FirstOrDefault();

            if (account != null)
            {
                if (account.Balance > 1500 && loanamount == null)
                {
                    return 750;
                }
                else if (account.Balance >= 1000)
                {
                    return 650;
                }
                else if (account.Balance >= 500)
                {
                    return 550;
                }
                else
                {
                    return 450;
                }
            }
            else
            {
                Console.WriteLine("User not found.");
                return 0;
            }
        }
    

        public int CibilScore(string username)
        {
            using var db = new BankDbContext();

            var account = db.AccountDets.Where(x => x.Name == username).FirstOrDefault();
            var loanamount = db.Loans.Where(x => x.Name == username).FirstOrDefault();

            if (account != null)
            {
                Console.WriteLine("----- CIBIL SCORE DETAILS -----");

                if (account.Balance > 1500 && loanamount == null)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Name: {account.Name}");
                    Console.WriteLine($"Cibil Score: 750");
                    Console.WriteLine($"Status: Good CIBIL Score");
                    Console.WriteLine("-------------------------------");
                    return 750;
                }
                else if (account.Balance >= 1000)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Name: {account.Name}");
                    Console.WriteLine($"Cibil Score: 650");
                    Console.WriteLine($"Status: Average CIBIL Score");
                    Console.WriteLine("-------------------------------");
                    return 650;
                }
                else if (account.Balance >= 500)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Name: {account.Name}");
                    Console.WriteLine($"Cibil Score: 550");
                    Console.WriteLine($"Status: Below Avg CIBIL Score");
                    Console.WriteLine("-------------------------------");
                    return 550;
                }
                else
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Name: {account.Name}");
                    Console.WriteLine($"Cibil Score: 750");
                    Console.WriteLine($"Status: Poor CIBIL Score");
                    Console.WriteLine("-------------------------------");
                    return 450;
                }
            }
            else
            {
                throw new Exception("User not found");
            }
        }
    }
}

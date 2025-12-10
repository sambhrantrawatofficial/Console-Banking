using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Practice.Data;
using Practice.Models;

namespace Practice.Services
{
    internal class LoanService
    {
        public bool GetLoan(string username, int CibilScore)
        {
            var db = new BankDbContext();
            var user = db.Users.FirstOrDefault(u => u.Name == username);

            if (user != null && CibilScore >= 650)
            {
                Console.WriteLine("Enter amount to borrow:");
                var amount = Convert.ToInt32(Console.ReadLine());

                var loan = new Loan
                {
                    LoanId = Guid.NewGuid(),
                    Name = user.Name,
                    Amount = amount,
                    InterestRate = 8,
                    TimePeriod = "3 years",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(3)
                };
                Console.WriteLine(username + "has successfully get a loan of amount " + amount + "Rs/-");
                db.Loans.Add(loan);
                db.SaveChanges();
                return true;

            }
            else if(user != null && CibilScore < 650)
            {
                Console.WriteLine("CIBIL score too low to approve loan.");
                return false;
            }
            else
            {
                Console.WriteLine("User not found.");
                return false;
            }
            }

        public bool ViewLoanDetails(string username)
        {
            var db = new BankDbContext();
            var user = db.Loans.FirstOrDefault(u => u.Name == username);

            var loandetails = db.Loans.Where(l => l.Name == user.Name)
                .FirstOrDefault();

            if (loandetails != null)
            {
                Console.WriteLine("------Loan Details:------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Loan ID: {loandetails.LoanId}");
                Console.WriteLine($"Name: {loandetails.Name}");
                Console.WriteLine($"Amount: {loandetails.Amount}");
                Console.WriteLine($"Interest Rate: {loandetails.InterestRate}%");
                Console.WriteLine($"Time Period: {loandetails.TimePeriod}");
                Console.WriteLine($"Start Date: {loandetails.StartDate.ToShortDateString()}");
                Console.WriteLine($"End Date: {loandetails.EndDate.ToShortDateString()}");
                Console.WriteLine("-----------------------------------------");
                return true;
            }
            else 
            {
                Console.WriteLine("No loan details found for the user.");
                return false;
            }
        }
    }
}

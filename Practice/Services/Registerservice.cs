using Practice.Data;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Services
{
    internal class Registerservice
    {
        private readonly BankDbContext _context;
        public Registerservice()
        {
            _context = new BankDbContext();
        }

        public bool Register(string username, string password, string email, string phoneNumber)
        {
        
            var existingUser = _context.Users
                .FirstOrDefault(u => u.Name == username || u.Email == email);
            if (existingUser != null)
            {
                Console.WriteLine("Username or Email already exists. Please try again.");
                Console.ReadLine();
                return false;
            }
            var newUser = new User
            {
                Name = username,
                Password = password,
                Email = email,
                PhoneNumber = phoneNumber
            };
            var Accountdet = new AccountDet
            {
                Name = username,
                Account_No = new Random().Next(10000000, 99999999),
                Balance = 1500
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();
            Console.WriteLine("Registration Successful! You can now login.");
            Console.ReadLine();
            return true;
        }


    }
}

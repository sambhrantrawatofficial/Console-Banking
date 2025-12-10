using Practice.Data;
using Practice.Models;
using Microsoft.EntityFrameworkCore;

namespace Practice.Services
{
    public class UserService
    {
       private readonly BankDbContext _context;

        public UserService()
        {
            _context = new BankDbContext();
        }

        public bool Login(string username, string password)
        {
            // Verify user with existing data
            var user = _context.Users
                .FirstOrDefault(u => u.Name == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine("Login Successful! Welcome " + user.Name);
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Username or Password.");
                Console.ReadLine();
                return false;
            }

            
        }
    }
}

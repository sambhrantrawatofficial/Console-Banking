using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }// = null!;
        public string Password { get; set; }// = null!;
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    internal class Register
    {
        public int Id { get; set; }
        public string Name { get; set; }// = null!;
        public string Password { get; set; }// = null!;
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}

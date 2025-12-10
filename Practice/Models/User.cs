using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practice.Models
{
    public class User
    {
        public int Id { get; set; }
        [Key]
        public string Name { get; set; }// = null!;
        public string Password { get; set; }// = null!;
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practice.Models
{
    public class Transfer_via_phoneno
    {
        
        public Guid Id { get; set; }  
        [Key]
        public string Sender_Name { get; set; }
        public string Sender_PhoneNo { get; set; } 
        public string Receiver_Name { get; set; } 
        public string Receiver_PhoneNo { get; set; } 
        public string Amount { get; set; } 
        public DateTime Transfer_Date { get; set; }
    }
}

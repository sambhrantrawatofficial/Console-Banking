using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practice.Models
{
    public class Transfer_via_phoneno
    {
        [Key]
        public Guid Id { get; set; }
        public string Sender_Name { get; set; } = null!;
        public string Sender_PhoneNo { get; set; } = null!;
        public string Receiver_Name { get; set; } = null!;
        public string Receiver_PhoneNo { get; set; } = null!;
        public string Amount { get; set; } = null!;
        public DateTime Transfer_Date { get; set; }
    }
}

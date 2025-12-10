using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practice.Models
{
        public class Transfer_via_accountno
        {    
            public int Id { get; set; }
        [Key]
            public string Sender_Name { get; set; } 
            public string Sender_AccountNo { get; set; } 
            public string Receiver_Name { get; set; } 
            public string Receiver_AccountNo { get; set; }
            public string Amount { get; set; }
            public DateTime Transfer_Date { get; set; }
    }

    }

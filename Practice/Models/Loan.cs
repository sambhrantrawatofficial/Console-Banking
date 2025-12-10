using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practice.Models
{
    public class Loan
    {
        public Guid LoanId { get; set; }
        [Key]
        public string Name { get; set; }
        public int Amount { get; set; }
        public int InterestRate { get; set; }
        public string TimePeriod { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

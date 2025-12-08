using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models;

public class AccountDet
{
    [Key]
    public string Name { get; set; }  
    public int Account_No { get; set; }
    public int Balance { get; set; }
}

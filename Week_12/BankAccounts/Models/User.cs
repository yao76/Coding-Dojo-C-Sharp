using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId{get;set;}

        [Required]
        [MinLength(2, ErrorMessage="First Name must be at least 2 characters long.")]
        [Display(Name="First Name")]
        public string FirstName{get;set;}

        [Required]
        [MinLength(2, ErrorMessage="First Name must be at least 2 characters long.")]
        [Display(Name="Last Name")]        
        public string LastName{get;set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email Address")]
        public string Email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage="Password must be at least 8 characters long.")]
        public string Password{get;set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm{get;set;}

        public List<Transaction> userTransaction {get;set;}

        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}
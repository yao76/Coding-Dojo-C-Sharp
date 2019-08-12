using System.ComponentModel.DataAnnotations;
namespace BankAccounts.Models
{
    public class LoginUser
    {
        [Required]
        public string Email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}
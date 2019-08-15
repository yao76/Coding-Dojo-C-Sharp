using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models
{
    public class LoginUser
    {
        [Required]
        public string Email{get;set;}

        [Required]
        [MinLength(8,ErrorMessage="Password must be at least 8 characters long!")]
        public string Password{get;set;}
    }
}
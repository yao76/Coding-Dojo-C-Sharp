using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId{get;set;}

        [Required]
        [Display(Name="Wedder One")]
        public string WedderOne{get;set;}

        [Required]
        [Display(Name="Wedder Two")]
        public string WedderTwo{get;set;}

        [Required]
        [Display(Name="Wedding Date")]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage="Date should be in the future")]
        public DateTime WeddingDate{get;set;}

        [Required]
        [Display(Name="Wedding Address")]
        public string Address{get;set;}

        public int UserId{get;set;}
        public User User{get;set;}

        public List<WeddingGuest> Guests {get;set;}

        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }

    
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && (DateTime)value > DateTime.Now;
        }
    }

}
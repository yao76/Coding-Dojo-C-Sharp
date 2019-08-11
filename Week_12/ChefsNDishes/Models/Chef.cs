using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [MinAge(18)]
        [Display(Name="Birthday")]
        public DateTime BirthDate { get; set; }

        // Navigation property
        public List<Dish> CookedDishes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

    public class MinAge : ValidationAttribute
    {
        private int _Limit;
        public MinAge(int Limit) { // The constructor which we use in modal.
            this._Limit = Limit;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) 
        {
            DateTime bday = DateTime.Parse(value.ToString());
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age))
            {
                age--; 
            }
            if (age < _Limit)
            {
                var result = new ValidationResult("Sorry you are not old enough");
                return result; 
            }
            return null;
        }
    }
}
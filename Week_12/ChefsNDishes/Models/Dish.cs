using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId{get;set;}


        [Required]
        public string Name{get;set;}

        [Required]
        [Range(1,int.MaxValue)]
        public int Calories{get;set;}

        [Required]
        public string Description{get;set;}
        
        [Required]
        [Range(1,5)]
        public int Tastiness{get;set;}

        // Foreign Key
        public int ChefId{get;set;}

        // Navigation property
        public Chef Creator{get;set;}

        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;



    }
}
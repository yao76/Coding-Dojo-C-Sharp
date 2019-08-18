using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace ECommerce.Models
{
    public class Product
    {   [Key]
        public int ProductId{get;set;}

        [Required(ErrorMessage="Product name is required")]
        [Display(Name="Name:")]
        public string Name{get;set;}

        [Required(ErrorMessage="Product url is required")]
        [Display(Name="Image url:")]
        public string Url{get;set;}
        
        [Required(ErrorMessage="Product description is required")]
        [Display(Name="Description:")]
        public string Description{get;set;}

        [Required(ErrorMessage="Initial product quantity is required")]
        [Display(Name="Initial Quantity:")]
        public int Quantity{get;set;}

        public List<Order> Orders{get;set;}

        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}
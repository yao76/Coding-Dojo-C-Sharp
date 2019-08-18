using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId{get;set;}

        [Required]
        [Display(Name="First Name:")]
        public string FirstName{get;set;}

        [Required]
        public string LastName{get;set;}

        [NotMapped]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public List<Order> Orders{get;set;}

        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;

        
    }
}
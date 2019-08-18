using System;
using System.ComponentModel.DataAnnotations;
namespace ECommerce.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage="Please enter a quantity.")]
        [Range(1,int.MaxValue, ErrorMessage="Please enter a valid quantity.")]
        public int Quantity { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
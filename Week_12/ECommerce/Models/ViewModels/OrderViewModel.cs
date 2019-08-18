using System.Collections.Generic;
namespace ECommerce.Models
{
    public class OrderViewModel
    {
        public List<Customer> AllCustomers{get;set;}

        public List<Product> AllProducts{get;set;}

        public List<Order> AllOrders{get;set;}

        public Order NewOrder{get;set;}
    }
}
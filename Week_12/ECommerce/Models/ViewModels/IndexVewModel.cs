using System.Collections.Generic;
namespace ECommerce.Models
{
    public class IndexVewModel
    {
        public List<Customer> RecentCustomers{get;set;}

        public List<Product> RecentProducts{get;set;}

        public List<Order> RecentOrders{get;set;}

    }
}
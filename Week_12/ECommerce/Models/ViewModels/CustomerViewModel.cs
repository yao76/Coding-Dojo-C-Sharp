using System.Collections.Generic;
namespace ECommerce.Models
{
    public class CustomerViewModel
    {
        public Customer NewCustomer{get;set;}
        public List<Customer> AllCustomers{get;set;}
    }
}
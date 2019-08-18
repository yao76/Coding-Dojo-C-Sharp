using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Order> recentorders = dbContext.orders
                .Include(o=>o.Customer)
                .Include(o=>o.Product)
                .OrderByDescending(o=>o.CreatedAt)
                .Take(3)
                .ToList();
            List<Customer> recentcustomers = dbContext.customers
                .OrderByDescending(c=>c.CreatedAt)
                .Take(3)
                .ToList();
            List<Product> recentproducts = dbContext.products
                .OrderByDescending(p=>p.CreatedAt)
                .Take(5)
                .ToList();
            
            IndexVewModel viewModel = new IndexVewModel();
            viewModel.RecentOrders = recentorders;
            viewModel.RecentCustomers = recentcustomers;
            viewModel.RecentProducts = recentproducts;

            return View(viewModel);
        }

        [HttpGet("orders")]
        public IActionResult Orders()
        {
            List<Customer> allcustomers = dbContext.customers.ToList();
            List<Product> allproducts = dbContext.products.ToList();
            List<Order> allorders = dbContext.orders
                .Include(o=>o.Customer)
                .Include(o=>o.Product)
                .OrderByDescending(o=>o.CreatedAt)
                .ToList();
            OrderViewModel orderviewmodel = new OrderViewModel();
            orderviewmodel.AllCustomers = allcustomers;
            orderviewmodel.AllProducts = allproducts;
            orderviewmodel.AllOrders = allorders;
            
            return View(orderviewmodel);
        }
                [HttpPost("addorder")]
        public IActionResult AddOrder(OrderViewModel FormData)
        {
            List<Customer> allcustomers = dbContext.customers.ToList();
            List<Product> allproducts = dbContext.products.ToList();
            List<Order> allorders = dbContext.orders
                .Include(o=>o.Customer)
                .Include(o=>o.Product)
                .OrderByDescending(o=>o.CreatedAt)
                .ToList();
            OrderViewModel orderviewmodel = new OrderViewModel();
            orderviewmodel.AllCustomers = allcustomers;
            orderviewmodel.AllProducts = allproducts;
            orderviewmodel.AllOrders = allorders;

            if(ModelState.IsValid)
            {
                Product ProductToOrder = dbContext.products
                    .SingleOrDefault(p=>p.ProductId==FormData.NewOrder.ProductId);

                if(ProductToOrder.Quantity < FormData.NewOrder.Quantity)
                {
                    ModelState.AddModelError("Quantity", $"Order Failed. Less than {FormData.NewOrder.Quantity} remaining!");
                    return View("Orders", orderviewmodel);
                }

                ProductToOrder.Quantity -= FormData.NewOrder.Quantity;

                // neworder.ProductId = FormData.NewOrder.ProductId;
                // neworder.CustomerId = FormData.NewOrder.CustomerId;
                // neworder.Quantity = FormData.NewOrder.Quantity;
                dbContext.orders.Add(FormData.NewOrder);
                dbContext.SaveChanges();
                return RedirectToAction("Orders");
            }

            return View("Orders", orderviewmodel);
        }

        [HttpGet("customers")]
        public IActionResult Customers()
        {
            List<Customer> allcustomers = dbContext.customers
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            CustomerViewModel viewModel = new CustomerViewModel();
            viewModel.AllCustomers = allcustomers;
            
            return View(viewModel);
        }

        [HttpPost("addcustomer")]
        public IActionResult AddCustomer(CustomerViewModel FormData)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.customers.Any(u=>u.FullName == FormData.NewCustomer.FullName))
                {
                    List<Customer> custs = dbContext.customers
                        .OrderByDescending(c=>c.CreatedAt)
                        .ToList();
                    CustomerViewModel ViewModel = new CustomerViewModel();
                    ViewModel.AllCustomers = custs;
                    ModelState.AddModelError("FirstName", "Customer name already exists");
                    return View("Customers",ViewModel);
                }
                // System.Console.WriteLine(new string('-',80));
                // System.Console.WriteLine(dbContext.customers.Any(u=>u.FullName == FormData.NewCustomer.FullName));
                // System.Console.WriteLine(FormData.NewCustomer.FirstName);
                // System.Console.WriteLine(FormData.NewCustomer.LastName);
                // System.Console.WriteLine(FormData.NewCustomer.FullName);
                dbContext.customers.Add(FormData.NewCustomer);
                dbContext.SaveChanges();

                return RedirectToAction("Customers");
            }

            List<Customer> allcustomers = dbContext.customers
                .OrderByDescending(c=>c.CreatedAt)
                .ToList();
            CustomerViewModel viewModel = new CustomerViewModel();
            viewModel.AllCustomers = allcustomers;

            return View("Customers", viewModel);
        }

        [HttpGet("remove/{id}")]
        public IActionResult RemoveCustomer(int id) {
            Customer CustomerToRemove = dbContext.customers.SingleOrDefault(c=>c.CustomerId == id);

            if(CustomerToRemove != null)
            {
                dbContext.Remove(CustomerToRemove);
                dbContext.SaveChanges();
            }

            return RedirectToAction("Customers");
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            List<Product> allproducts = dbContext.products
                .OrderByDescending(p=>p.CreatedAt)
                // .Take(15)
                .ToList();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.AllProducts = allproducts;

            return View(viewModel);
        }

        [HttpPost("addproduct")]
        public IActionResult AddProduct(ProductViewModel FormData)
        {
            if(ModelState.IsValid)
            {
                dbContext.products.Add(FormData.NewProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Products");
            }

            List<Product> allproducts = dbContext.products
                .OrderByDescending(p=>p.CreatedAt)
                // .Take(15)
                .ToList();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.AllProducts = allproducts;

            return View("Products", viewModel);
        }


    }
}

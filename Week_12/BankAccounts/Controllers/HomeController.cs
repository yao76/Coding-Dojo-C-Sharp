using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



namespace BankAccounts.Controllers
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
            int? user_id = HttpContext.Session.GetInt32("UserId");
            if(user_id != null)
            {
                return Redirect($"account/{user_id}");
            }
            return View();
        }

        [HttpPost("processregister")]
        public IActionResult ProccessRegister(User formData)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u=>u.Email == formData.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                formData.Password = Hasher.HashPassword(formData, formData.Password);
                
                dbContext.Add(formData);
                dbContext.SaveChanges();
                System.Console.WriteLine(new string('@',80));
                System.Console.WriteLine(formData.UserId);

                HttpContext.Session.SetInt32("UserId", formData.UserId);
                return Redirect($"account/{formData.UserId}");
            }
            return View("Index");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            int? user_id = HttpContext.Session.GetInt32("UserId");
            if(user_id != null)
            {
                return Redirect($"account/{user_id}");
            }
            return View();
        }

        [HttpPost("processlogin")]
        public IActionResult ProcessLogin(LoginUser formData)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u=>u.Email == formData.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email!");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(formData,userInDb.Password,formData.Password);
                if(result==0)
                {
                    ModelState.AddModelError("Password","Invalid Password");
                    return View("Login");
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return Redirect($"account/{userInDb.UserId}");
            }
            ModelState.AddModelError("Email", "Invalid email or password");
            return View("Login");
        }

        [HttpGet("account/{id}")]
        public IActionResult Account(int id)
        {
            
            if(HttpContext.Session.GetInt32("UserId") != id)
            {
                return RedirectToAction("Index");
            }

            // List<Transaction> alltransactions = dbContext.Transactions.Include(user => user.AccountOwner).ToList();
            int? logged_in_user = HttpContext.Session.GetInt32("UserId");
            var curr_user = dbContext.Users.Include(user => user.userTransaction).FirstOrDefault(user => user.UserId == logged_in_user);
            System.Console.WriteLine(new string('*',80));
            var transactions = curr_user.userTransaction;
            transactions.Reverse();
            decimal sum = 0;

            foreach(var i in transactions)
            {
                sum += i.Amount;
            }
            
            ViewBag.Balance = sum;

            
            ViewBag.AllTransactions = transactions;
            ViewBag.Name = curr_user.FirstName + " " + curr_user.LastName;
            
            return View();
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost("processtransaction")]
        public IActionResult ProcessTransaction(Transaction transaction)
        {
            int? user_id = HttpContext.Session.GetInt32("UserId");
            if(user_id == null)
            {
                return RedirectToAction("Index");
            }

            transaction.UserId = (int)user_id;
            
            User curr_user = dbContext.Users.Include(user=>user.userTransaction).FirstOrDefault(user=>user.UserId == user_id);
            var curr_user_transactions = curr_user.userTransaction;

            decimal total = 0;

            foreach(var s in curr_user_transactions)
            {
                total += s.Amount;
            }

            if(-transaction.Amount > total)
            {
                ModelState.AddModelError("Amount", "Cannot withdraw more than your current balance.");
                return Redirect($"account/{user_id}");
            }

            dbContext.Add(transaction);
            dbContext.SaveChanges();

            return Redirect($"account/{user_id}");

        }
    }
}

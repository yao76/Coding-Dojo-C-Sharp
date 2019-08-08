using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("addQuote")]
        public IActionResult AddQuote(quotes newQuote)
        {
            if(ModelState.IsValid)
            {
                string query = $"INSERT INTO quotes(Name, Quote) VALUES('{newQuote.Name}', '{newQuote.Quote}')";
                DbConnector.Execute(query);
                return RedirectToAction("Quotes");
            } else {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string,object>> AllQUotes = DbConnection.DbConnector.Query("SELECT * FROM quotes");
            ViewBag.Quotes = AllQUotes;
            return View("Quotes");
        }

    }
}

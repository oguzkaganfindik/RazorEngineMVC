using Microsoft.AspNetCore.Mvc;
using RazorEngineMVC.Models;
using System.Diagnostics;

namespace RazorEngineMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Customer customer1 = new Customer
            {
                CustomerNo = 1,
                CustomerName = "Mahmut",
                CustomerAge = 25
            };

            Customer customer2 = new Customer
            {
                CustomerNo = 2,
                CustomerName = "Selim",
                CustomerAge = 27
            };

            Customer customer3 = new Customer
            {
                CustomerNo = 3,
                CustomerName = "Ayşe",
                CustomerAge = 26
            };

            Customer customer4 = new Customer
            {
                CustomerNo = 4,
                CustomerName = "Semih",
                CustomerAge = 24
            };

            List<Customer> customers = new List<Customer> { customer1, customer2, customer3, customer4 };
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);
            //customers.Add(customer4);

            return View(customers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
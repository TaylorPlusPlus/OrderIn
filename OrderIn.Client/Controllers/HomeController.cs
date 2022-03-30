using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderIn.Client.Models;
using OrderIn.Domain.Models;
using OrderIn.Storage;

namespace OrderIn.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrderInRepository _repo;

        public HomeController(OrderInRepository injectedRepo)
        {
            _repo = injectedRepo;
        }

        public IActionResult Index()
        {
            UserModel model = new UserModel();
            return View("Index", model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult WelcomeScreen(UserModel model)
        {
            if(model.Name.Equals("COKE"))
            {
                Order order = new Order();
                order.AddDrink("COKE");
                order.AddAppetizers("CALAMARI");
                _repo.SaveOrder(order);
            }
            return View("WelcomeScreen", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

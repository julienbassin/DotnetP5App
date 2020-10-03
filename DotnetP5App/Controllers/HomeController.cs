using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetP5App.Models;
using DotnetP5App.Services;
using DotnetP5App.ViewModels;

namespace DotnetP5App.Controllers
{
    public class HomeController : Controller
    {
        ICarRepository db;
        public HomeController(ICarRepository db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var allCars = db.GetAll();
            var vm = new List<DetailCarViewModel>();
            foreach (var cars in allCars)
            {
                vm.Add(new DetailCarViewModel
                {
                    Cars = cars,
                    //AverageRating = cars.Reviews.Select(tr => tr.Rating).DefaultIfEmpty(0).Average()
                });
            }
            return View(vm);
            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

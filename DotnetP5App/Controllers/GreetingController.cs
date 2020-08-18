using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using DotnetP5App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace DotnetP5App.Controllers
{
    public class GreetingController : Controller
    {
        private readonly IConfiguration _config;

        public GreetingController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.Name = name ?? "No name";
            model.Message = _config.GetValue<string>("ShortMessage");
            return View(model);
        }
    }
}

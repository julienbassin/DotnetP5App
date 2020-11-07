using DotnetP5App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotnetP5App.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            var vm = new SendEmailViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult SaveMessage(SendEmailViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return View("Index", viewModel);
            }
            return View();
        }
    }
}

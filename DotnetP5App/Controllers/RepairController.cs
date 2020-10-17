using System;
using DotnetP5App.Models;
using DotnetP5App.ModelsViewModels;
using DotnetP5App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DotnetP5App.Controllers
{
    public class RepairController : Controller
    {
        IRepairCarRepository _repairCarRepository;
        public RepairController(IRepairCarRepository repairCarRepository)
        {
            _repairCarRepository = repairCarRepository;
    }
        public IActionResult Index()
        {
            var model = _repairCarRepository.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {            
            var vm = new RepairCarViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(RepairCarViewModel repairCarViewModel)
        {
            if (ModelState.IsValid)
            {
                var repairCar = new RepairCar()
                {
                    RepairCost = repairCarViewModel.Amount,
                    Description = repairCarViewModel.Description,
                };
                _repairCarRepository.AddRepairCar(repairCar);
                return RedirectToAction("Index");
            }
            var vm = new RepairCarViewModel();
            return View(vm);
        }

        public IActionResult Details(int Id)
        {
            var model = _repairCarRepository.FindRepairCarById(Id);           
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteConfirmation(int Id)
        {
            var model = _repairCarRepository.FindRepairCarById(Id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View("Delete", model);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            _repairCarRepository.DeleteRepairCarById(Id);
            return RedirectToAction("Index");
        }
    }
}

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
        ICarRepository _carRepository;
        public RepairController(IRepairCarRepository repairCarRepository, ICarRepository carRepository)
        {
            _repairCarRepository = repairCarRepository;
            _carRepository = carRepository;
    }
        public IActionResult Index()
        {
            var model = _repairCarRepository.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var cars = _carRepository.GetAll();
            var vm = new RepairCarViewModel();
            foreach (var car in cars)
            {
                var item = new SelectListItem() { Value = car.Id.ToString(), Text = car.Make };
                
                vm.Cars.Add(item);

            }

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(RepairCarViewModel repairCarViewModel)
        {

            if (ModelState.IsValid)
            {
                var repairCar = new RepairCar()
                {
                    CarId = repairCarViewModel.CarId,
                    RepairCost = repairCarViewModel.Amount,
                    Description = "test",
                    RepairedDate = DateTime.Now

                };
                _repairCarRepository.AddRepairCar(repairCar);
                return RedirectToAction("Index");
            }
            var cars = _carRepository.GetAll();
            var vm = new RepairCarViewModel();
            foreach (var car in cars)
            {
                var item = new SelectListItem() { Value = car.Id.ToString(), Text = car.Make };

                vm.Cars.Add(item);
            }
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
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var model = _repairCarRepository.FindRepairCarById(Id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}

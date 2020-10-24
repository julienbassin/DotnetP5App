using System;
using System.Collections.Generic;
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
            var repairs = _repairCarRepository.GetAll();
            //var vm = new List<RepairCarViewModel>();
            //foreach (var repair in repairs)
            //{
            //    vm.Add(new RepairCarViewModel
            //    {
            //        Amount = repair.RepairCost,
            //        Description = repair.Description
            //    });
            //}
            return View(repairs);
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

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var repairs = _repairCarRepository.FindRepairCarById(Id);
            var vm = new RepairCarViewModel();
            vm.Amount = repairs.RepairCost;
            vm.Description = repairs.Description;
            vm.Id = repairs.Id;
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(RepairCarViewModel repairCarViewModel)
        {

            if (ModelState.IsValid)
            {
               
                _repairCarRepository.UpdateRepairCar(repairCarViewModel);
            }
            return RedirectToAction("Index");
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

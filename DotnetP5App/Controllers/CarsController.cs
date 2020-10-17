using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotnetP5App.Models;
using DotnetP5App.Services;
using DotnetP5App.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DotnetP5App.Controllers
{
    public class CarsController : Controller
    {
        public readonly ICarRepository _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public readonly IRepairCarRepository _repairCarRepository;

        public CarsController(ICarRepository db, 
                              IWebHostEnvironment webHostEnvironment,
                              IRepairCarRepository repairCarRepository)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
            _repairCarRepository = repairCarRepository;
        }
        public IActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        public IActionResult Details(int Id)
        {
            var model = _db.FindCarById(Id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var repairCars = _repairCarRepository.GetAll();
            var vmRepairCars = new CarViewModel();
            foreach (var repairCar in repairCars)
            {
                vmRepairCars.ListRepairCar.Add(
                    new SelectListItem
                    {
                        Text = repairCar.Description,
                        Value = repairCar.RepairCost.ToString()
                    });
            }

            return View(vmRepairCars);
        }

        [HttpPost]
        public IActionResult Create(CarViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(viewModel);

                Car currentCar = new Car
                {
                    Model = viewModel.Model,
                    Description = viewModel.Description,
                    Make = viewModel.Make,
                    Trim = viewModel.Trim,
                    Year = viewModel.Year,
                    PurchaseDate = viewModel.PurchaseDate,
                    PurchasePrice = viewModel.PurchasePrice,
                    Vin = viewModel.Vin,
                    LotDate = viewModel.LotDate,
                    ProfilePicture = uniqueFileName,
                    SaleDate = viewModel.SaleDate,
                    SellingPrice = viewModel.SellingPrice,
                    Status = viewModel.Status
                 };
                _db.AddCar(currentCar);
                
            }
            return RedirectToAction("Index");
        }

        private string UploadedFile(CarViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        // try to add httpget and httppost for edit 
        public IActionResult Edit(CarViewModel carViewModel)
        {
            string uniqueFileName = UploadedFile(carViewModel);

            if (ModelState.IsValid)
            {
                Car currentCar = new Car
                {
                    Model = carViewModel.Model,
                    Description = carViewModel.Description,
                    Make = carViewModel.Make,
                    Trim = carViewModel.Trim,
                    Year = carViewModel.Year,
                    PurchaseDate = carViewModel.PurchaseDate,
                    PurchasePrice = carViewModel.PurchasePrice,
                    Vin = carViewModel.Vin,
                    LotDate = carViewModel.LotDate,
                    ProfilePicture = uniqueFileName
                };
                _db.Update(currentCar);
            }
            return View();
        }     

        [HttpGet]
        public IActionResult DeleteConfirmation(int id)
        {
            var model = _db.FindCarById(id);
            if (model == null)
            {
                return View("Not Found");
            }
            return View("Delete", model);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            _db.DeleteCarById(Id);
            return RedirectToAction("Index");
        }
    }
}

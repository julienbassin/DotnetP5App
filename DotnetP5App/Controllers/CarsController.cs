using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DotnetP5App.Models;
using DotnetP5App.Services;
using DotnetP5App.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DotnetP5App.Controllers
{

    public class CarsController : Controller
    {
        public readonly ICarRepository _carRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public readonly IRepairCarRepository _repairCarRepository;

        public CarsController(ICarRepository db, 
                              IWebHostEnvironment webHostEnvironment,
                              IRepairCarRepository repairCarRepository)
        {
            _carRepository = db;
            _webHostEnvironment = webHostEnvironment;
            _repairCarRepository = repairCarRepository;
        }
        [Authorize]
        public IActionResult Index()
        {
            var model = _carRepository.GetAll();
            return View(model);
        }

        public IActionResult Details(int Id)
        {
            var model = _carRepository.GetCarById(Id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize]
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
        [Authorize]
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
                    RepairCost = viewModel.RepairCost,
                    Status = viewModel.Status
                 };
                _carRepository.AddCar(currentCar);
                
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

        
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var currentCar = _carRepository.GetCarById(Id);
            var repairCars = _repairCarRepository.GetAll();
            var viewModel = new CarViewModel();
            foreach (var repairCar in repairCars)
            {
                viewModel.ListRepairCar.Add(
                    new SelectListItem
                    {
                        Text = repairCar.Description,
                        Value = repairCar.RepairCost.ToString()
                    });
            }
            viewModel.Id = currentCar.Id;
            viewModel.Make = currentCar.Make;
            viewModel.Model = currentCar.Model;
            viewModel.Description = currentCar.Description;
            viewModel.Trim = currentCar.Trim;
            viewModel.Year = currentCar.Year;
            viewModel.PurchaseDate = currentCar.PurchaseDate;
            viewModel.PurchasePrice = currentCar.PurchasePrice;
            viewModel.Vin = currentCar.Vin;
            viewModel.LotDate = currentCar.LotDate;
            viewModel.SaleDate = currentCar.SaleDate;
            viewModel.SellingPrice = currentCar.SellingPrice;
            viewModel.RepairCost = currentCar.RepairCost;
            viewModel.Status = currentCar.Status;
            return View(viewModel);
        }
        
        [HttpPost]
        public IActionResult Edit(CarViewModel carViewModel)
        {
            string uniqueFileName = null;
            if (carViewModel.ProfileImage != null)
            {
                uniqueFileName = UploadedFile(carViewModel);
            }

            if (ModelState.IsValid)
            {
                Car updatedCar = new Car();
                updatedCar.Id = carViewModel.Id;
                updatedCar.Model = carViewModel.Model;
                updatedCar.Description = carViewModel.Description;
                updatedCar.Make = carViewModel.Make;
                updatedCar.Trim = carViewModel.Trim;
                updatedCar.Year = carViewModel.Year;
                updatedCar.PurchaseDate = carViewModel.PurchaseDate;
                updatedCar.PurchasePrice = carViewModel.PurchasePrice;
                updatedCar.Vin = carViewModel.Vin;
                updatedCar.LotDate = carViewModel.LotDate;
                updatedCar.SaleDate = carViewModel.SaleDate;
                updatedCar.SellingPrice = carViewModel.SellingPrice;
                updatedCar.RepairCost = carViewModel.RepairCost;
                updatedCar.Status = carViewModel.Status;
                updatedCar.ProfilePicture = uniqueFileName;
                _carRepository.Update(updatedCar);
                return RedirectToAction("Index");
            }
            else
            {
                var modelErrors = new List<string>();
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        modelErrors.Add(modelError.ErrorMessage);
                    }
                }
                return RedirectToAction("Index", modelErrors);
            }
        }


        [HttpGet]
        public IActionResult DeleteConfirmation(int id)
        {
            var model = _carRepository.GetCarById(id);
            if (model == null)
            {
                return View("Not Found");
            }
            return View("Delete", model);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            _carRepository.DeleteCarById(Id);
            return RedirectToAction("Index");
        }
    }
}

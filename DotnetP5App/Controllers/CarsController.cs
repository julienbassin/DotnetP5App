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

namespace DotnetP5App.Controllers
{
    public class CarsController : Controller
    {
        public readonly ICarRepository _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CarsController(ICarRepository db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
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
            return View();
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
                    ProfilePicture = uniqueFileName
                };
                _db.AddCar(currentCar);
                
            }
            return View();
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
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                _db.Update(car);
                return RedirectToAction("Details", new { id = car.Id });
            }
            return View(car);
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DotnetP5App.Models;
using DotnetP5App.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetP5App.Controllers
{
    public class CarsController : Controller
    {
        public readonly ICarData _db;

        public CarsController(ICarData db)
        {
            _db = db;
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

        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _db.AddCar(car);
                return RedirectToAction("Details", new { id = car.Id});
            }
            return View();
        }
        public IActionResult Edit(Car car)
        {
            //var model = _db.FindCarById(Id);
            if (ModelState.IsValid)
            {
                _db.Update(car);
                return View("Details", new { id = car.Id });
            }
            return View(car);
        }

        public IActionResult Delete(int Id)
        {
            var model = _db.FindCarById(Id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}

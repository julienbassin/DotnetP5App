using DotnetP5App.Models;
using DotnetP5App.Services;
using DotnetP5App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;

namespace DotnetP5App.Controllers
{
    public class InventoryController : Controller
    {
        ICarRepository _carRepository;
        public InventoryController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IActionResult Index()
        {
            var vm = new List<DetailCarViewModel>();
            var cars = _carRepository.GetAll();
            foreach (var car in cars)
            {
                vm.Add(new DetailCarViewModel
                {
                    Cars = car,
                });
            }
            return View(vm);
        }

        
    }
}

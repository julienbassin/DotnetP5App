using DotnetP5App.Models;
using DotnetP5App.Services;
using DotnetP5App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DotnetP5App.Controllers
{
    public class InventoryController : Controller
    {
        IInventoryRepository _InventoryRepository;
        ICarRepository _carRepository;
        IRepairCarRepository _repairCarRepository;
        public InventoryController(IInventoryRepository inventoryRepository, 
                                 ICarRepository carRepository,
                                 IRepairCarRepository repairCarRepository)
        {
            _InventoryRepository = inventoryRepository;
            _carRepository = carRepository;
            _repairCarRepository = repairCarRepository;
        }
        public IActionResult Index()
        {
            //var vm = new InvoiceViewModel();
            var model = _InventoryRepository.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var cars = _carRepository.GetAll();
            var repaircars = _repairCarRepository.GetAll();

            var vm = new InventoryViewModel();
            foreach (var car in cars)
            {
                var item =  new SelectListItem() { Text = car.Make, Value = car.Id.ToString() };
                vm.Cars.Add(item);
            }

            foreach (var rc in repaircars)
            {
                var item = new SelectListItem() { Text = rc.RepairCost.ToString(), Value = rc.Id.ToString() };
                vm.RepairCar.Add(item);

            }
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(InventoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var currentInvoice = new Inventory()
                {
                    //find a way to have an ID for Invoice
                    CarId = viewModel.CarId,
                    Profit = 500,
                    TotalCost = viewModel.TotalCost,
                    CustomerName = viewModel.CustomerName,
                    SaleDate = viewModel.dateTime
                };
                _InventoryRepository.AddInvoice(currentInvoice);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int Id)
        {
            var model = _InventoryRepository.FindInvoiceById(Id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        public IActionResult SaveInvoice()
        {
            return RedirectToAction("Index");
        }
    }
}

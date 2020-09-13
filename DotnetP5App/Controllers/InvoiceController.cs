using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetP5App.Models;
using DotnetP5App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;

namespace DotnetP5App.Controllers
{
    public class InvoiceController : Controller
    {
        IInvoiceRepository _invoiceRepository;
        public InvoiceController(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public IActionResult Index()
        {
            //var vm = new InvoiceViewModel();
            var model = _invoiceRepository.GetAll();
            return View(model);
        }

        public IActionResult Create(Invoice invoice)
        {
            if (ModelState.Any())
            {
                _invoiceRepository.AddInvoice(invoice);
                return RedirectToAction("Details", new { id = invoice.Id });
            }
            return View();
        }

        public IActionResult Detail(int Id)
        {
            var model = _invoiceRepository.FindInvoiceById(Id);
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

using DotnetP5App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class InvoiceRepository : IInvoiceRepository
    {
        CarDBContext _db;
        public InvoiceRepository(CarDBContext db)
        {
            _db = db;
        }

        public void AddInvoice(Invoice Invoice)
        {
            _db.Add(Invoice);
            _db.SaveChanges();
        }

        public IEnumerable<Invoice> GetAll()
        {
            return from invoice in _db.Invoices
                   orderby invoice.Id
                   select invoice;
        }

        public void Update(Invoice Invoice)
        {
            var entry = _db.Entry(Invoice);
            entry.State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(List<Invoice> Invoices)
        {
            _db.Remove(Invoices);
            _db.SaveChanges();
        }
        public void DeleteById(int Id)
        {
            var InvoiceFound = FindInvoiceById(Id);
            if (InvoiceFound != null)
            {
                _db.Invoices.Remove(InvoiceFound);
                _db.SaveChanges();
            }

        }

        public Invoice FindInvoiceById(int Id)
        {
            var result = _db.Invoices.Include("Cars")
                                     .Include("RepairCars")
                                     .FirstOrDefault(c => c.Id == Id);
            return result;
        }
    }
}

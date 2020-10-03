using DotnetP5App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class InventoryRepository : IInventoryRepository
    {
        CarDBContext _db;
        public InventoryRepository(CarDBContext db)
        {
            _db = db;
        }

        public void AddInvoice(Inventory Invoice)
        {
            _db.Add(Invoice);
            _db.SaveChanges();
        }

        public IEnumerable<Inventory> GetAll()
        {
            return from invoice in _db.Inventories
                   orderby invoice.Id
                   select invoice;
        }

        public void Update(Inventory Invoice)
        {
            var entry = _db.Entry(Invoice);
            entry.State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(List<Inventory> Invoices)
        {
            _db.Remove(Invoices);
            _db.SaveChanges();
        }
        public void DeleteById(int Id)
        {
            var InvoiceFound = FindInvoiceById(Id);
            if (InvoiceFound != null)
            {
                _db.Inventories.Remove(InvoiceFound);
                _db.SaveChanges();
            }

        }

        public Inventory FindInvoiceById(int Id)
        {
            var result = _db.Inventories.FirstOrDefault(c => c.Id == Id);
            return result;
        }
    }
}

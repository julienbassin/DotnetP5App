using DotnetP5App.Models;
using System.Collections.Generic;

namespace DotnetP5App.Services
{
    public interface IInventoryRepository
    {
        void AddInvoice(Inventory Invoice);
        void Delete(List<Inventory> Invoices);
        void DeleteById(int Id);
        Inventory FindInvoiceById(int Id);
        IEnumerable<Inventory> GetAll();
        void Update(Inventory Invoice);
    }
}
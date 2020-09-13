using DotnetP5App.Models;
using System.Collections.Generic;

namespace DotnetP5App.Services
{
    public interface IInvoiceRepository
    {
        void AddInvoice(Invoice Invoice);
        void Delete(List<Invoice> Invoices);
        void DeleteById(int Id);
        Invoice FindInvoiceById(int Id);
        IEnumerable<Invoice> GetAll();
        void Update(Invoice Invoice);
    }
}
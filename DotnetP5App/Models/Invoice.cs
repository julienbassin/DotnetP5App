using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal Profit { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime SaleDate { get; set; }
        public string CustomerName { get; set; }
        //public string Status { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }

    }
}

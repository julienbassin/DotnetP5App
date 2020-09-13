using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Models
{
    public class RepairCar
    {
        public int Id { get; set; }
        public decimal RepairCost { get; set; }
        public string Description { get; set; }
        public DateTime RepairedDate { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}

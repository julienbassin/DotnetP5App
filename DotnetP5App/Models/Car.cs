using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Trim { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public int Vin { get; set; }
        [Required]
        public int PurchasePrice { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public DateTime LotDate { get; set; }

        //public string Description { get; set; }

        //public string Status { get; set; }
        public List<RepairCar> Repairs { get; set; }
        public Invoice Invoice { get; set; }

    }
}

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

        [Required(ErrorMessage = "Please enter model name")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please enter trim name")]
        public string Trim { get; set; }

        [Required(ErrorMessage = "Please enter make name")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter Year of the car")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Please enter Vehicule ID")]
        public int Vin { get; set; }

        [Required(ErrorMessage = "Please enter purchase price")]
        public int PurchasePrice { get; set; }

        [Required(ErrorMessage = "Please enter purchase date")]
        public DateTime PurchaseDate { get; set; }

        //[Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter lot date")]
        public DateTime LotDate { get; set; }

        //[Required(ErrorMessage = "Please choose profile image")]
        public string ProfilePicture { get; set; }
        public List<RepairCar> Repairs { get; set; }
        public Inventory Invoice { get; set; }

    }
}

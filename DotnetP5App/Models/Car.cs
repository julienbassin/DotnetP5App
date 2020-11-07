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
        [RegularExpression("[A-HJ-NPR-Z0-9]{13}[0-9]{4}", ErrorMessage = "Invalid Vehicle Identification Number Format.")]
        public string Vin { get; set; }

        [Required(ErrorMessage = "Please enter purchase price")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public int PurchasePrice { get; set; }

        [Required(ErrorMessage = "Please enter purchase date")]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a price for the demo")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public int SellingPrice { get; set; }

        public DateTime LotDate { get; set; }

        public DateTime SaleDate { get; set; }

        [Required(ErrorMessage = "Please upload an image")]
        public string ProfilePicture { get; set; }       
        public string Status { get; set; }
        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public string RepairCost { get; set; }
        public List<RepairCar> Repairs { get; set; }

    }
}

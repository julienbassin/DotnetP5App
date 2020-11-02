using DotnetP5App.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace DotnetP5App.ViewModels
{
    public class CarViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Model name")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please enter Trim name")]
        public string Trim { get; set; }

        [Required(ErrorMessage = "Please enter Make name")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter Year ")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Please enter Vehicule ID")]
        [RegularExpression("[A-HJ-NPR-Z0-9]{13}[0-9]{4}", ErrorMessage = "Invalid Vehicle Identification Number Format.")]
        public string Vin { get; set; }

        [Required(ErrorMessage = "Please enter Purchase price")]
        public int PurchasePrice { get; set; } 

        [Required(ErrorMessage = "Please enter Purchase date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please enter Lot date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime LotDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please enter Description of the car")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please add an image")]
        [Display(Name = "Profile Picture")]
        public IFormFile ProfileImage { get; set; }
        
        [Display(Name = "Selling Price")]
        public int SellingPrice { get; set; }

        [Display(Name = "Sale Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public string RepairCost { get; set; }
        public string Status { get; set; }
        public List<SelectListItem> ListRepairCar { get; set; } = new List<SelectListItem>();
        public List<string> RepairCarList { get; set; }

    }
}

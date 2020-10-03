﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.ViewModels
{
    public class CarViewModel
    {
        [Required(ErrorMessage = "Please enter Model name")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please enter Trim name")]
        public string Trim { get; set; }

        [Required(ErrorMessage = "Please enter Make name")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter Year ")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Please enter Vehicule ID")]
        public int Vin { get; set; }

        [Required(ErrorMessage = "Please enter Purchase price")]
        public int PurchasePrice { get; set; }

        [Required(ErrorMessage = "Please enter Purchase date")]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Please enter Lot date")]
        public DateTime LotDate { get; set; }

        [Required(ErrorMessage = "Please enter Description of the car")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please add an image")]
        [Display(Name = "Profile Picture")]
        public IFormFile ProfileImage { get; set; }
    }
}
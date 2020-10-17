using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace DotnetP5App.ViewModels
{
    public class InventoryViewModel
    {
        public int InventoryId { get; set; }
        public int CarId { get; set; }      
        [Required]
        public double Profit { get; set; }
        public string CustomerName { get; set; }

        [Required]
        public int TotalCost { get; set; }

        [Required]
        public DateTime dateTime { get; set; }
        public string PurchasePrice { get; set; }
        public List<SelectListItem> Cars { get; set; } = new List<SelectListItem>();

        public string RepairCost { get; set; }
        public List<SelectListItem> RepairCar { get; set; } = new List<SelectListItem>();

    }
}

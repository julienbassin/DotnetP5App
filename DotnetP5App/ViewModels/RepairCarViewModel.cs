using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DotnetP5App.ModelsViewModels
{
    public class RepairCarViewModel
    {
        [Required]
        public int CarId { get; set; }
        public string Description { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
        public List<SelectListItem> Cars { get; set; } = new List<SelectListItem>();
    }
}

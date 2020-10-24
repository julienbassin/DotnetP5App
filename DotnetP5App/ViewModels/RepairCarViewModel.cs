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
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public List<SelectListItem> Cars { get; set; } = new List<SelectListItem>();
    }
}

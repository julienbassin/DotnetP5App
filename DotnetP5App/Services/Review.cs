using DotnetP5App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public double Rating { get; set; }
        [MaxLength(5)]
        public string Comments { get; set; }
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public int CarId { get; set; }

        public Car Cars { get; set; }
    }
}

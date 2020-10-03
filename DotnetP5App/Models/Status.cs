using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}

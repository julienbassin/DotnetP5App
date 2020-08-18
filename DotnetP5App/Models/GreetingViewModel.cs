using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}

using DotnetP5App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class CarDBContext : DbContext
    {
        public CarDBContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}

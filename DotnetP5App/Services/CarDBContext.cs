﻿using DotnetP5App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class CarDBContext : DbContext
    {
        public CarDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<RepairCar> RepairCars { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<FileModel> FileModel { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source= (local)\\MSSQLLocalDB; Initial Catalog = P5RentLocationAppDb"
                );
            }                
        }
    }
}

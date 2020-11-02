using DotnetP5App.Models;
using DotnetP5App.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDBContext _db;
        public CarRepository(CarDBContext db)
        {
            _db = db;
        }
        public void AddCar(Car car)
        {
            _db.Add(car);
            _db.SaveChanges();
        }

        public void DeleteCarById(int Id)
        {
            var car = GetCarById(Id);
            if (car != null)
            {
                _db.Cars.Remove(car);
                _db.SaveChanges();
            }
        }

        public Car GetCarById(int Id)
        {
            return _db.Cars.FirstOrDefault(c => c.Id == Id);
        }

        public IEnumerable<Car> GetAll()
        {
            return from c in _db.Cars
                   orderby c.Model
                   select c;
        }

        public void Update(Car car)
        {
            var model = _db.Cars.FirstOrDefault(c => c.Id == car.Id);
            if(model != null)
            {
                model.Make = car.Make;
                model.Model = car.Model;
                model.Trim = car.Trim;
                model.Vin = car.Vin;
                model.Year = car.Year;
                model.PurchasePrice = car.PurchasePrice;
                model.PurchaseDate = car.PurchaseDate;
                model.LotDate = car.LotDate;
                model.SellingPrice = car.SellingPrice;
                model.RepairCost = car.RepairCost;
                model.SaleDate = car.SaleDate;
                model.ProfilePicture = car.ProfilePicture;
                model.Status = car.Status;
                _db.SaveChanges();
            }           
        }
    }
}

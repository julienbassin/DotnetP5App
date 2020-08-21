using DotnetP5App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class SqlCarData : ICarData
    {
        private readonly CarDBContext _db;

        public SqlCarData(CarDBContext db)
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
            var car = FindCarById(Id);
            if (car != null)
            {
                _db.Cars.Remove(car);
                _db.SaveChanges();
            }
        }

        public Car FindCarById(int Id)
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
            var entry = _db.Entry(car);
            entry.State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}

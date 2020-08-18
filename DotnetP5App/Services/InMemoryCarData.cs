using DotnetP5App.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetP5App.Services
{
    public class InMemoryCarData : ICarData
    {
        private static List<Car> _cars = new List<Car>();

        public InMemoryCarData()
        {
            if(!_cars.Any())
            {
                GenerateProductData();
            }
            
        }

        private void GenerateProductData()
        {
            int id = 0;
            _cars.Add(new Car { Id = ++id, Model = "Miata", Trim = "LE", Make = "Mazda", Year = "1991" });
            _cars.Add(new Car { Id = ++id, Model = "Liberty", Trim = "Sport", Make = "Jeep", Year = "2007" });
            _cars.Add(new Car { Id = ++id, Model = "Grand Caravan", Trim = "Sport", Make = "Dodge", Year = "2007" });
            _cars.Add(new Car { Id = ++id, Model = "Explorer", Trim = "XLT", Make = "Ford", Year = "2017" });
            _cars.Add(new Car { Id = ++id, Model = "Civic", Trim = "LX", Make = "Honda", Year = "2008" });
            _cars.Add(new Car { Id = ++id, Model = "GTI", Trim = "S", Make = "Volkswagon", Year = "2016" });
            _cars.Add(new Car { Id = ++id, Model = "Edge", Trim = "SEL", Make = "Ford", Year = "2013" });
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
            car.Id = _cars.Max(c => c.Id) + 1;
        }

        public Car FindCarById(int Id)
        {
            return _cars.FirstOrDefault(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            var updatedCar = FindCarById(car.Id);
            if( updatedCar != null)
            {
                updatedCar.Model = car.Model;
                updatedCar.Trim = car.Trim;
                updatedCar.Make = car.Make;
                updatedCar.Year = car.Year;
                updatedCar.LotDate = car.LotDate;
                updatedCar.PurchaseDate = car.PurchaseDate;
                updatedCar.PurchasePrice = car.PurchasePrice;
            }
            
        }

        public void DeleteCarById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            return _cars.OrderBy(c => c.Model);
        }
    }
}

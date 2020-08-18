using DotnetP5App.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public interface ICarData
    {
        IEnumerable<Car> GetAll();
        Car FindCarById(int Id);
        void Update(Car car);
        void DeleteCarById(int Id);
        void AddCar(Car car);
    }
}

using DotnetP5App.Models;
using DotnetP5App.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        Car GetCarById(int Id);
        void Update(Car car);
        void DeleteCarById(int Id);
        void AddCar(Car car);
    }
}

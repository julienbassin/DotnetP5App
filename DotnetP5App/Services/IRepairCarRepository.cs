using DotnetP5App.Models;
using DotnetP5App.ModelsViewModels;
using System.Collections.Generic;

namespace DotnetP5App.Services
{
    public interface IRepairCarRepository
    {
        void AddRepairCar(RepairCar repairCar);
        IEnumerable<RepairCar> GetAll();
        void Update(RepairCar repairCar);
        RepairCar FindRepairCarById(int Id);
        void DeleteRepairCarById(int Id);
        void UpdateRepairCar(RepairCarViewModel repairCar);
    }
}
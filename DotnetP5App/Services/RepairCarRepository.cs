using DotnetP5App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class RepairCarRepository : IRepairCarRepository
    {
        CarDBContext _db;
        public RepairCarRepository(CarDBContext db)
        {
            _db = db;
        }

        public void AddRepairCar(RepairCar repairCar)
        {
            _db.Add(repairCar);
            _db.SaveChanges();
        }

        public IEnumerable<RepairCar> GetAll()
        {
            return from rc in _db.RepairCars
                   orderby rc.Id
                   select rc;
        }

        public void Update(RepairCar repairCar)
        {
            var entry = _db.Entry(repairCar);
            entry.State = EntityState.Modified;
            _db.SaveChanges();
        }

        public RepairCar FindRepairCarById(int Id)
        {
            return _db.RepairCars.Include(c => c.Car).FirstOrDefault(c => c.Id == Id);
        }
    }
}

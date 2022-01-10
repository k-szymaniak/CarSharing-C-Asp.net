using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Models;

namespace CarRent.Repositories
{
    public interface ICarRepository
    {
        CarModel Get(int carId);
        IQueryable<CarModel> GetAll();

        void Add(CarModel car);
        void Update(int carId, CarModel car);

        void Delete(int carId);
    }
}
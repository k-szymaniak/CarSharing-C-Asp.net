using CarRent.Models;
using CarRent.Repositories;
using Core_3._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarSharing.Repositories
{

    //Cars
    public class CarRepository : ICarRepository
    {
        private readonly AppDBContext _context;
        public CarRepository(AppDBContext context)
        {
            _context = context;
        }

        public void Add(CarModel car)
        {
            _context.cars.Add(car);
            _context.SaveChanges();
        }

        public void Delete(int carId)
        {
            var result = _context.cars.SingleOrDefault(x => x.CarId == carId);
            if (result != null)
            {
                _context.cars.Remove(result);
                _context.SaveChanges();
            }
        }

        public CarModel Get(int carId)
                => _context.cars.SingleOrDefault(x => x.CarId == carId);

        public IQueryable<CarModel> GetAll()
            => _context.cars;




        public void Update(int carId, CarModel car)
        {
            var result = _context.cars.SingleOrDefault(x => x.CarId == carId);
            if (result != null)
            {
                result.CarMark = car.CarMark;
                result.Model = car.Model;
                result.Power = car.Power;
                result.FuelType = car.FuelType;
                result.Price = car.Price;
                result.Category = car.Category;
                result.Mileage = car.Mileage;
                result.Description = car.Description;
                result.Availability = car.Availability;

                _context.SaveChanges();

            }
        }


        public void ChangeAvailability(int carId, CarModel car)
        {
            var result = _context.cars.SingleOrDefault(x => x.CarId == carId);
            if (car.Availability == true)
            {

                result.Availability = false == car.Availability;
                _context.SaveChanges();

            }
            if (car.Availability == false)
            {

                result.Availability = true == car.Availability;
                _context.SaveChanges();

            }
        }
    }
}

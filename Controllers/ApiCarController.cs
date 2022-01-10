using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Repositories;
using CarRent.Models;
using CarSharing.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace CarRent.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class ApiCarController : ControllerBase
   {
        
        private readonly ICarRepository _carRepository;

        public ApiCarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public ActionResult<List<CarModel>> GetAll() => _carRepository.GetAll().ToList();


        [HttpGet("{CarId}", Name = "GetCar")]
        public ActionResult<CarModel> Get(int CarId)
        {
            var car = _carRepository.Get(CarId);

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }

        [HttpPost]
        public ActionResult<CarModel> Add(CarModel car)
        {
            _carRepository.Add(car);

            return CreatedAtRoute("GetCar", new { id = car.CarMark, car.Model, car.Power, car.FuelType, car.Price, car.Category, car.Mileage, car.Description, car.Availability }, car);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{CarId}")]
        public IActionResult Delete(int CarId)
        {
            var car = _carRepository.Get(CarId);

            if (car == null)
            {
                return NotFound();
            }

            _carRepository.Delete(car.CarId);

            return NoContent();
        }
    }

}



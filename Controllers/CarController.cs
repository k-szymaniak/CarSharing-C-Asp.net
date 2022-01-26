using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Models;
using CarRent.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace CarRent.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }






        //Cars

        // GET: CarController
        public ActionResult Index()
            {

                return View(_carRepository.GetAll());
            }
            public ActionResult Cars()
            {

                return View(_carRepository.GetAll());
            }
            public ActionResult Motorcycles()
            {

                return View(_carRepository.GetAll());
            }
            public ActionResult Others()
            {

                return View(_carRepository.GetAll());
            }
            public ActionResult Contact()
            {

                return View(nameof(Contact));
            }



            public ActionResult Admin()
            {
                return View(_carRepository.GetAll());
            }

            // GET: CarController/Details/5
            [Authorize]
            public ActionResult Details(int id)
            {
                return View(_carRepository.Get(id));
            }

            // GET: CarController/Create
            [Authorize(Roles = "Admin")]
            public ActionResult Create()
            {
                return View(new CarModel());
            }

            // POST: CarController/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(CarModel carModel)
            {
                _carRepository.Add(carModel);

                return RedirectToAction(nameof(Index));

            }

            // GET: CarController/Edit/5
            [Authorize(Roles = "Admin")]
            public ActionResult Edit(int id)
            {
                return View(_carRepository.Get(id));
            }

            // POST: CarController/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(int id, CarModel carModel)
            {
                _carRepository.Update(id, carModel);

                return RedirectToAction(nameof(Index));

            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult ChangeAvailability(int id, CarModel carModel)
            {
                _carRepository.ChangeAvailability(id, carModel);



                return RedirectToAction(nameof(Index));


            }

            public ActionResult ChangeAvailability(int id)
            {
                return View(_carRepository.Get(id));
            }



            // GET: CarController/Delete/5
            [Authorize(Roles = "Admin")]
            public ActionResult Delete(int id)
            {
                return View(_carRepository.Get(id));
            }

            // POST: CarController/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(int id, CarModel carModel)
            {
                _carRepository.Delete(id);
                return RedirectToAction(nameof(Index));


            }




        
    }
}


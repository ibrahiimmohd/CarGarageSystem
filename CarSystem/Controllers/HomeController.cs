using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSystem.Models;

namespace CarSystem.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Register(Car car)
        {
            Repository.Add(car);
            return View("ThankYou", car);
        }

        public ViewResult List()
        {
            return View(Repository.Cars.OrderBy(c => c.Name));
        }

        public ViewResult ViewCar(int id)
        {
            return View(Repository.Cars.Single(c => c.id == id));
        }
    }
}

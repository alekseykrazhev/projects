using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class A { }

    
    public class ComputersController : Controller
    {
        private readonly IAllComputers _allCars;
        private readonly IComputersCategory _allCategories;

        public ComputersController(IAllComputers iAllComputers, IComputersCategory iComputersCat) {
            _allCars = iAllComputers;
            _allCategories = iComputersCat;
        }

        public ViewResult List(A a) {
            ViewBag.Title = "Chest-computer";
            ComputersListViewModel obj = new ComputersListViewModel();
            obj.allComputers = _allCars.Computers;
            obj.computerCategory = "Top Computers";
            return View(obj);
        }
    }
}

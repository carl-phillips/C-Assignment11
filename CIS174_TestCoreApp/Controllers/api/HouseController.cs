using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers.api
{
    public class HouseController : Controller
    {
        // GET: House  
        //public IActionResult Index()
        //{
        //    var viewModel = new HouseViewModel
        //    {
        //        Bedrooms = "4"
        //    };
        //    return View();
        //}

        public HouseViewModel viewModel1 = new HouseViewModel
        {
            Id = 1,
            Bedrooms = "4",
            SquareFeet = "1000",
            DateBuilt = new DateTime(12890),
            Flooring = "Wood"
        };
        public HouseViewModel viewModel2 = new HouseViewModel
        {
            Id = 2,
            Bedrooms = "3",
            SquareFeet = "2000",
            DateBuilt = new DateTime(1234589),
            Flooring = "Carpet"
        };

        [Route("api/house")]
        [HttpGet]
        public IEnumerable<HouseViewModel> Index()
        {
            List<HouseViewModel> houses = new List<HouseViewModel>
            {
                viewModel1,
                viewModel2
            };
            return houses;
        }

        [Route("api/house/{id}")]
        [HttpGet]
        public HouseViewModel Index(int Id)
        {
            if(Id == 1)
            {
                return viewModel1;
            } else if (Id == 2)
            {
                return viewModel2;
            }
            else
            {
                return new HttpNotFoundResult();
            }
        }

        // GET: House/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }


        // GET: House/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: House/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: House/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: House/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: House/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: House/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
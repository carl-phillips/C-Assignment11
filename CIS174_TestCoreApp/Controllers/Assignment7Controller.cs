using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment7Controller : Controller
    {
        // GET: Assignment7
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CreatePerson2Model model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        // POST: Assignment7/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            return View();
        }
    }
}
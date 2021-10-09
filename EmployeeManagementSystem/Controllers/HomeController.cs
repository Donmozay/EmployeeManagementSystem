using EmployeeManagementSystem.Domain;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeServices _employeeServices;

        public HomeController(ILogger<HomeController> logger, IEmployeeServices employeeServices)
        {
            _logger = logger;
            _employeeServices = employeeServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult GetEmployee(string searchString)
        {
            var view = _employeeServices.GetEmployee(searchString);

            return View("GetEmployee", view);
        }
        [HttpGet]
        public IActionResult Login( string errorMessage = "")
        {
            var view = _employeeServices.GetLoginView( errorMessage);
            return View("Login", view);
        }

        [HttpPost]
        public IActionResult Login(EmployeeView login)
        {
            if (login.UserName.ToLower() == "admin" && login.Password.ToLower() == "admin")
            {
                return this.RedirectToAction("GetEmployee", "Home" );
            }
            return this.RedirectToAction("Login", "Home", new { errorMessage = "InValid UserName or Password" });
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            var view = _employeeServices.GetEmployeeView();
            return View("AddEmployee", view);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeView employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            var returnInfo = _employeeServices.SaveEmployee(employee);

            if (!string.IsNullOrEmpty(returnInfo))
            {
                return View("AddEmployee");
            }
            return RedirectToAction("GetEmployee");
        }
    }
}

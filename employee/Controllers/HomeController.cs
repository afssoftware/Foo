using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeConnect.Models;
using EmployeeConnect.ViewModels;

namespace EmployeeConnect.Controllers
{
   
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        // construct injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        } 
        //public string Index()
        [Route("")]
        [Route("~/Home")]
        [Route("~/")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

       
        [Route("{id?}")]
        public ViewResult Details(int? id)
        {

            HomeDetailsViewModel HomeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };           

            return View(HomeDetailsViewModel);
        }
        public ViewResult Edit()
        {
            Employees model = _employeeRepository.GetEmployee(2);
            return View(model);            
            
        }

        
    }
}

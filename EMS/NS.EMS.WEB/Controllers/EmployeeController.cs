using Microsoft.AspNetCore.Mvc;
using NS.EMS.Business;
using NS.EMS.Data.Entities;
using NS.EMS.Model;
using System;

namespace NS.EMS.WEB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBusiness _IEmployeeBusiness;
        public EmployeeController(IEmployeeBusiness iEmployeeBusiness)
        {
            _IEmployeeBusiness = iEmployeeBusiness;
        }
        public IActionResult EmployeeDetail()
        {
            return View();

            // return View(_IEmployeeBusiness.ShowDetail());
        }
        [HttpPost]

        public IActionResult Create(EmployeeModel employeeModel)
        {
            _IEmployeeBusiness.AddEmployee(employeeModel);
            return RedirectToAction("EmployeeDetail", "Employee");
        }
        public IActionResult ShowDetail()
        {
            return View(_IEmployeeBusiness.ShowDetail());
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_IEmployeeBusiness.GetEmployeeById(id));
        }
        [HttpPost]
        public IActionResult Update(Employee employee, int id)
        {
            if (ModelState.IsValid)
            {
                _IEmployeeBusiness.Update(employee, id);
                return RedirectToAction("ShowDetail", "Employee");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Delete(Employee employee, int id)
        {
            _IEmployeeBusiness.Delete(employee, id);
            return RedirectToAction("ShowDetail", "Employee");
        }
    }
}

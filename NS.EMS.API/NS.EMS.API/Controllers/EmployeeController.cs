using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NS.EMS.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NS.EMS.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        
        public IActionResult GetEmployees()
        {
            var employeeList = new List<Employee>();
            using (var context = new EmployeeDBContext())
            {
                employeeList=context.Employee.ToList();
            }
            return Ok(employeeList);
        }
        [HttpGet]
        public IActionResult GetEmployeeByEid(int eId)
        {
            var employee = new Employee();
            using (var context = new EmployeeDBContext())
            {
                employee = context.Employee.Find(eId);
            }
            if(employee == null)
            {
                return NotFound("Employee not found");
            }
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            using (var context = new EmployeeDBContext())
            {
                context.Employee.Add(employee);
                context.SaveChanges();
            }
            return Ok("Record added");
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            using (var context = new EmployeeDBContext())
            {
                context.Employee.Update(employee);
                context.SaveChanges();
            }
            return Ok("Record updated");
        }
        [HttpDelete]
        public IActionResult DeleteEmployeeByEid(int eId)
        {
            var employee = new Employee();
            using (var context = new EmployeeDBContext())
            {
               // employee = context.Employee.Find(eId);
                context.Employee.Remove(employee);  
            }
            if (employee == null)
            {
                return NotFound("Employee not found");
            }
            return Ok(employee);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult DetailsView()
        {
            {
                EmployeeModel emp = new EmployeeModel();
                emp.Employees.Add(new EmployeeDetails()
                {
                    EmpId = "1",
                    EmpName = "ABC",
                    EmpAge = "23",
                });
                emp.Employees.Add(new EmployeeDetails()
                {
                    EmpId = "2",
                    EmpName = "DEF",
                    EmpAge = "24",
                });
                emp.Employees.Add(new EmployeeDetails()
                {
                    EmpId = "3",
                    EmpName = "GHI",
                    EmpAge = "25",
                });
            
            return View(emp);
        }
        }
    }
}

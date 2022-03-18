using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeViewModel employeeViewModel;
        public EmployeeController()
        {
            employeeViewModel = new EmployeeViewModel();
            employeeViewModel.Employees.Add(new Employee
            {
                Id = 1,
                Name = "A",
                Age=21,
                Domain = "DOTNET",
                Email = "a@gmail.com"
            }); employeeViewModel.Employees.Add(new Employee
            {
                Id = 2,
                Name = "B",
                Age = 22,
                Domain = "PHP",
                Email = "b@gmail.com"
            }); employeeViewModel.Employees.Add(new Employee
            {
                Id = 3,
                Name = "C",
                Age = 23,
                Domain = "PYTHON",
                Email = "c@gmail.com"
            }); employeeViewModel.Employees.Add(new Employee
            {
                Id = 4,
                Name = "D",
                Age = 21,
                Domain = "DOTNET",
                Email = "d@gmail.com"
            }); employeeViewModel.Employees.Add(new Employee
            {
                Id = 5,
                Name = "E",
                Age = 26,
                Domain = "JAVA",
                Email = "e@gmail.com"
            });

        }
        public IActionResult Index(string name)
        {
            return View(employeeViewModel.Employees.FirstOrDefault(x => x.Name == name));
        }
        public IActionResult EmployeeList()
        {
            return View(employeeViewModel);
        }
    }
}

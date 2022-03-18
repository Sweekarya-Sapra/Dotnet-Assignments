using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        StudentViewModel studentViewModel;
        public StudentController()
        {
            studentViewModel = new StudentViewModel();
            studentViewModel.Students.Add(new Student
            {
                Id = 1,
                FirstName = "ABC",
                LastName = "XYZ",
                Email = "abc@gmail.com"
            }); studentViewModel.Students.Add(new Student
            {
                Id = 2,
                FirstName = "AC",
                LastName = "XZ",
                Email = "ab@gmail.com"
            }); studentViewModel.Students.Add(new Student
            {
                Id = 3,
                FirstName = "AB",
                LastName = "XY",
                Email = "ac@gmail.com"
            });

        }
        public IActionResult Index(int id)
        {
            return View(studentViewModel.Students.FirstOrDefault(x => x.Id == id));
        }
        public IActionResult StudentList()
        {
            
            return View(studentViewModel);
        }
    }
}

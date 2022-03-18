using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>
        {
            new Student() {
                Id = 1,
                Name = "ABC",
                Age = 15,
                Phone = "3452656478",
            },
            new Student() {
                Id = 2,
                Name = "DEF",
                Age = 16,
                Phone="8976789590",
            },
            new Student() {
                Id = 3,
                Name = "GHI",
                Age = 17,
                Phone="7689598076",
            },
            new Student() {
                Id = 4,
                Name = "JKL",
                Age = 18,
                Phone="9876584329",
            },
        
        };
        

        public IActionResult Insert()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Insert(Student st)
        {
            studentList.Add(st);
            return RedirectToAction("StudentList");
        }
        public IActionResult StudentList()
        {

            return View(studentList.OrderBy(s => s.Id).ToList());

        }



        public IActionResult Edit(int id)
        {

            var s = studentList.Where(s => s.Id == id).FirstOrDefault();
            return View(s);
        }

        [HttpPost]
        public IActionResult Edit(Student st)
        {
            var student = studentList.Where(student => student.Id == st.Id).FirstOrDefault();
            studentList.Remove(student);
            studentList.Add(st);
            return RedirectToAction("StudentList");
        }


        public IActionResult Delete(int id)
        {

            var s = studentList.Where(s => s.Id == id).FirstOrDefault();
            return View(s);
        }
        [HttpPost]
        public IActionResult Delete(Student st)
        {
            var student = studentList.Where(student => student.Id == st.Id).FirstOrDefault();
            studentList.Remove(student);
            return RedirectToAction("StudentList");
        }
    }
}

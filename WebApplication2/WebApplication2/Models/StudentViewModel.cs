using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Students = new List<Student>();
        }
        public List<Student> Students { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

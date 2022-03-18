using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class StudentViewModel
    {
       
    }
    public class Student
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}

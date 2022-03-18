using System.Collections.Generic;
namespace WebApplication4.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Employees = new List<Employee>();
        }
        public List<Employee> Employees { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Domain { get; set; }
        public string Email { get; set; }
    }
}

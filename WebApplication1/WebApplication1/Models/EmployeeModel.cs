namespace WebApplication1.Models
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {
            Employees = new List<EmployeeDetails>();
        }
        public List<EmployeeDetails> Employees { get; set; }
    }
    public class EmployeeDetails
        {
        public string EmpName { get; set; }
        public string EmpAge { get; set; }
        public string EmpId { get; set; }
    }
}

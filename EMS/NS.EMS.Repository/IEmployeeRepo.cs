using NS.EMS.Data.Entities;
using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Repository
{
    public interface IEmployeeRepo
    {
        bool AddEmployee(EmployeeModel employeeModel);
        List<Employee> ShowDetail();
        public Employee GetEmployeeById(int id);
        bool Update(Employee employee, int id);
        bool Delete(Employee employee, int id);
        
    }
}

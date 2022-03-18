using NS.EMS.Data.Entities;
using NS.EMS.Model;
using NS.EMS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepo _IEmployeeRepo;
        public EmployeeBusiness(IEmployeeRepo IEmployeeRepo)
        {
            _IEmployeeRepo = IEmployeeRepo;
        }
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            return _IEmployeeRepo.AddEmployee(employeeModel);
        }
        public List<Employee> ShowDetail()
        { 
            return _IEmployeeRepo.ShowDetail();
        }
       
        public Employee GetEmployeeById(int id)
        {
            return _IEmployeeRepo.GetEmployeeById(id);
        }
        public bool Update(Employee employee, int id)
        {
            return _IEmployeeRepo.Update(employee, id);
        }
        public bool Delete(Employee employee, int id)
        {
            return _IEmployeeRepo.Delete(employee, id);
        }
    }
}

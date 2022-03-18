
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NS.EMS.Data.Entities;
using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS.EMS.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        



        public bool AddEmployee(EmployeeModel EmpDept)
        {
            using (var context = new EmployeeDBContext())
            {
                var paraamList = new List<SqlParameter>();
                paraamList.Add(new SqlParameter("@EmployeeName", EmpDept.EmployeeName));
                paraamList.Add(new SqlParameter("@Email", EmpDept.Email));
                paraamList.Add(new SqlParameter("@Mobile", EmpDept.Mobile));
                paraamList.Add(new SqlParameter("@Department", EmpDept.Department));


                context.Database.ExecuteSqlRaw("usp_AddEmployee @EmployeeName, @Email, @Mobile, @Department", paraamList);

            }
            return true;
        }

        public List<Employee> ShowDetail()
        {
            List<Employee> returnList = new List<Employee>();
            using (var context = new EmployeeDBContext())
            {
                //var detail = context.Employee.FromSqlRaw("Select * from Employee").ToList();
                var detail = context.Employee.FromSqlRaw("usp_GetEmployees").ToList();
                

                returnList = detail;
            }
            return returnList;

        }
        //public bool Update(Employee employee)
        //{
        //    using (var context = new EmployeeDBContext())
        //    {
        //        var paraamList = new List<SqlParameter>();
        //        paraamList.Add(new SqlParameter("@Eid", employee.Eid));
        //        paraamList.Add(new SqlParameter("@EmployeeName", employee.EmployeeName));
        //        paraamList.Add(new SqlParameter("@Email", employee.Email));

        //        paraamList.Add(new SqlParameter("@Mobile", employee.Mobile));

        //        context.Database.ExecuteSqlRaw("usp_UpdateEmployees @Eid, @EmployeeName, @Email, @Mobile", paraamList);

        //    }
        public Employee GetEmployeeById(int id)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            var empid = context.Employee.Where(x => x.Eid == id).FirstOrDefault();
            return empid;
        }
        public bool Update(Employee employee, int id)
        {
            using (var context = new EmployeeDBContext())
            {
                Employee emp = new Employee();
                emp.Eid = id;
                emp.EmployeeName = employee.EmployeeName;
                emp.Email = employee.Email;
                
                emp.Mobile = employee.Mobile;
                emp.Department = employee.Department;
                
                context.Entry(emp).State = EntityState.Modified;
                context.SaveChanges();
            }
            return true;
        }
        public bool Delete(Employee employee, int id)
        {
            using (var context = new EmployeeDBContext())
            {
                Employee emp = new Employee();
                emp.Eid = id;
                emp.EmployeeName = employee.EmployeeName;
                emp.Email = employee.Email;
                emp.Mobile = employee.Mobile;
                emp.Department= employee.Department;
                
                context.Remove(emp);
                context.SaveChanges();
            }
            return true;
        }
    }
}

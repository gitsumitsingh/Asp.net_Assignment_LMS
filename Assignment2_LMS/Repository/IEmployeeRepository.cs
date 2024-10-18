using Assignment2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2_LMS.Repository
{
    public interface IEmployeeRepository : IDisposable
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById(int studentId);
        int AddEmployee(Employee employeeEntity);
        int UpdateEmployee(Employee employeeEntity);
        void DeleteEmployee(int employeeId);
    }
}
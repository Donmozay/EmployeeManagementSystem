using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Repositories.Data;
using EmployeeManagementSystem.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementSystem.Repositories.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;

        }
        

        public IEnumerable<IEmployee> GetEmployees()
        {
            try
            {
                var employee = _context.Employee.ToList();
                return employee;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException(" Get Employees {0}", e);
            }
        }

        public string SaveEmployee(IEmployeeView employee)
        {
            var result = string.Empty;

            var details = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Department = employee.Department,
                DateOfBirth = employee.DateOfBirth.ToString("yyyy/MM/dd")
        };

            try
            {
                _context.Employee.Add(details);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                result = string.Format("SaveEmployee - {0} , {1}", e.Message,
                    e.InnerException != null ? e.InnerException.Message : "");
            }

            return result;
        }

    }
}

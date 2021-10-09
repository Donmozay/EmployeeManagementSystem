using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeRepository
    {
        //IEmployee GetEmployeeAsync(int id);

        IEnumerable<IEmployee> GetEmployees();

        string SaveEmployee(IEmployeeView employee);
    }
}

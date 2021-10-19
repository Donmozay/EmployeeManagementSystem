using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeServices
    {
        IEmployeeView GetLoginView( string errorMessage);

        IEmployeeView GetEmployee();

        IEmployeeView GetEmployeeView();

        string SaveEmployee(IEmployeeView employee);
    }
}

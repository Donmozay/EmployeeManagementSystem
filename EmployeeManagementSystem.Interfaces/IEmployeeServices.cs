using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeServices
    {
        IEmployeeView GetLoginView( string errorMessage);

        IEmployeeView GetEmployee(string searchString);

        IEmployeeView GetEmployeeView();

        string SaveEmployee(IEmployeeView employee);
    }
}

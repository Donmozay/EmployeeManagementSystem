using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeFactory
    {
        IEmployeeView CreateLoginView(string errorMessage);

        IEmployeeView CreateEmployeeView();

        IEmployeeView CreateEmployeeListView(IList<IEmployee> employees);
    }
}

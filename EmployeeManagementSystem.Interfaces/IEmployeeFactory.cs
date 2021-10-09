using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeFactory
    {
        IEmployeeView CreateLoginView();

        IEmployeeView CreateEmployeeView();

        IEmployeeView CreateEmployeeListView(IList<IEmployee> employees, string searchString);
    }
}

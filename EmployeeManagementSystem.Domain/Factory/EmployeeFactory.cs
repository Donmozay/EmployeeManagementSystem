using EmployeeManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementSystem.Domain.Factory
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public IEmployeeView CreateLoginView(string errorMessage)
        {
            var view = new EmployeeView
            {
                ErrorMessage = errorMessage ?? "",
            };
            return view;
        }
        public IEmployeeView CreateEmployeeView()
        {
            var view = new EmployeeView
            {
            };
            return view;
        }

        public IEmployeeView CreateEmployeeListView(IList<IEmployee> employees)
        {
            var view = new EmployeeView
            {
                employeeLis = employees
            };
            return view;
        }
    }
}

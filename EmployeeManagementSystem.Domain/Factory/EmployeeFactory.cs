using EmployeeManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementSystem.Domain.Factory
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public IEmployeeView CreateLoginView()
        {
            var view = new EmployeeView
            {
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

        public IEmployeeView CreateEmployeeListView(IList<IEmployee> employees, string searchString)
        {
            searchString = string.IsNullOrEmpty(searchString) ? "" : searchString.ToLower();
            var filteredList = employees.Where(x =>
              x.FirstName.ToLower().Contains(string.IsNullOrEmpty(searchString)
              ? x.FirstName.ToLower() : searchString) ||
              (x.LastName.ToLower()).Contains(string.IsNullOrEmpty(searchString)
              ? x.LastName.ToLower() : searchString) ||
               (x.Department.ToLower()).Contains(string.IsNullOrEmpty(searchString)
              ? x.Department.ToLower() : searchString) ||
               (x.DateOfBirth.ToLower()).Contains(string.IsNullOrEmpty(searchString)
              ? x.DateOfBirth.ToLower() : searchString)) ;
            var view = new EmployeeView
            {
                employeeLis = filteredList.ToList(),
                searchString = (searchString == "Name" ? "" : ""),

            };
            return view;
        }
    }
}

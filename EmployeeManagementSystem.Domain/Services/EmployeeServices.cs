using EmployeeManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Domain
{
    public class EmployeeServices: IEmployeeServices
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeFactory _employeeFactory;

        public EmployeeServices(IEmployeeRepository employeeRepository, IEmployeeFactory employeeFactory)
        {
           _employeeRepository = employeeRepository;
            _employeeFactory = employeeFactory;        
        }
        public IEmployeeView GetLoginView()
        {
            var viewModel = _employeeFactory.CreateLoginView();

            // return the view to controller
            return viewModel;
        }
        public IEmployeeView GetEmployee(string searchString)
        {
          var employees =  _employeeRepository.GetEmployees().ToList();

           return   _employeeFactory.CreateEmployeeListView(employees,searchString);
        }

       
        public IEmployeeView GetEmployeeView()
        {
            var viewModel = _employeeFactory.CreateEmployeeView();

            // return the view to controller
            return viewModel;
        }
        public string SaveEmployee(IEmployeeView employee)
        {
            return _employeeRepository.SaveEmployee(employee);
        }
    }
}

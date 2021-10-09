using EmployeeManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagementSystem.Domain
{
   public  class EmployeeView: IEmployeeView
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string Department { get; set; }
        public string searchString { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(20)]
        public string UserName { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        public string InfoMessage { get; set; }
        public string ErrorMessage { get; set; }
        public IList<IEmployee> employeeLis { get; set; }
    }
}

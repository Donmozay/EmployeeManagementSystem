using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeView
    {
        int Id { get; set; }
        [MaxLength(50)]
         string FirstName { get; set; }
        [MaxLength(50)]
         string LastName { get; set; }
        [MaxLength(100)]
         string Department { get; set; }
        string searchString { get; set; }
        DateTime DateOfBirth { get; set; }
        [MaxLength(20)]
        public string UserName { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        string Message { get; set; }
        IList<IEmployee> employeeLis { get; set; }
    }
}

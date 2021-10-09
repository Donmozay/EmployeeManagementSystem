using EmployeeManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagementSystem.Repositories.Models
{
    public class Employee: IEmployee
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string Department { get; set; }
        [MaxLength(10)]
        public string DateOfBirth { get; set; }
       

    }
}

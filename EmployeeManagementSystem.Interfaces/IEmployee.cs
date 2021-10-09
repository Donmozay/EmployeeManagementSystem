using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        [MaxLength(50)]
        string FirstName { get; set; }
        [MaxLength(50)]
        string LastName { get; set; }
        [MaxLength(100)]
        string Department { get; set; }
        [MaxLength(10)]
        string DateOfBirth { get; set; }
        
    }
    }

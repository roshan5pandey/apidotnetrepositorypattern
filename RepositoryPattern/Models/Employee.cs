using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        [Required]
        public DateTime Date_Of_Joining { get; set; }

        public string Address { get; set; }

    }
}

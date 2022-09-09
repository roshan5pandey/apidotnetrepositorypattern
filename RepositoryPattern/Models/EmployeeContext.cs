using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext>options):base(options)
        {

        }

        public DbSet<Employee>Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                EmployeeName = "Uncle",
                Salary = 12000.00,
                Date_Of_Joining = new DateTime(2020-12-11),
                
                Address = "999-888-7777"
            }, new Employee
            {
                EmployeeId = 2,
                EmployeeName = "Raja",
                Salary = 12000.00,
                Date_Of_Joining = new DateTime(2020-11-11),

                Address = "999-888-7777"
            });
        }





    }
}

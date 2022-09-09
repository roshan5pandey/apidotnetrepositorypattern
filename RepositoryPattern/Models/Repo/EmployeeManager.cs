using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Models.Repo
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        readonly EmployeeContext employeeContext;

        public EmployeeManager(EmployeeContext _employeeContext)
        {
            employeeContext = _employeeContext;
        }

        public void Add(Employee entity)
        {
            employeeContext.Employees.Add(entity);
            employeeContext.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            employeeContext.Employees.Remove(entity);
            employeeContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employeeContext.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return employeeContext.Employees.FirstOrDefault(d => d.EmployeeId == id);
        }

        public void Update(Employee dbEntity, Employee entity)
        {
            dbEntity.EmployeeId = entity.EmployeeId;
            dbEntity.EmployeeName = entity.EmployeeName;
            dbEntity.Salary = entity.Salary;
            dbEntity.Date_Of_Joining = entity.Date_Of_Joining;
            dbEntity.Address = entity.Address;

            employeeContext.SaveChanges();
        }
    }
}

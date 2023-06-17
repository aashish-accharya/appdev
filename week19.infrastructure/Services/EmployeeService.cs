using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week19.application.Common.Interface;
using week19.domain.Entities;
using week19.infrastructure.Persistance;

namespace week19.infrastructure.Services
{
    public class EmployeeService:IEmployeeDetails
    {
        private readonly ApplicationDBContext _employeeDb;
        public EmployeeService(ApplicationDBContext applicationDbContext)
        {
            this._employeeDb = applicationDbContext;
        }


        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var getallemployee = await _employeeDb.Employee.ToListAsync();

            return getallemployee;
        }

        public async Task<Employee> GetAsync(Guid id)
        {
            var employee = await _employeeDb.Employee.FirstOrDefaultAsync(x => x.ID == id);
            return employee;
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            employee.ID = Guid.NewGuid();
            await _employeeDb.AddAsync(employee);
            await _employeeDb.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> DeleteAsync(Guid id)
        {
            var employee = await _employeeDb.Employee.FirstOrDefaultAsync(x => x.ID == id);
            if (employee == null)
            {
                return null;
            }
            _employeeDb.Employee.Remove(employee);
            await _employeeDb.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateAsync(Guid id, Employee employee)
        {
            var extingEmployee = await _employeeDb.Employee.FirstOrDefaultAsync(x => x.ID == id);
            if (extingEmployee == null)
            {
                return null;
            }
            extingEmployee.Name = employee.Name;
            extingEmployee.Address = employee.Address;

            await _employeeDb.SaveChangesAsync();
            return extingEmployee;
        }
    }
}

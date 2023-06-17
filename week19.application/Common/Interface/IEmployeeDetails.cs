using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week19.domain.Entities;

namespace week19.application.Common.Interface
{
    public interface IEmployeeDetails
    {
        Task<IEnumerable<Employee>> GetAllAsync();

        Task<Employee> GetAsync(Guid id);

        Task<Employee> AddAsync(Employee employee);

        Task<Employee> DeleteAsync(Guid id);

        Task<Employee> UpdateAsync(Guid id, Employee employee);

    }
}

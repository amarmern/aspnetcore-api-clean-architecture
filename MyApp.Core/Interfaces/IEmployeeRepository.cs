using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployees();

        Task<EmployeeEntity> GetEmployeeById(Guid id);

        Task<EmployeeEntity> AddEmployeAsync(EmployeeEntity entity);

        Task<EmployeeEntity> UpdatemployeAsync(Guid employeeId, EmployeeEntity entity);

        Task<bool> DeleteEmployeAsync(Guid employeeId);
    }
}

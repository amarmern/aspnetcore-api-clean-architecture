using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployees();

        Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id);

        Task<EmployeeEntity> AddEmployeAsync(EmployeeEntity entity);

        Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entity);

        Task<bool> DeleteEmployeAsync(Guid employeeId);
    }
}

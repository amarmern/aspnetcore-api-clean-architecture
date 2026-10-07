using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application.commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;


    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = request.Employee;
            var addedEmployee = await employeeRepository.AddEmployeAsync(employee);
            return addedEmployee;
        }

    }
}

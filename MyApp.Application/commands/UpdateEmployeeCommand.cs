using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application.commands
{
    public record UpdateEmployeeCommand(Guid EmployeeId, EmployeeEntity Employee)
        : IRequest<EmployeeEntity>;


    public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
           return await employeeRepository.UpdateEmployeeAsync(request.EmployeeId, request.Employee);
        }
    }
}

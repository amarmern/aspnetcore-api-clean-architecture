using MediatR;
using MyApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application.commands
{
    public record DeleteEmployeeCommand(Guid EmployeeId) : IRequest<bool>;

    internal class DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.DeleteEmployeAsync(request.EmployeeId);
        }
    }

}

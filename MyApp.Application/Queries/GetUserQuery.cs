using MediatR;
using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application.Queries
{
    public record GetUserQuery() : IRequest<IEnumerable<User>>;

    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, IEnumerable<User>>
    {
        private readonly IExternaVendorRepository _repo;
        public GetUserQueryHandler(IExternaVendorRepository repo) => _repo = repo;

        public Task<IEnumerable<User>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        => _repo.GetUserData();
    }
}

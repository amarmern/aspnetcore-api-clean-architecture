using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Core.Models;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Queries
{
    // MyApp.Application/Queries/GetTodoDatatQuery.cs
    public record GetTodoDatatQuery() : IRequest<IEnumerable<TodoData>>;

    public class GetTodoDatatQueryHandler : IRequestHandler<GetTodoDatatQuery, IEnumerable<TodoData>>
    {
        private readonly IExternaVendorRepository _repo;
        public GetTodoDatatQueryHandler(IExternaVendorRepository repo) => _repo = repo;

        public Task<IEnumerable<TodoData>> Handle(GetTodoDatatQuery request, CancellationToken cancellationToken)
            => _repo.GetData();
    }

}

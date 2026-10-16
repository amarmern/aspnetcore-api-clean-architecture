// MyApp.Infrastructure/Repositories/ExternalVendorRepository.cs
using MyApp.Core.Models;

public class ExternalVendorRepository : IExternaVendorRepository
{
    private readonly ITodosHttpClientService _todos;
    public ExternalVendorRepository(ITodosHttpClientService todos) => _todos = todos;

    public Task<IEnumerable<TodoData>> GetData() => _todos.GetTodosAsync();
}
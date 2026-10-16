// MyApp.Infrastructure/Services/ITodosHttpClientService.cs
using MyApp.Core.Models;

public interface ITodosHttpClientService
{
    Task<IEnumerable<TodoData>> GetTodosAsync();
}
// MyApp.Infrastructure/Services/TodosHttpClientService.cs
using MyApp.Core.Models;

public interface IUserHttpClientService
{
    Task<IEnumerable<User>> GetUsersAsync();
}
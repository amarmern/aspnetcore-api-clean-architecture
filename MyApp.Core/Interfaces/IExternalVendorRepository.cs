// MyApp.Core/Interfaces/IExternalVendorRepository.cs
using MyApp.Core.Models;

public interface IExternaVendorRepository
{
    Task<IEnumerable<TodoData>> GetData();
    Task<IEnumerable<User>> GetUserData();
}
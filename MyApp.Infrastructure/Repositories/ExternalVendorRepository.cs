// MyApp.Infrastructure/Repositories/ExternalVendorRepository.cs
using MyApp.Core.Models;

public class ExternalVendorRepository(ITodosHttpClientService todos, IUserHttpClientService user) : IExternaVendorRepository
{
    //private readonly ITodosHttpClientService _todos;
    //private readonly IUserHttpClientService _user;

    //public ExternalVendorRepository(ITodosHttpClientService todos , IUserHttpClientService user)
    //{
    //    _todos = todos;
    //    _user = user;
    //}

   

    public async Task<IEnumerable<TodoData>> GetData() => await todos.GetTodosAsync();
    public async Task<IEnumerable<User>> GetUserData() => await user.GetUsersAsync();


}
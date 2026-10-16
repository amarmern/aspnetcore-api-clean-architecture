using MyApp.Core.Models;
using System.Net.Http.Json;

namespace MyApp.Infrastructure.Services
{
    public class UsersHttpClientService : IUserHttpClientService
    {
        private readonly HttpClient _httpClient;
        public UsersHttpClientService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<User>>("users");
        }
    }
}

// MyApp.Infrastructure/Services/TodosHttpClientService.cs
using MyApp.Core.Models;
using System.Net.Http.Json;

public class TodosHttpClientService : ITodosHttpClientService
{
    private readonly HttpClient _httpClient;
    public TodosHttpClientService(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<IEnumerable<TodoData>> GetTodosAsync()
    {
       //return await _httpClient.GetFromJsonAsync<IEnumerable<TodoData>>("https://jsonplaceholder.typicode.com/todos");
        return await _httpClient.GetFromJsonAsync<IEnumerable<TodoData>>("todos");
    }
}
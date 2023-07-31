public class TodoApiClient : ITodoApiClient
{
    private readonly HttpClient _httpClient;

    public TodoApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Todo>> GetTodosAsync()
    {
        var response = await _httpClient.GetAsync("/todos");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Todo>>(content);
    }

    public async Task<Todo> GetTodoByIdAsync(int id)
    {
        var response = await _httpClient.GetAsync($"/todos/{id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<Todo>(content);
    }
}

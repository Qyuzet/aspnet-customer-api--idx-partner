public interface ITodoApiClient
{
    Task<List<Todo>> GetTodosAsync();
    Task<Todo> GetTodoByIdAsync(int id);
}

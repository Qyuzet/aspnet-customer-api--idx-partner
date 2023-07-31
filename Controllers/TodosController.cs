using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

[Route("api/todos")]
[ApiController]
public class TodosController : ControllerBase
{
    private readonly ITodoApiClient _todoApiClient;

    public TodosController(ITodoApiClient todoApiClient)
    {
        _todoApiClient = todoApiClient;
    }

    [HttpGet]
    public async Task<IActionResult> GetTodosAsync()
    {
        var todos = await _todoApiClient.GetTodosAsync();
        return Ok(todos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTodoByIdAsync(int id)
    {
        var todo = await _todoApiClient.GetTodoByIdAsync(id);
        if (todo == null)
            return NotFound();

        return Ok(todo);
    }
}

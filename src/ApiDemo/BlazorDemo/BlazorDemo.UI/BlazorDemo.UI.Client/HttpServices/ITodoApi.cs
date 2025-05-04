using BlazorDemo.UI.Client.Models;
using Refit;

namespace BlazorDemo.UI.Client.HttpServices
{
    public interface ITodoApi
    {
        [Get("/api/todo")]
        Task<List<TodoItem>> GetAll();

        [Get("/api/todo/{id}")]
        Task<TodoItem> Get(int id);

        [Post("/api/todo")]
        Task<TodoItem> Create([Body] TodoItem item);
    }
}

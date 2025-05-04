using BlazorDemo.UI.Client.HttpServices;
using BlazorDemo.UI.Client.Models;
using Microsoft.AspNetCore.Components;
using Blazored.LocalStorage;
using Blazored.SessionStorage;

namespace BlazorDemo.UI.Client.Components
{
    public class TodoItemComponent: ComponentBase
    {
        public List<TodoItem>? Items => _items;

        private List<TodoItem>? _items;

        [Inject]
        private ITodoApi Service { get; set; } = default!;

        [Inject]
        private ILocalStorageService LocalStorage { get; set; } = default!;

        [Inject]
        private ISessionStorageService SessionStorage { get; set; } = default!;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SessionStorage.SetItemAsStringAsync("test", "test");
            await LocalStorage.SetItemAsStringAsync("test", "test");

            if (!firstRender)
                return;

            _items = await Service.GetAll();

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}

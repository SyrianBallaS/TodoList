using System;
using System.Collections.Generic;

namespace TodoList.Models
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> AllItems { get; }
        TodoItem GetItemById(int id);
        TodoItem AddItem(TodoItem item);
        bool TryDeleteItem(int id);
    }
}

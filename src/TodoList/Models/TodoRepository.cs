using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoList.Models
{

    public class TodoRepository : ITodoRepository
    {
        private readonly TodoDbContext _db;

        public TodoRepository(TodoDbContext db)
        {
            _db = db;
        }

        public IEnumerable<TodoItem> AllItems
        {
            get
            {
                return _db.TodoItems.AsEnumerable<TodoItem>();
            }
        }

        public TodoItem GetItemById(int id)
        {
            return _db.TodoItems.FirstOrDefault(x => x.Id == id);
        }

        public TodoItem AddItem(TodoItem item)
        {
            _db.TodoItems.Add(item);

            if (_db.SaveChanges() > 0)
            {
                return item;
            }

            return null;
        }

        public bool TryDeleteItem(int id)
        {
            var item = GetItemById(id);
            if (item != null)
            {
                _db.TodoItems.Remove(item);
                return _db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
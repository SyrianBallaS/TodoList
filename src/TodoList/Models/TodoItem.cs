using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public int Priority { get; set; }
    }

    public class TodoItemEditModel
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public int Priority { get; set; }
    }

}
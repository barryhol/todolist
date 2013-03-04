using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoListApp.Models
{
    public class ToDoItem
    {
        public int ToDoItemId { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
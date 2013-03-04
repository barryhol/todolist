﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ToDoListApp.Models
{
    public class ToDoDb : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
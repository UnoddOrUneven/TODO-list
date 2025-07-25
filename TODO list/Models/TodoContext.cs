﻿using Microsoft.EntityFrameworkCore;
using TODO_list.Models;

namespace TODO_list.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        // Models 
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Settings> Settings { get; set; }
    }
}

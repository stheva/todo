using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoList.Api.Models
{
    public class TodoListContext : DbContext
    {
        public TodoListContext() : base("name=TodoListContext")
        {
        }

        //public System.Data.Entity.DbSet<TodoList.Api.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<TodoList.Api.Models.Todo> Todos { get; set; }
    }
}

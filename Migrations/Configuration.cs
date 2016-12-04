namespace TodoList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TodoList.Api.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<TodoList.Api.Models.TodoListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TodoList.Api.Models.TodoListContext context)
        {
        //    context.Users.AddOrUpdate(x => x.Id,
        //new User() { Id = 1, Name = "Chuck Norris", EmailAddress = "chuck@chuck.chuck" },
        //new User() { Id = 2, Name = "Tony Soprano", EmailAddress = "tony@soprano.com" },
        //new User() { Id = 3, Name = "Erna Solberg", EmailAddress = "jernerna@norge.no" }
        //);

            context.Todos.AddOrUpdate(x => x.Id,
                new Todo()
                {
                    Id = 1,
                    Description = "Ringe Jean Claude",
                    Completed = false,
                    //UserId = 1
                },
                new Todo()
                {
                    Id = 2,
                    Description = "Lage middag",
                    Completed = false,
                    //UserId = 1
                },
                new Todo()
                {
                    Id = 3,
                    Description = "Fikse bilen",
                    Completed = false,
                    //UserId = 2
                },
                new Todo()
                {
                    Id = 4,
                    Description = "Bestille ferietur",
                    Completed = false,
                    //UserId = 2
                },
                new Todo()
                {
                    Id = 5,
                    Description = "Ro budsjettet i land",
                    Completed = false,
                    //UserId = 3
                },
                new Todo()
                {
                    Id = 6,
                    Description = "Bestille ferietur",
                    Completed = false,
                    //UserId = 3
                }
            );
        }
    }
}

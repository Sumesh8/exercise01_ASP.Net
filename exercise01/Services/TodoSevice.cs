using exercise01.Model;

namespace exercise01.Services
{
    public class TodoSevice
    {
        // Get Todos
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Complete the ASP.Net video 20",
                Description = "It has full ASP.Net basic videos",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.New

            };

            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Achive forex at 150 profit",
                Description = "Yoy have to complete 7 days",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                Status = TodoStatus.New

            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Complete design task 2",
                Description = "It is a beam and blance design task",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };

            todos.Add(todo3);

            return todos;
        }
    }
}

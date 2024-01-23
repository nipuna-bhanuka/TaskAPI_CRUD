using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoDBService : ITodoRepository
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();
        public List<Todo> AllTodos()
        {
            return _dbContext.Todos.ToList();
        }

        public Todo GetTodoById(int id)
        {
            return _dbContext.Todos.Find(id);
        }
    }
}

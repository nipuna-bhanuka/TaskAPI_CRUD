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

        public List<Todo> GetTodosByAuthorId(int authorId)
        {
            return _dbContext.Todos.Where(t => t.AuthorId == authorId).ToList();
        }
    }
}

//if check 2 parameters
// return _dbContext.Todos.FirstOrDefault(t=>t.Id == Id && t.authorId == authorId);
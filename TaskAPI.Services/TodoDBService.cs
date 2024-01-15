using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoDBService : ITodoRepository
    {
        private readonly TodoDbContext _dbContect = new TodoDbContext();
        public List<Todo> AllTodos()
        {
            return _dbContect.Todos.ToList();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();
        public Todo GetTodoById(int id);
        public List<Todo> GetTodosByAuthorId(int authorId);
        public Todo AddTodo(Todo todo);
        public void UpdateTodo(Todo todo);
        public void DeleteTodo(Todo todo);
    }
}

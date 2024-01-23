using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        public TodoController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            var myTodos = _todoService.AllTodos();
            return Ok(myTodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTasks(int id)
        {
            var myTodos = _todoService.AllTodos();
            myTodos = myTodos.Where(t => t.Id == id).ToList();
            return Ok(myTodos);
        }





    }
}

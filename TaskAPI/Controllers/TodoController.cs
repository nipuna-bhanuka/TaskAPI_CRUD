using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Dtos;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodoController(ITodoRepository repository, IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetTodos()
        {
            var myTodos = _todoService.AllTodos();
            var mapperTodos = _mapper.Map<ICollection<TodoDto>>(myTodos);
            return Ok(mapperTodos);
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<TodoDto> GetTodoById(int id)
        {
            var myTodo = _todoService.GetTodoById(id);
            if(myTodo == null)
            {
                return NotFound();
            }
            var mapperTodo = _mapper.Map<TodoDto>(myTodo);
            return Ok(mapperTodo);
        }

        [HttpGet("authorid/{id}")]  
        public ActionResult<ICollection<TodoDto>> GetTodosByAuthorId(int id)
        {
            var authorTodos = _todoService.GetTodosByAuthorId(id);
            if(authorTodos.Count == 0) 
            {
                return NotFound();
            }
            var mapperTods = _mapper.Map<TodoDto>(authorTodos);
            return Ok(mapperTods);

        }

        [HttpPost]
        public ActionResult<CreateTodoDto> AddTodo(CreateTodoDto todo)
        {
            var todoEntity = _mapper.Map<Todo>(todo);
            var addEntity = _todoService.AddTodo(todoEntity);

            var todoForReturn = _mapper.Map<TodoDto>(addEntity);

            return CreatedAtRoute("GetTodo", new {id= todoForReturn.Id }, todoForReturn);
        }

        [HttpPut("{todoid}")]
        public ActionResult UpdateTodo(int todoid,UpdateTodoDto todo)
        {
            var updatingTodo = _todoService.GetTodoById(todoid);
            if(updatingTodo is null)
            {
                return NotFound();
            }

            _mapper.Map(todo, updatingTodo);
            _todoService.UpdateTodo(updatingTodo);

            return NoContent();
        }

        [HttpDelete("{todoid}")]

        public ActionResult DeleteTodo(int todoid)
        {
            var deleteTodo = _todoService.GetTodoById(todoid);
            if(deleteTodo is null)
            {
                return BadRequest();
            }

            _todoService.DeleteTodo(deleteTodo);
            return NoContent();
        }

    }
}

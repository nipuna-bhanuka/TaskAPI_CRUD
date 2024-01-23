using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authors;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorService;

        public AuthorsController(IAuthorRepository repository)
        {
            _authorService = repository;
        }

        [HttpGet]
        public IActionResult GetAuthors() 
        {
            var authors = _authorService.AllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorbyId(int id)
        {
            var author = _authorService.AllAuthors().Where(t=>t.Id == id);
            return Ok(author);
        }
    }
}

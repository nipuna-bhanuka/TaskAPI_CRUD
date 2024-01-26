using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Dtos;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorService;
        private readonly IMapper _mapper;

        public AuthorsController(IAuthorRepository repository, IMapper mapper)
        {
            _authorService = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors(string? job, string? search)
        {
            var authors = _authorService.AllAuthors(job, search);

            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);
            return Ok(mappedAuthors);
        }

        [HttpGet("{id}", Name="GetAuthor")]
        public IActionResult GetAuthorbyId(int id)
        {
            var author = _authorService.GetAuthorById(id);
            if (author is null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author);
            return Ok(mappedAuthor);
        }

        [HttpPost]
        public ActionResult<CreateAuthorDto> AddAuthor(CreateAuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            var addEntity = _authorService.AddAuthor(authorEntity);

            var authorForReturn = _mapper.Map<AuthorDto>(addEntity);

            return CreatedAtRoute("GetAuthor", new { id = authorForReturn.Id }, authorForReturn);
        }

        [HttpPut ("{authorid}")]
        public ActionResult UpdateAuthor(int authorid,UpdateAuthorDto author)
        {

            return NoContent();
        }

        [HttpDelete("{authorid}")]
        public ActionResult DeleteAuthor(int authorid)
        {
            var deleteAuthor = _authorService.GetAuthorById(authorid);
            if (deleteAuthor is null)
            {
                return NotFound();
            }

            _authorService.DeleteAuthor(deleteAuthor);
            return NoContent();
        }

    }
}

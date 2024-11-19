using hoda_elbadry.Dto;
using hoda_elbadry.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hoda_elbadry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepo _bookRepo;

        public BooksController(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok( _bookRepo.getAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetBook(int id)
        {
            return Ok(_bookRepo.getById(id));
        }

        [HttpPost]
        public IActionResult CreateBook(CreateBookDto dto)
        {
            _bookRepo.Add(dto);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBook(BookDto dto)
        {
            _bookRepo.Update(dto);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            _bookRepo.Delete(id);
            return Ok();
        }
    }
}

using BookBase.Common.Models;
using BookBase.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BookBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet(nameof(GetAllBooks))]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return Ok(_bookService.GetAllBooks());
        }
    }
}

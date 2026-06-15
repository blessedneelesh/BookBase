using BookBase.Common.Models;
using BookBase.Repository.Interface;
using BookBase.Repository.Models.Dto;
using BookBase.Services.Abstractions;

namespace BookBase.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<List<BookDto>> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
    }
}

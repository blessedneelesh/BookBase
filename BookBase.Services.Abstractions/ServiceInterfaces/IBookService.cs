using BookBase.Repository.Models.Dto;

namespace BookBase.Services.Abstractions
{
    public interface IBookService
    {
        Task<List<BookDto>> GetAllBooks();
    }
}

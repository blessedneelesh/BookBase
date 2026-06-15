using BookBase.Common.Models;
using BookBase.Repository.Models.Dto;

namespace BookBase.Repository.Interface
{
    public interface IBookRepository
    {
        Task<List<BookDto>> GetAllBooks();
    }
}

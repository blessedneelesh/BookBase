using BookBase.Repository.Context;
using BookBase.Repository.Interface;
using BookBase.Repository.Models.Dto;
using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace BookBase.Repository.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IRepositoryContext _repositoryContext;

        public BookRepository(IRepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task<List<BookDto>> GetAllBooks()
        {
            using IDbConnection connection = _repositoryContext.GetDatabaseConnection();

            string sql = @"SELECT * FROM book";
            var books = await connection.QueryAsync<BookDto>(sql); // Dapper extension method

            return books.ToList();
        }
    }
}

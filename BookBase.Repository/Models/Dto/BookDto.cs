using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBase.Repository.Models.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string? Subtitle { get; set; }
        public int? Year { get; set; }
        public string? Emoji { get; set; }
        public string? Description { get; set; }
        public string? BookSummary { get; set; }
        public string? Language { get; set; }
    }
}

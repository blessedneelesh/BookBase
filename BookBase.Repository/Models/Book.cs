namespace BookBase.Common.Models
{
    public class Book
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

        public Author Author { get; set; } = null!;

        public Genre Genre { get; set; } = null!;
    }
}

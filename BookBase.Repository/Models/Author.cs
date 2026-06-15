using System.ComponentModel.DataAnnotations;

namespace BookBase.Common.Models
{
    public class Author
    {
        public int Id { get; set; }

        public required string Name { get; set; } = string.Empty;

        public string? Nationality { get; set; }

        public int? BirthYear { get; set; }
    }
}

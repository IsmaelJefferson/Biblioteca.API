using Biblioteca.Domain.Enums;

namespace Biblioteca.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Category { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public BookStatus Status { get; set; }

        public Book() { }

        public Book(string title, string author, string category, DateTime releaseDate, DateTime arrivalDate, BookStatus status)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            Category = category;
            ReleaseDate = releaseDate;
            ArrivalDate = arrivalDate;
            Status = status;
        }
    }
}
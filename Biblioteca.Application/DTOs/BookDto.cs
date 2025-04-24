using System.ComponentModel.DataAnnotations;

namespace Library.Application.DTOs
{
    public class BookDto
    {
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Release date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Release date must be a valid date.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Arrival date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Arrival date must be a valid date.")]
        public DateTime ArrivalDate { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public string Status { get; set; }
    }
}
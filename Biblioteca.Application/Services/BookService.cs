using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Enums;
using Library.Application.DTOs;
using Library.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace Library.Application.Services
{
    public class BookService
    {
        private readonly IBookRepository _repository;
        private readonly ILogger<BookService> _logger;

        public BookService(IBookRepository repository, ILogger<BookService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            _logger.LogInformation("Retrieving all books.");
            return await _repository.GetAllAsync();
        }

        public async Task<Book?> GetByIdAsync(Guid id)
        {
            var book = await _repository.GetByIdAsync(id);
            if (book == null)
            {
                _logger.LogWarning("Book with ID {BookId} not found.", id);
            }
            return book;
        }

        public async Task<Book> CreateAsync(BookDto dto)
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = dto.Title,
                Author = dto.Author,
                Category = dto.Category,
                ReleaseDate = dto.ReleaseDate,
                ArrivalDate = dto.ArrivalDate,
                Status = (BookStatus)Enum.Parse(typeof(BookStatus), dto.Status)
            };

            await _repository.AddAsync(book);
            _logger.LogInformation("Book created: {Title} ({Id})", book.Title, book.Id);
            return book;
        }

        public async Task<bool> UpdateAsync(Guid id, BookDto dto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
            {
                _logger.LogWarning("Attempt to update non-existent book with ID {BookId}.", id);
                return false;
            }

            existing.Title = dto.Title;
            existing.Author = dto.Author;
            existing.Category = dto.Category;
            existing.ReleaseDate = dto.ReleaseDate;
            existing.Status = (BookStatus)Enum.Parse(typeof(BookStatus), dto.Status);;

            await _repository.UpdateAsync(existing);
            _logger.LogInformation("Book updated: {Title} ({Id})", existing.Title, existing.Id);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
            {
                _logger.LogWarning("Attempt to delete non-existent book with ID {BookId}.", id);
                return false;
            }

            await _repository.DeleteAsync(existing);
            _logger.LogInformation("Book deleted: {Title} ({Id})", existing.Title, existing.Id);
            return true;
        }
    }
}

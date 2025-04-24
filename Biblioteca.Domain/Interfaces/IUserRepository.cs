using Biblioteca.Domain.Entities;

namespace Biblioteca.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> ExistsByUsernameAsync(string username);
        Task<User?> GetByUsernameAsync(string username);
        Task CreateAsync(User user);
    }
}
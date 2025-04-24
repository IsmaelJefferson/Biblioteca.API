using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public string Role { get; set; } = "User";

        public byte[] PasswordSalt { get; set; }

    }
}
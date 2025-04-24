using Biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(u => u.Id)
                    .HasDefaultValueSql("NEWSEQUENTIALID()");


            builder.Property(u => u.Username)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.PasswordHash)
                   .IsRequired();

            builder.Property(u => u.Role)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(u => u.PasswordSalt)
                   .IsRequired();
                   
            builder.HasIndex(u => u.Username).IsUnique();
        }
    }
}
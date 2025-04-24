using Biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(b => b.Author)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(b => b.Category)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(b => b.ReleaseDate)
                   .IsRequired();

            builder.Property(b => b.ArrivalDate)
                   .IsRequired();

            builder.Property(b => b.Status)
                   .IsRequired();
        }
    }
}
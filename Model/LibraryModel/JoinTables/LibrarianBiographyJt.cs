using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.LibraryModel.Books;
using Model.LibraryModel.Persons;

namespace Model.LibraryModel.JoinTables;

public class LibrarianBiographyJt
{
    public int BiographyId { get; set; }
    public BiographyEntity Biography { get; set; } = null!;
    public int AuthorId { get; set; }
    public AuthorEntity Author { get; set; } = null!;
}

public class LibrarianBiographyJtConfiguration : IEntityTypeConfiguration<LibrarianBiographyJt>
{
    public void Configure(EntityTypeBuilder<LibrarianBiographyJt> builder)
    {
        builder.ToTable("LibrarianBiographyJt");
        builder.HasKey(e => new { e.BiographyId, e.AuthorId });
        builder.HasOne(e => e.Biography).WithMany().HasForeignKey(e => e.BiographyId);
        builder.HasOne(e => e.Author).WithMany().HasForeignKey(e => e.AuthorId);
    }
}
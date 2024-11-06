using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.LibraryModel.Persons;

namespace Model.LibraryModel.Books;

public class BookEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int AuthorId { get; set; }
    public AuthorEntity Author { get; set; } = null!;
    public DateTime PublishedDate { get; set; }
    public string ISBN { get; set; } = null!;
    public int AvailableCopies { get; set; }
}

public class BookEntityConfiguration : IEntityTypeConfiguration<BookEntity>
{
    public void Configure(EntityTypeBuilder<BookEntity> builder)
    {
        builder.ToTable("Books");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Title)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(e => e.PublishedDate)
            .IsRequired();
        builder.Property(e => e.ISBN)
            .IsFixedLength()
            .HasMaxLength(13)
            .IsRequired();
        builder.Property(e => e.AvailableCopies)
            .IsRequired();
        builder.HasOne(e => e.Author)
            .WithMany()
            .HasForeignKey(e => e.AuthorId);
        builder.HasDiscriminator<string>("BookType")
            .HasValue<BookEntity>("Book")
            .HasValue<BiographyEntity>("Biography")
            .HasValue<FantasyEntity>("Fantasy")
            .HasValue<ScienceFictionEntity>("ScienceFiction")
            .HasValue<NovelEntity>("Novel")
            .HasValue<TextbookEntity>("Textbook")
            .HasValue<MysteryEntity>("Mystery")
            .HasValue<TextbookEntity>("Textbook")
            .HasValue<NonFictionEntity>("NonFiction");
    }
}
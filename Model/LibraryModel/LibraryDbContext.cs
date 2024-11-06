using Microsoft.EntityFrameworkCore;
using Model.LibraryModel.Books;
using Model.LibraryModel.Persons;

namespace Model.LibraryModel;

public class LibraryDbContext(DbContextOptions<LibraryDbContext> options) : DbContext(options)
{
    public DbSet<BookEntity> Books { get; set; }
    public DbSet<BiographyEntity> Biographies { get; set; }
    public DbSet<FantasyEntity> Fantasies { get; set; }
    public DbSet<MysteryEntity> Mysteries { get; set; }
    public DbSet<ScienceFictionEntity> ScienceFictions { get; set; }
    public DbSet<NonFictionEntity> NonFictions { get; set; }
    public DbSet<NovelEntity> Novels { get; set; }
    public DbSet<TextbookEntity> Textbooks { get; set; }

    public DbSet<PersonEntity> Persons { get; set; }
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<LibrarianEntity> Librarians { get; set; }
    public DbSet<AuthorEntity> Authors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
    }
}
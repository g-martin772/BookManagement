using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.LibraryModel.JoinTables;

namespace Model.LibraryModel.Persons;

public class LibrarianEntity : PersonEntity
{

}

public class LibrarianEntityConfiguration : IEntityTypeConfiguration<LibrarianEntity>
{
    public void Configure(EntityTypeBuilder<LibrarianEntity> builder)
    {
        builder.ToTable("Librarians");
    }
}
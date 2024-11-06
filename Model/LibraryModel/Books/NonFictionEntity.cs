using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.LibraryModel.Books;

public class NonFictionEntity : BookEntity
{

}

public class NonFictionEntityConfiguration : IEntityTypeConfiguration<NonFictionEntity>
{
    public void Configure(EntityTypeBuilder<NonFictionEntity> builder)
    {
        builder.ToTable("Books");
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.LibraryModel.Books;

public class BiographyEntity : BookEntity
{

}

public class BiographyEntityConfiguration : IEntityTypeConfiguration<BiographyEntity>
{
    public void Configure(EntityTypeBuilder<BiographyEntity> builder)
    {
        builder.ToTable("Books");
    }
}
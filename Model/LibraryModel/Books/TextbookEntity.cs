using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.LibraryModel.Books;

public class TextbookEntity : BookEntity
{
    
}

public class TextbookEntityConfiguration : IEntityTypeConfiguration<TextbookEntity>
{
    public void Configure(EntityTypeBuilder<TextbookEntity> builder)
    {
        builder.ToTable("Books");
    }
}
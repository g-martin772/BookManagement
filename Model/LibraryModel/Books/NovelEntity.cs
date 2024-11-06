using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.LibraryModel.Books;

public class NovelEntity : BookEntity
{
    
}

public class NovelEntityConfiguration : IEntityTypeConfiguration<NovelEntity>
{
    public void Configure(EntityTypeBuilder<NovelEntity> builder)
    {
        builder.ToTable("Books");
    }
}
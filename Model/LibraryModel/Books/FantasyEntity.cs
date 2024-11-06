using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.LibraryModel.Books;

public class FantasyEntity : BookEntity
{
    
}

public class FantasyEntityConfiguration : IEntityTypeConfiguration<FantasyEntity>
{
    public void Configure(EntityTypeBuilder<FantasyEntity> builder)
    {
        builder.ToTable("Books");
    }
}
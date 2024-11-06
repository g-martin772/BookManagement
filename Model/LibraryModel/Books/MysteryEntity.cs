using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.LibraryModel.Books;

public class MysteryEntity : BookEntity
{
    
}

public class MysteryEntityConfiguration : IEntityTypeConfiguration<MysteryEntity>
{
    public void Configure(EntityTypeBuilder<MysteryEntity> builder)
    {
        builder.ToTable("Books");
    }
}
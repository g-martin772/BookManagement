using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.LibraryModel.Books;

public class ScienceFictionEntity : BookEntity
{
    
}

public class ScienceFictionEntityConfiguration : IEntityTypeConfiguration<ScienceFictionEntity>
{
    public void Configure(EntityTypeBuilder<ScienceFictionEntity> builder)
    {
        builder.ToTable("Books");
    }
}
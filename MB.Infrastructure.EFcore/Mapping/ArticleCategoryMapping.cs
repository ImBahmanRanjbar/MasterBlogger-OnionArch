using MB.Domain.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.EFcore.Mapping;

public class ArticleCategoryMapping:IEntityTypeConfiguration<ArticleCategory>
{
    public void Configure(EntityTypeBuilder<ArticleCategory> builder)
    {
        builder.ToTable("ArticleCategories");
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Title);
        builder.Property(p => p.CreationDate);
        builder.Property(p => p.IsDeleted);
    }
}
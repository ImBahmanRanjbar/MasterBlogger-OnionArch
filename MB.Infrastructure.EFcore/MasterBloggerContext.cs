using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFcore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFcore;

public class MasterBloggerContext:DbContext
{
    public DbSet<ArticleCategory> ArticleCategories { get; set; }

    public MasterBloggerContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
        base.OnModelCreating(modelBuilder);
    }
} 
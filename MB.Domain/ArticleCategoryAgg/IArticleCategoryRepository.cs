namespace MB.Domain.ArticleCategoryAgg;

public interface IArticleCategoryRepository
{
    List<ArticleCategory> GetAll();
    void Create(ArticleCategory entity);
}
using MB.Application.Contracts.ArticleCategory;

namespace MB.Applicaton;

public class ArticleCategoryApplication:IArticleCategoryApplication
{
    public List<ArticleCategoryViewModel> List()
    {
        return new List<ArticleCategoryViewModel>();
    }
}

using System.Globalization;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;

namespace MB.Applicaton;

public class ArticleCategoryApplication : IArticleCategoryApplication
{
    private readonly IArticleCategoryRepository _articleCategoryRepository;

    public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
    {
        _articleCategoryRepository = articleCategoryRepository;
    }

    public List<ArticleCategoryViewModel> List()
    {
        var articleCategories = _articleCategoryRepository.GetAll();
        var result = new List<ArticleCategoryViewModel>();
        foreach (var articleCatrgory in articleCategories)
            result.Add(new ArticleCategoryViewModel
            {
                ID = articleCatrgory.ID,
                Title = articleCatrgory.Title,
                IsDeleted = articleCatrgory.IsDeleted,
                CreationDate = articleCatrgory.CreationDate.ToString(CultureInfo.InvariantCulture)
            });

        return result;
    }
}
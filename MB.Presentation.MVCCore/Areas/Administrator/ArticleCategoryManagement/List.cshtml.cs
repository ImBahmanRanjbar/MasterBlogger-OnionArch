using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.ArticleCategoryManagement
{
    
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication=articleCategoryApplication;
        }
        public void OnGet()
        {
            this.ArticleCategories = _articleCategoryApplication.List(); 
        }
    }
}

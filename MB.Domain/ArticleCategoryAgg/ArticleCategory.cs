namespace MB.Domain.ArticleCategoryAgg;

public class ArticleCategory
{
    public long ID { get;private set; }
    public string Title { get; private set; }
    public bool IsDeleted { get; private set; } 
    public DateTime CreationDate { get; private set; } 

    public ArticleCategory(string title)
    {
        Title = title;
        IsDeleted = false;
        CreationDate = DateTime.Now;

    }
    
}
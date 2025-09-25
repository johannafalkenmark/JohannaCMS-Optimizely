using JohannaCMS.Models.Pages;

namespace JohannaCMS.Models.ViewModels;

public class ArticlePageViewModel : PageViewModel<ArticlePage>
{
    public ArticlePageViewModel(ArticlePage currentPage) : base(currentPage)
    {
    }
}
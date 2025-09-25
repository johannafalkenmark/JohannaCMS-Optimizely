using JohannaCMS.Models.Pages;
using JohannaCMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JohannaCMS.Controllers;

public class ArticlePageController : PageControllerBase<ArticlePage>
{
    public IActionResult Index(ArticlePage currentPage)
    {
        var model = new ArticlePageViewModel(currentPage);

        return View(model);
    }
}
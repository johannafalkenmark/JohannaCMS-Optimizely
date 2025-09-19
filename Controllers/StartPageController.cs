using JohannaCMS.Models.Pages;
using JohannaCMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JohannaCMS.Controllers;

public class StartPageController : PageControllerBase<StartPage>
{
    public IActionResult Index(StartPage currentPage)
    {
        var model = new StartPageViewModel(currentPage);

        return View(model);
    }
}
using EPiServer.Web;
using JohannaCMS.Models.Pages;
using JohannaCMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JohannaCMS.Components.Carousel;

public class CarouselViewComponent : ViewComponent
{
    private readonly IContentLoader _contentLoader;

    public CarouselViewComponent(IContentLoader contentLoader)
    {
        _contentLoader = contentLoader;
    }

    public IViewComponentResult Invoke(IContentLoader contentLoader)
    {
        var startPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage);
        var model = new CarouselViewModel();

        if (startPage.Carousel != null)
        {
            foreach (var item in startPage.Carousel.FilteredItems.Select(x => x.LoadContent()))
            {
                if (item is CarouselPage page)
                {
                    model.Pages.Add(page);
                }
            }
        }

        return View("~/views/shared/carousel.cshtml", model);
    }
}
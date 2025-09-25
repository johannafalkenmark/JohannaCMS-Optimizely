using EPiServer.Web.Mvc;
using JohannaCMS.Models.Blocks;
using JohannaCMS.Models.Pages;
using JohannaCMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JohannaCMS.BlocksCarousel.Carousel;

public class CarouselBlockComponent : AsyncBlockComponent<CarouselBlock>
{
    protected override async Task<IViewComponentResult> InvokeComponentAsync(CarouselBlock currentContent)
    {
        var model = new CarouselViewModel();

        if (currentContent.Carousel != null)
        {
            foreach (var item in currentContent.Carousel.FilteredItems.Select(x => x.LoadContent()))
            {
                if (item is CarouselPage page)
                {
                    model.Pages.Add(page);
                }
            }
        }

        return await Task.FromResult(View("~/views/shared/carousel.cshtml", model));
    }
}

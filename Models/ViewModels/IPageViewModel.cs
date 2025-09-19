using JohannaCMS.Models.Pages;

namespace JohannaCMS.Models.ViewModels;

public interface IPageViewModel<out T> where T : SitePageData
{
    T CurrentPage { get; }

    LayoutModel Layout { get; set; }
}

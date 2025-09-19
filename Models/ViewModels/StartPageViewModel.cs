using JohannaCMS.Models.Pages;

namespace JohannaCMS.Models.ViewModels;

public class StartPageViewModel : PageViewModel<StartPage>
{
    public StartPageViewModel(StartPage currentPage) : base(currentPage)
    {
    }
}
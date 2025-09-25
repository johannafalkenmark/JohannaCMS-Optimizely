using EPiServer.Web.Mvc;
using JohannaCMS.Models.Pages;

namespace JohannaCMS.Controllers;

public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
{
}
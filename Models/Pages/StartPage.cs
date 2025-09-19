using EPiServer.Web;
using JohannaCMS.Business;
using System.ComponentModel.DataAnnotations;

namespace JohannaCMS.Models.Pages;

[ContentType(
        GUID = "C23681AB-CDDD-4200-BB5C-A473ACD2077A",
        GroupName = Globals.GroupNames.Specialized
    )]

[ImageUrl("/Images/gang.jpg")]
public class StartPage : SitePageData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10
    )]
    [CultureSpecific]
    public virtual string Heading { get; set; } = string.Empty;

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 20
    )]
    [CultureSpecific]
    [UIHint(UIHint.Textarea)]
    public virtual string Preamble { get; set; } = string.Empty;

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 30
    )]
    [CultureSpecific]
    [ScaffoldColumn(false)]
    public virtual XhtmlString MainBody { get; set; }

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 40
    )]
    [UIHint(UIHint.Image)]
    public virtual ContentReference Image { get; set; }
}

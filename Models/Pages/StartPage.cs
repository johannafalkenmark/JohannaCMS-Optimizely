using EPiServer.Web;
using JohannaCMS.Business;
using JohannaCMS.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace JohannaCMS.Models.Pages;

[ContentType(
       GUID = "F74E27B8-A1CF-4439-99D0-EB3234C41A48", 
       GroupName = Globals.GroupNames.Specialized
   )]

[ImageUrl("/pages/CMS-icon-page-02.png")]
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
    //[ScaffoldColumn(false)] om man vill dölja ngt från redaktören
    public virtual XhtmlString MainBody { get; set; }

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 40
    )]
    [UIHint(UIHint.Image)]
    public virtual ContentReference Image { get; set; }

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 50
    )]
    [CultureSpecific]
    [AllowedTypes(typeof(CarouselPage), typeof(CarouselBlock))]
    public virtual ContentArea Carousel { get; set; }
}

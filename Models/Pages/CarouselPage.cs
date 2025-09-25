using JohannaCMS.Business;
using JohannaCMS.Business.Attributes;
using JohannaCMS.Business.Enums;
using System.ComponentModel.DataAnnotations;

namespace JohannaCMS.Models.Pages;

[ContentType(
        GUID = "1C582002-773F-4A36-971A-2D45CAE389A5", 
        GroupName = Globals.GroupNames.Specialized,
        DisplayName = "Carousel",
        Description = "This is a carousel template"
    )]
[ContentIcon(ContentIcon.ObjectImage)]
public class CarouselPage : SitePageData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10
    )]
    public virtual ContentReference Image { get; set; }
}

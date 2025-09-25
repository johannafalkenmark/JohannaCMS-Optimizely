using JohannaCMS.Business;
using JohannaCMS.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace JohannaCMS.Models.Blocks;

[ContentType(
    GroupName = Globals.GroupNames.Specialized,
       GUID = "49457F46-E6AB-4574-A2B1-BA37B91B72D4",
       DisplayName = "Carousel",
    Description = "This is a C template"
   )]
public class CarouselBlock : BlockData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10
    )]
    [AllowedTypes(typeof(CarouselPage))]
    public virtual ContentArea Carousel { get; set; }
}
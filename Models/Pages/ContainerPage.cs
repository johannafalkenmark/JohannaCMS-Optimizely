using JohannaCMS.Business;
using JohannaCMS.Business.Attributes;
using JohannaCMS.Business.Enums;
using JohannaCMS.Models.Blocks;
using JohannaCMS.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace JohannaCMS.Models.Pages;

[ContentType(
       GUID = "70195022-6CC7-4C2C-8A49-CA637FD6DAF3",
       GroupName = Globals.GroupNames.Specialized,
       DisplayName = "Container"
   )]
[AvailableContentTypes(
       Availability.Specific,
       Include = [typeof(CarouselPage), typeof(CarouselBlock)] //La till carouselBlock
          

   )]
[ContentIcon(ContentIcon.Folder)]
public class ContainerPage : PageData, IContainerPage
{
}

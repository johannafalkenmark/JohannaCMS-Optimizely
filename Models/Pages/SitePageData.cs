using JohannaCMS.Business;
using System.ComponentModel.DataAnnotations;

namespace JohannaCMS.Models.Pages;

public class SitePageData : PageData
{
    [Display(
        GroupName = Globals.GroupNames.MetaData,
        Order = 120
    )]
    [CultureSpecific]
    public virtual string MetaDescription
    {
        get
        {
            var metaDescription = this.GetPropertyValue(p => p.MetaDescription);

            return !string.IsNullOrWhiteSpace(metaDescription) ? metaDescription : Name;
        }
        set => this.SetPropertyValue(p => p.MetaDescription, value);
    }
}

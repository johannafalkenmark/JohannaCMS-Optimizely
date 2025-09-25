using JohannaCMS.Business.Enums;

namespace JohannaCMS.Business.Attributes;

public class ContentIconAttribute : Attribute
{
    public ContentIcon Icon { get; set; }

    public ContentIconAttribute(ContentIcon icon)
    {
        Icon = icon;
    }
}

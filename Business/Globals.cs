using System.ComponentModel.DataAnnotations;

namespace JohannaCMS.Business;

public class Globals
{
    [GroupDefinitions]
    public static class GroupNames
    {
        [Display(
            Name = "Metadata",
            Order = 40
            )]
        public const string MetaData = "Metadata";

        [Display(
           Name = "Spezialized",
           Order = 90
           )]
        public const string Specialized = "Spezialized";
    }
}

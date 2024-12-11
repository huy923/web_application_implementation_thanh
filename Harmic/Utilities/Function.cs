using Microsoft.AspNetCore.SignalR;
using Mono.TextTemplating;

namespace Harmic.Utilities
{
    public class Function
    {
        public static string TitleSlugGenerationAlias(string title)
        {
            return SlugGenerator.SlugGenerator.GenerateSlug(title);
        }
    }
}

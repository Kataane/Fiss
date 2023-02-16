using System.Globalization;

namespace Fiss.Extensions;

internal static class StringExtensions
{
    public static string ToPascalCase(this string? @string)
    {
        var normalize = @string.ToLower().Replace("_", " ");

        var textInfo = new CultureInfo("en-US", false).TextInfo;
        var withTitleCase = textInfo.ToTitleCase(normalize);

        return withTitleCase.Replace(" ", "");
    }
}

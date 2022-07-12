namespace Fiss.Extensions;

public static class StringExtensions
{
    public static string ToPascalCase(this string @string)
    {
        var normalize = @string.ToLower().Replace("_", " ");

        var textInfo = new CultureInfo("en-US", false).TextInfo;
        var withTitleCase = textInfo.ToTitleCase(normalize);

        return withTitleCase.Replace(" ", "");
    }

    public static bool ContainsWithIgnoreCase(this string source, string @string)
    {
        return source.IndexOf(@string, StringComparison.CurrentCultureIgnoreCase) > 0;
    }

}

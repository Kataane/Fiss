namespace Fiss;

internal static class Constants
{
    public const string Host = "https://iss.moex.com/iss";
    public const string Cursor = "cursor";
    public const string Data = "data";
    public static string Columns = "columns";
    public static string Metadata = "metadata";

    public static string CharsetInfo = "charsetinfo";

    public static string IssJson = "iss.json";
    public static string Extended = "extended";

    public const string Limit = "limit";
    public const string Start = "start";

    public const char Dot = '.';
    public const char Ampersand = '&';
    public const char Slash = '/';
    public const char Question = '?';
    public new const char Equals = '=';
    public const char Underscore = '_';
    public const char Space = ' ';

    // 1 for Ampersand or Question;
    public static readonly int LimitQuerySize = (1 + Limit + Equals).Length;
    public static readonly int StartQuerySize = (1 + Start + Equals).Length;
}
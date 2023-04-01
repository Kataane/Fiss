namespace Fiss;

internal static class Constants
{
    public const string Host = "https://iss.moex.com/iss";
    public const string Cursor = "cursor";
    public const string Data = "data";
    public const string Columns = "columns";
    public const string Metadata = "metadata";

    public const string CharsetInfo = "charsetinfo";

    public const string IssJson = "iss.json";
    public const string Extended = "extended";

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
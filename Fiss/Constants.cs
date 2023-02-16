
namespace Fiss;

internal static class Constants
{
    public static string Host => "https://iss.moex.com/iss";
    public static string Cursor => ".cursor";
    public static string Data => "data";

    public static ReadOnlySpan<char> Limit => "limit";
    public static ReadOnlySpan<char> Start => "start";

    public static char Dot => '.';
    public static char Ampersand => '&';
    public static char Slash => '/';
    public static char Question => '?';
    public new static char Equals => '=';

    public const int MaxPathCount = 100;
}
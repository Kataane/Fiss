namespace Fiss.Extensions;

public  static class EnumExtensions
{
    public static string GetDescription(this Enum @enum)
    {
        var field = @enum.GetType().GetField(@enum.ToString());
        var attributes = field?.GetCustomAttributes(
            typeof(DescriptionAttribute), false) as DescriptionAttribute[];
        if (attributes is null || attributes.Length == 0) throw new Exception("Enum dosnt have description");
        return attributes[0].Description;
    }
}
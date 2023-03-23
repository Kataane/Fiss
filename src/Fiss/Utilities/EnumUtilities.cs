using System.ComponentModel;
using System.Reflection;

namespace Fiss;

/// <summary>
/// Provides description for <typeparamref name="T"/> enum.
/// </summary>
/// <typeparam name="T">The type of the enum.</typeparam>
internal static class EnumUtilities<T> where T : Enum
{
    /// <summary>
    /// Gets the description for the specified enum value, or the enum value's name if no description is found.
    /// </summary>
    /// <param name="value">The enum value to get the description for.</param>
    /// <returns>The description for the specified enum value, or the enum value's name if no description is found.</returns>
    public static string GetDescription(T? value)
    {
        if (value is null) return string.Empty;

        // Get the description from the DescriptionAttribute, or fall back to the value's name
        var field = value.GetType().GetField(value.ToString());
        var attribute = field?.GetCustomAttribute<DescriptionAttribute>();
        return attribute != null ? attribute.Description : value.ToString();
    }
}
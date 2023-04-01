#pragma warning disable CS8777

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Fiss.Exceptions;

/// <summary>
///     Represents an exception that is thrown when an argument fails validation.
/// </summary>
internal static class FissArgumentException
{
    /// <summary>
    ///     Throws an exception if <paramref name="value1" /> is greater than <paramref name="value2" />.
    /// </summary>
    /// <param name="value1">The first value to compare.</param>
    /// <param name="value2">The second value to compare.</param>
    /// <param name="value1ParamName">The name of the parameter <paramref name="value1" />.</param>
    /// <param name="value2ParamName">The name of the parameter <paramref name="value2" />.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when <paramref name="value1" /> is greater than <paramref name="value2" />.
    /// </exception>
    public static void ThrowIfMoreThan(
        [NotNull] int? value1, [NotNull] int? value2,
        [CallerArgumentExpression(nameof(value1))]
        string? value1ParamName = null,
        [CallerArgumentExpression(nameof(value2))]
        string? value2ParamName = null)
    {
        if (value1 > value2)
        {
            ThrowMoreThan(value1, value2, value1ParamName, value2ParamName);
        }
    }

    /// <summary>
    ///     Throws an exception if <paramref name="value" /> is less than zero.
    /// </summary>
    /// <param name="value">The value to check.</param>
    /// <param name="paramName">The name of the parameter <paramref name="value" />.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when <paramref name="value" /> is less than zero.
    /// </exception>
    public static void ThrowIfLessZero(
        [NotNull] int? value,
        [CallerArgumentExpression(nameof(value))]
        string? paramName = null)
    {
        if (value < 0)
        {
            ThrowValueLessZero(paramName);
        }
    }

    /// <summary>
    ///     Throws an exception indicating that <paramref name="value1" /> is greater than <paramref name="value2" />.
    /// </summary>
    /// <param name="value1">The first value that is greater than the second.</param>
    /// <param name="value2">The second value that is less than the first.</param>
    /// <param name="paramName">The name of the parameter <paramref name="value1" />.</param>
    /// <param name="compareParamName">The name of the parameter <paramref name="value2" />.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown with a message indicating that <paramref name="value1" /> is greater than <paramref name="value2" />.
    /// </exception>
    [DoesNotReturn]
    private static void ThrowMoreThan(int? value1, int? value2, string? paramName, string? compareParamName)
    {
        throw new ArgumentOutOfRangeException(paramName, $"The {paramName} value {value1} cannot be more than {compareParamName} value {value2}.");
    }

    /// <summary>
    ///     Throws an exception indicating that <paramref name="paramName" /> value is less than zero.
    /// </summary>
    /// <param name="paramName">The name of the parameter with the value less than zero.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown with a message indicating that the value for <paramref name="paramName" /> cannot be less than zero.
    /// </exception>
    [DoesNotReturn]
    private static void ThrowValueLessZero(string? paramName)
    {
        throw new ArgumentOutOfRangeException(paramName, $"The {paramName} value cannot be less than 0.");
    }
}

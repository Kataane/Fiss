using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Fiss.Exceptions;

internal class FissArgumentException
{
    public static void ThrowIfMoreThan(
        [NotNull] int? value1, [NotNull] int? value2, 
        [CallerArgumentExpression("value1")] string? value1ParamName = null, 
        [CallerArgumentExpression("value2")] string? value2ParamName = null)
    {
        if (value1 > value2)
        {
            ThrowMoreThan(value1, value2,value1ParamName, value2ParamName);
        }
    }

    public static void ThrowIfLessZero([NotNull] int? argument, [CallerArgumentExpression("argument")] string? paramName = null)
    {
        if (argument < 0)
        {
            ThrowValueLessZero(paramName);
        }
    }

    [DoesNotReturn]
    private static void ThrowMoreThan(int? value1, int? value2, string? paramName, string? compareParamName)
    {
        throw new ArgumentException($"The {paramName} value {value1} cannot be more than {compareParamName} value {value2}.");
    }

    [DoesNotReturn]
    private static void ThrowValueLessZero(string? paramName)
    {
        throw new ArgumentException($"The {paramName} value cannot be less than 0.");
    }
}
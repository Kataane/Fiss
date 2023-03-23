using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Fiss;

internal class StringUtilities
{
    [SkipLocalsInit]
    public static string ToPascalCaseInvariant(ref ReadOnlySpan<char> s)
    {
        if (Unsafe.IsNullRef(ref MemoryMarshal.GetReference(s))) return string.Empty;
        if (s.IsEmpty) return string.Empty;

        var bufferSize = Utilities.GetMaxSizeForStackAlloc(s.Length);

        Span<char> result = stackalloc char[bufferSize];
        s.ToLower(result, CultureInfo.InvariantCulture);

        var pos = 0;
        if (s.IndexOfAny(Constants.Underscore, Constants.Space, Constants.Dot) == -1)
        {
            result[0] = char.ToUpperInvariant(s[0]);
            pos = s.Length;
            goto @return;
        }

        ToPascalCaseFast(ref result, s.Length, out pos);

        @return:
        return result.Slice(0, pos).ToString();
    }

    // TODO: Сan instead of inserting one each character, insert it in blocks
    private static unsafe void ToPascalCaseFast(ref Span<char> result, int length, out int pos)
    {
        ref var item = ref MemoryMarshal.GetReference(result);
        var capitalize = true;
        pos = 0;

        var c = (char*)Unsafe.AsPointer(ref item);

        for (var i = 0; i < length; i++)
        {
            if (c->Equals(Constants.Underscore) || c->Equals(Constants.Space) || c->Equals(Constants.Dot))
            {
                capitalize = true;
                goto Next;
            }

            if (capitalize)
            {
                result[pos++] = char.ToUpperInvariant(*c);
                capitalize = false;
            }
            else
            {
                result[pos++] = *c;
            }

        Next:
            c++;
        }
    }
}
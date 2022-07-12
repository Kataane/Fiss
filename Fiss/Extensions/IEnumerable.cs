namespace Fiss.Extensions;

public static class IEnumerableExtensions
{
    public static IEnumerable<TResult> SelectWhere<TSource, TResult>(
        this IEnumerable<TSource> source,
        Func<TSource, TResult> selector,
        Func<TSource, bool> predicate)
    {
        return from item in source where predicate(item) select selector(item);
    }
}
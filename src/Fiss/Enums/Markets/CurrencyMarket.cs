namespace Fiss;

/// <summary>
///     Currency market of the trading system. Belongs to the following trading system <see cref="Engine.Currency" />.
/// </summary>
/// <remarks>
///     Do not convert to number. Only as the string path will work.
/// </remarks>
public enum CurrencyMarket
{
    /// <summary>
    ///     Bi-currency basket.
    /// </summary>
    Basket = 21,

    /// <summary>
    ///     Exchange trades with Central Bank of the Russian Federation.
    /// </summary>
    Selt = 10,

    /// <summary>
    ///     Deliverable futures.
    /// </summary>
    Futures = 34,

    /// <summary>
    ///     Currency fixing.
    /// </summary>
    Index = 41,

    /// <summary>
    ///     OTC (over-the-counter).
    /// </summary>
    Otc = 45
}

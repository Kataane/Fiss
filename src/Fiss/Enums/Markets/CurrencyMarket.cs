namespace Fiss;

/// <summary>
///     Currency market of the trading system
/// </summary>
public enum CurrencyMarket
{
    /// <summary>
    ///     Bi-currency basket
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.Currency" />.
    ///     </para>
    /// </summary>
    Basket = 21,

    /// <summary>
    ///     Exchange trades with Central Bank of the Russian Federation
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.Currency" />.
    ///     </para>
    /// </summary>
    Selt = 10,

    /// <summary>
    ///     Deliverable futures
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.Currency" />.
    ///     </para>
    /// </summary>
    Futures = 34,

    /// <summary>
    ///     Currency fixing
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.Currency" />.
    ///     </para>
    /// </summary>
    Index = 41,

    /// <summary>
    ///     OTC (over-the-counter)
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.Currency" />.
    ///     </para>
    /// </summary>
    Otc = 45
}
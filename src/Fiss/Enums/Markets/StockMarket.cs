namespace Fiss;

/// <summary>
///     Stock and Depository Market of the trading system
/// </summary>
public enum StockMarket
{
    /// <summary>
    ///     Stock market indices
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Index = 5,

    /// <summary>
    ///     Stock market
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Shares = 1,

    /// <summary>
    ///     Bond market
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Bonds = 2,

    /// <summary>
    ///     Negotiated deals mode
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Ndm = 4,

    /// <summary>
    ///     Over-The-Counter market
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Otc = 29,

    /// <summary>
    ///     Repo market with CCP
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Ccp = 27,

    /// <summary>
    ///     Deposits with CCP
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Deposit = 35,

    /// <summary>
    ///     Repo market
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Repo = 3,

    /// <summary>
    ///     Qualified investors market
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Qnv = 28,

    /// <summary>
    ///     Multi-currency market of mixed assets
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Mamc = 36,

    /// <summary>
    ///     Foreign securities market
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    ForeignShares = 47,

    /// <summary>
    ///     Foreign securities NDM market
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    ForeignNdm = 49,

    /// <summary>
    ///     MOEX Board
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Stock" />.
    ///     </para>
    /// </summary>
    Moex
}
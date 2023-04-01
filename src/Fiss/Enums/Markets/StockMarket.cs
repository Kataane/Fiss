namespace Fiss;

/// <summary>
///     Stock and Depository Market of the trading system. Belongs to the following trading system: <see cref="Engine.Stock" />.
/// </summary>
public enum StockMarket
{
    /// <summary>
    ///     Stock market indices.
    /// </summary>
    Index = 5,

    /// <summary>
    ///     Stock market.
    /// </summary>
    Shares = 1,

    /// <summary>
    ///     Bond market.
    /// </summary>
    Bonds = 2,

    /// <summary>
    ///     Negotiated deals mode.
    /// </summary>
    Ndm = 4,

    /// <summary>
    ///     Over-The-Counter market.
    /// </summary>
    Otc = 29,

    /// <summary>
    ///     Repo market with CCP.
    /// </summary>
    Ccp = 27,

    /// <summary>
    ///     Deposits with CCP.
    /// </summary>
    Deposit = 35,

    /// <summary>
    ///     Repo market.
    /// </summary>
    Repo = 3,

    /// <summary>
    ///     Qualified investors market.
    /// </summary>
    Qnv = 28,

    /// <summary>
    ///     Multi-currency market of mixed assets.
    /// </summary>
    Mamc = 36,

    /// <summary>
    ///     Foreign securities market.
    /// </summary>
    ForeignShares = 47,

    /// <summary>
    ///     Foreign securities NDM market.
    /// </summary>
    ForeignNdm = 49,

    /// <summary>
    ///     MOEX Board.
    /// </summary>
    MoexBoard
}

namespace Fiss;

/// <summary>
///     Securities groups
/// </summary>
public enum SecurityGroup
{
    /// <summary>
    ///     Indices
    /// </summary>
    StockIndex = 12,

    /// <summary>
    ///     Stocks
    /// </summary>
    StockShares = 4,

    /// <summary>
    ///     Bonds
    /// </summary>
    StockBonds = 3,

    /// <summary>
    ///     Currency
    /// </summary>
    CurrencySelt = 9,

    /// <summary>
    ///     Futures
    /// </summary>
    FuturesForts = 10,

    /// <summary>
    ///     Options
    /// </summary>
    FuturesOptions = 26,

    /// <summary>
    ///     Depositary receipts
    /// </summary>
    StockDr = 18,

    /// <summary>
    ///     Foreign issuers shares
    /// </summary>
    StockForeignShares = 33,

    /// <summary>
    ///     Eurobonds
    /// </summary>
    StockEurobond = 6,

    /// <summary>
    ///     Investment shares
    /// </summary>
    StockPpif = 5,

    /// <summary>
    ///     Exchange traded funds
    /// </summary>
    StockEtf = 20,

    /// <summary>
    ///     Precious metal
    /// </summary>
    CurrencyMetal = 24,

    /// <summary>
    ///     Qualified investors
    /// </summary>
    StockQnv = 21,

    /// <summary>
    ///     General collateral certificates
    /// </summary>
    StockGcc = 27,

    /// <summary>
    ///     Deposit CCP
    /// </summary>
    StockDeposit = 29,

    /// <summary>
    ///     Bi-currency basket
    /// </summary>
    CurrencyBasket = 17,

    /// <summary>
    ///     Currency futures
    /// </summary>
    CurrencyFutures = 28,

    /// <summary>
    ///     Currency fixings
    /// </summary>
    CurrencyIndices = 31,

    /// <summary>
    ///     Commodity assets
    /// </summary>
    AgroCommodities = 40,

    /// <summary>
    ///     Mortgage note
    /// </summary>
    StockMortgage = 22
}
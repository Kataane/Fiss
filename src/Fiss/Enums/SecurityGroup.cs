namespace Fiss;

/// <summary>
///     Securities groups
/// </summary>
public enum SecurityGroup : byte
{
    /// <summary>
    ///     Bonds
    /// </summary>
    StockBonds = 3,

    /// <summary>
    ///     Stocks
    /// </summary>
    StockShares = 4,

    /// <summary>
    ///     Investment shares
    /// </summary>
    StockPpif = 5,

    /// <summary>
    ///     Eurobonds
    /// </summary>
    StockEurobond = 6,

    /// <summary>
    ///     Currency
    /// </summary>
    CurrencySelt = 9,

    /// <summary>
    ///     Futures
    /// </summary>
    FuturesForts = 10,

    /// <summary>
    ///     Indices
    /// </summary>
    StockIndex = 12,

    /// <summary>
    ///     Depositary receipts
    /// </summary>
    StockDr = 18,

    /// <summary>
    ///     Exchange traded funds
    /// </summary>
    StockEtf = 20,

    /// <summary>
    ///     Qualified investors
    /// </summary>
    StockQnv = 21,

    /// <summary>
    ///     Mortgage note
    /// </summary>
    StockMortgage = 22,

    /// <summary>
    ///     Precious metal
    /// </summary>
    CurrencyMetal = 24,

    /// <summary>
    ///     Options
    /// </summary>
    FuturesOptions = 26,

    /// <summary>
    ///     General collateral certificates
    /// </summary>
    StockGcc = 27,

    /// <summary>
    ///     Currency futures
    /// </summary>
    CurrencyFutures = 28,

    /// <summary>
    ///     Deposit CCP
    /// </summary>
    StockDeposit = 29,

    /// <summary>
    ///     Currency fixings
    /// </summary>
    CurrencyIndices = 31,

    /// <summary>
    ///     Foreign issuers shares
    /// </summary>
    StockForeignShares = 33,
}
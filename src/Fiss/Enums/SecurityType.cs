namespace Fiss;

/// <summary>
///     Securities groups
/// </summary>
public enum SecurityType : ushort
{
    /// <summary>
    ///     Preferred stock
    /// </summary>
    PreferredShare = 1,

    /// <summary>
    ///     Bond
    /// </summary>
    CorporateBond = 2,

    /// <summary>
    ///     Common stock
    /// </summary>
    CommonShare = 3,

    /// <summary>
    ///     Central Bank bond
    /// </summary>
    CbBond = 4,

    /// <summary>
    ///     Currency
    /// </summary>
    Currency = 5,

    /// <summary>
    ///     Futures
    /// </summary>
    Futures = 6,

    /// <summary>
    ///     Public Investment Unit share
    /// </summary>
    PublicPpif = 7,

    /// <summary>
    ///     Interval Investment Unit share
    /// </summary>
    IntervalPpif = 8,

    /// <summary>
    ///     Private Investment Unit share
    /// </summary>
    PrivatePpif = 9,

    /// <summary>
    ///     Eurobond
    /// </summary>
    StateBond = 10,

    /// <summary>
    ///     Subfederal bond
    /// </summary>
    SubfederalBond = 41,

    /// <summary>
    ///     IFI bond
    /// </summary>
    IfiBond = 42,

    /// <summary>
    ///     Exchange bond
    /// </summary>
    ExchangeBond = 43,

    /// <summary>
    ///     Stock index
    /// </summary>
    StockIndex = 44,

    /// <summary>
    ///     Municipal bond
    /// </summary>
    MunicipalBond = 45,

    /// <summary>
    ///     Depositary Receipt
    /// </summary>
    DepositaryReceipt = 51,

    /// <summary>
    ///     Option
    /// </summary>
    Option = 52,

    /// <summary>
    ///     RTS index
    /// </summary>
    RtsIndex = 53,

    /// <summary>
    ///     Government bonds
    /// </summary>
    OfzBond = 54,

    /// <summary>
    ///     ETF
    /// </summary>
    EtfPpif = 55,

    /// <summary>
    ///     Mortgage note
    /// </summary>
    StockMortgage = 57,

    /// <summary>
    ///     Gold metal
    /// </summary>
    GoldMetal = 58,

    /// <summary>
    ///     Silver metal
    /// </summary>
    SilverMetal = 59,

    /// <summary>
    ///     Eurobonds
    /// </summary>
    EuroBond = 60,

    /// <summary>
    ///     Currency futures
    /// </summary>
    CurrencyFutures = 62,

    /// <summary>
    ///     Deposit CCP
    /// </summary>
    StockDeposit = 63,

    /// <summary>
    ///     Currency fixing
    /// </summary>
    CurrencyFixing = 73,

    /// <summary>
    ///     Exchange Investment Unit share
    /// </summary>
    ExchangePpif = 74,

    /// <summary>
    ///     Currency fixing
    /// </summary>
    CurrencyIndex = 75,

    /// <summary>
    ///     Weighted Average Rate
    /// </summary>
    CurrencyWap = 76,

    /// <summary>
    ///     Non-exchange commercial bond
    /// </summary>
    NonExchangeBond = 78,

    /// <summary>
    ///     Equities index
    /// </summary>
    StockIndexEq = 84,

    /// <summary>
    ///     Bonds index
    /// </summary>
    StockIndexFi = 85,

    /// <summary>
    ///     Composite index
    /// </summary>
    StockIndexMx = 86,

    /// <summary>
    ///     Equities iNAV
    /// </summary>
    StockIndexIe = 87,

    /// <summary>
    ///     Bonds iNAV
    /// </summary>
    StockIndexIf = 88,

    /// <summary>
    ///     Commodity Indicator
    /// </summary>
    StockIndexCi = 89,

    /// <summary>
    ///     Mixed iNAV
    /// </summary>
    StockIndexIm = 90,

    /// <summary>
    ///     NAMEX Index
    /// </summary>
    StockIndexNamex = 1030,

    /// <summary>
    ///     Option on shares
    /// </summary>
    OptionOnShares = 1031,

    /// <summary>
    ///     RUSFAR
    /// </summary>
    StockIndexRusfar = 1034,

    /// <summary>
    ///     Price fixing
    /// </summary>
    StockIndexPf = 1155,
}
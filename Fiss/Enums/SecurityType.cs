namespace Fiss.Enums;

/// <summary>
///     Securities types
/// </summary>
public enum SecurityType
{
    /// <summary>
    ///     Preferred stock
    /// </summary>
    PreferredShare,

    /// <summary>
    ///     Bond
    /// </summary>
    CorporateBond,

    /// <summary>
    ///     Common stock
    /// </summary>
    CommonShare,

    /// <summary>
    ///     Central Bank bond
    /// </summary>
    CbBond,

    /// <summary>
    ///     Currency
    /// </summary>
    Currency,

    /// <summary>
    ///     Futures
    /// </summary>
    Futures,

    /// <summary>
    ///     Public Investment Unit share
    /// </summary>
    PublicPpif,

    /// <summary>
    ///     Interval Investment Unit share
    /// </summary>
    IntervalPpif,

    /// <summary>
    ///     Private Investment Unit share
    /// </summary>
    PrivatePpif,

    /// <summary>
    ///     Eurobond
    /// </summary>
    StateBond,

    /// <summary>
    ///     Subfederal bond
    /// </summary>
    SubfederalBond = 41,

    /// <summary>
    ///     IFI bond
    /// </summary>
    IfiBond,

    /// <summary>
    ///     Exchange bond
    /// </summary>
    ExchangeBond,

    /// <summary>
    ///     Stock index
    /// </summary>
    StockIndex,

    /// <summary>
    ///     Municipal bond
    /// </summary>
    MunicipalBond,

    /// <summary>
    ///     Government bond index
    /// </summary>
    StateIndex,

    /// <summary>
    ///     Commodity futures (NAMEX)
    /// </summary>
    CommodityFutures = 48,

    /// <summary>
    ///     Commodity intervention
    /// </summary>
    CommodityIntervention,

    /// <summary>
    ///     Bi-currency basket
    /// </summary>
    CurrencyBasket,

    /// <summary>
    ///     Depositary Receipt
    /// </summary>
    DepositaryReceipt,

    /// <summary>
    ///     Option
    /// </summary>
    Option,

    /// <summary>
    ///     RTS index
    /// </summary>
    RtsIndex,

    /// <summary>
    ///     Government bonds
    /// </summary>
    OfzBond,

    /// <summary>
    ///     ETF
    /// </summary>
    EtfPpif,

    /// <summary>
    ///     Mortgage note
    /// </summary>
    StockMortgage = 57,

    /// <summary>
    ///     Gold metal
    /// </summary>
    GoldMetal,

    /// <summary>
    ///     Silver metal
    /// </summary>
    SilverMetal,

    /// <summary>
    ///     Eurobonds
    /// </summary>
    EuroBond,

    /// <summary>
    ///     Currency futures
    /// </summary>
    CurrencyFutures = 62,

    /// <summary>
    ///     Deposit CCP
    /// </summary>
    StockDeposit,

    /// <summary>
    ///     Currency fixing
    /// </summary>
    CurrencyFixing = 73,

    /// <summary>
    ///     Exchange Investment Unit share
    /// </summary>
    ExchangePpif,

    /// <summary>
    ///     Currency fixing
    /// </summary>
    CurrencyIndex,

    /// <summary>
    ///     Weighted Average Rate
    /// </summary>
    CurrencyWap,

    /// <summary>
    ///     Sugar
    /// </summary>
    AgroSugar,

    /// <summary>
    ///     Non-exchange commercial bond
    /// </summary>
    NonExchangeBond,

    /// <summary>
    ///     Credit
    /// </summary>
    StockCredit = 81,

    /// <summary>
    ///     REPO Basket
    /// </summary>
    StockRepoBasket = 83,

    /// <summary>
    ///     Equities index
    /// </summary>
    StockIndexEq,

    /// <summary>
    ///     Bonds index
    /// </summary>
    StockIndexFi,

    /// <summary>
    ///     Composite index
    /// </summary>
    StockIndexMx,

    /// <summary>
    ///     Equities iNAV
    /// </summary>
    StockIndexIe,

    /// <summary>
    ///     Bonds iNAV
    /// </summary>
    StockIndexIf,

    /// <summary>
    ///     Commodity Indicator
    /// </summary>
    StockIndexCi,

    /// <summary>
    ///     Mixed iNAV
    /// </summary>
    StockIndexIm,

    /// <summary>
    ///     NAMEX Index
    /// </summary>
    StockIndexNamex = 1030,

    /// <summary>
    ///     Option on shares
    /// </summary>
    OptionOnShares,

    /// <summary>
    ///     RUSFAR
    /// </summary>
    StockIndexRusfar = 1034,

    /// <summary>
    ///     Price fixing
    /// </summary>
    StockIndexPf = 1155
}
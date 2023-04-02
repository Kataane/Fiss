namespace Fiss;

/// <summary>
///     Collections of securities included in the group of securities
/// </summary>
public enum SecurityCollection : ushort
{
    /// <summary>
    ///     All equities
    /// </summary>
    StockSharesAll = 3,

    /// <summary>
    ///     All
    /// </summary>
    StockBondsAll = 7,

    /// <summary>
    ///     All funds
    /// </summary>
    StockPpifAll = 59,

    /// <summary>
    ///     All eurobonds
    /// </summary>
    StockEurobondAll = 60,

    /// <summary>
    ///     All indices
    /// </summary>
    StockIndexAll = 72,

    /// <summary>
    ///     REPO rate indicators
    /// </summary>
    StockIndexRepo = 115,

    /// <summary>
    ///     Depositary receipts
    /// </summary>
    StockDrAll = 130,

    /// <summary>
    ///     Foreign funds shares
    /// </summary>
    StockEtfAll = 151,

    /// <summary>
    ///     All qualified investors
    /// </summary>
    StockQnvAll = 152,

    /// <summary>
    ///     Level 1
    /// </summary>
    StockSharesOne = 160,

    /// <summary>
    ///     Level 2
    /// </summary>
    StockSharesTwo = 161,

    /// <summary>
    ///     Level 3
    /// </summary>
    StockSharesThree = 162,

    /// <summary>
    ///     All Level 1
    /// </summary>
    StockBondsOne = 163,

    /// <summary>
    ///     All Level 2
    /// </summary>
    StockBondsTwo = 164,

    /// <summary>
    ///     All Level 3
    /// </summary>
    StockBondsThree = 165,

    /// <summary>
    ///     Level 1
    /// </summary>
    StockPpifOne = 166,

    /// <summary>
    ///     Level 2
    /// </summary>
    StockPpifTwo = 167,

    /// <summary>
    ///     Level 3
    /// </summary>
    StockPpifThree = 168,

    /// <summary>
    ///     All currencies SWAP
    /// </summary>
    CurrencySeltAllSwap = 170,

    /// <summary>
    ///     Other currencies SPOT
    /// </summary>
    CurrencySeltOtherSpot = 171,

    /// <summary>
    ///     EUR/RUB SPOT
    /// </summary>
    CurrencySeltEurSpot = 172,

    /// <summary>
    ///     USD/RUB SPOT
    /// </summary>
    CurrencySeltUsdSpot = 173,

    /// <summary>
    ///     USD/RUB SWAP
    /// </summary>
    CurrencySeltUsdSwap = 174,

    /// <summary>
    ///     Other currencies SWAP
    /// </summary>
    CurrencySeltOtherSwap = 175,

    /// <summary>
    ///     CNY/RUB SWAP
    /// </summary>
    CurrencySeltCnySwap = 176,

    /// <summary>
    ///     All currencies SPOT
    /// </summary>
    CurrencySeltAllSpot = 177,

    /// <summary>
    ///     EUR/USD SPOT
    /// </summary>
    CurrencySeltEurusdSpot = 178,

    /// <summary>
    ///     EUR/RUB SWAP
    /// </summary>
    CurrencySeltEurSwap = 179,

    /// <summary>
    ///     EUR/USD SWAP
    /// </summary>
    CurrencySeltEurusdSwap = 180,

    /// <summary>
    ///     CNY/RUB SPOT
    /// </summary>
    CurrencySeltCnySpot = 181,

    /// <summary>
    ///     Level 2
    /// </summary>
    StockEurobondTwo = 182,

    /// <summary>
    ///     Level 3
    /// </summary>
    StockEurobondThree = 183,

    /// <summary>
    ///     Level 1
    /// </summary>
    StockEurobondOne = 184,

    /// <summary>
    ///     Exchange Level 1
    /// </summary>
    StockExchangeCorpOne = 185,

    /// <summary>
    ///     Government all
    /// </summary>
    StockBondsOfzAll = 186,

    /// <summary>
    ///     Foreign Issuers Level 2
    /// </summary>
    StockBondsIfiTwo = 187,

    /// <summary>
    ///     Corporate Level 3
    /// </summary>
    StockBondsCorpThree = 188,

    /// <summary>
    ///     Corporate all
    /// </summary>
    StockBondsCorpAll = 189,

    /// <summary>
    ///     Exchange Level 3
    /// </summary>
    StockBondsExchangeThree = 190,

    /// <summary>
    ///     Municipal Level 2
    /// </summary>
    StockBondsMunicipalTwo = 191,

    /// <summary>
    ///     Regional Level 3
    /// </summary>
    StockBondsSubfederalThree = 192,

    /// <summary>
    ///     Central Bank all
    /// </summary>
    StockBondsCbAll = 193,

    /// <summary>
    ///     Corporate Level 2
    /// </summary>
    StockBondsCorpTwo = 194,

    /// <summary>
    ///     Exchange Level 2
    /// </summary>
    StockBondsExchangeTwo = 195,

    /// <summary>
    ///     Foreign Issuers Level 3
    /// </summary>
    StockBondsIfiThree = 196,

    /// <summary>
    ///     Foreign Issuers all
    /// </summary>
    StockBondsIfiAll = 197,

    /// <summary>
    ///     Regional all
    /// </summary>
    StockBondsSubfederalAll = 198,

    /// <summary>
    ///     Foreign Issuers Level 1
    /// </summary>
    StockBondsIfiOne = 199,

    /// <summary>
    ///     Exchange all
    /// </summary>
    StockBondsExchangeAll = 200,

    /// <summary>
    ///     Municipal Level 1
    /// </summary>
    StockBondsMunicipalOne = 201,

    /// <summary>
    ///     Corporate Level 1
    /// </summary>
    StockBondsCorpOne = 202,

    /// <summary>
    ///     Municipal Level 3
    /// </summary>
    StockBondsMunicipalThree = 203,

    /// <summary>
    ///     Regional Level 2
    /// </summary>
    StockBondsSubfederalTwo = 204,

    /// <summary>
    ///     Municipal all
    /// </summary>
    StockBondsMunicipalAll = 205,

    /// <summary>
    ///     Regional Level 1
    /// </summary>
    StockBondsSubfederalOne = 206,

    /// <summary>
    ///     Main Bond indices
    /// </summary>
    StockIndexBonds = 207,

    /// <summary>
    ///     Corporate Bond Index
    /// </summary>
    StockIndexBondsCorporate = 208,

    /// <summary>
    ///     Pension Indices
    /// </summary>
    StockIndexBondsRetiring = 209,

    /// <summary>
    ///     Sectoral indices
    /// </summary>
    StockIndexSharesSectoral = 210,

    /// <summary>
    ///     Thematic Indices
    /// </summary>
    StockIndexSharesThematic = 211,

    /// <summary>
    ///     Municipal Bond indices
    /// </summary>
    StockIndexBondsMunicipal = 212,

    /// <summary>
    ///     Main Equity indices
    /// </summary>
    StockIndexShares = 213,

    /// <summary>
    ///     Russian Government Bond Indices
    /// </summary>
    StockIndexBondsState = 214,

    /// <summary>
    ///     Russian Volatility Indices
    /// </summary>
    StockIndexVolatility = 215,

    /// <summary>
    ///     Gold
    /// </summary>
    CurrencyMetalGold = 216,

    /// <summary>
    ///     Silver
    /// </summary>
    CurrencyMetalSilver = 217,

    /// <summary>
    ///     All options
    /// </summary>
    FuturesOptionsAll = 218,

    /// <summary>
    ///     Commodity options
    /// </summary>
    FuturesOptionsCommodity = 219,

    /// <summary>
    ///     Currency options
    /// </summary>
    FuturesOptionsCurrency = 220,

    /// <summary>
    ///     Equity options
    /// </summary>
    FuturesOptionsShares = 221,

    /// <summary>
    ///     Index options
    /// </summary>
    FuturesOptionsIndex = 222,

    /// <summary>
    ///     Commodity futures
    /// </summary>
    FuturesFortsCommodity = 223,

    /// <summary>
    ///     Equity futures
    /// </summary>
    FuturesFortsShares = 224,

    /// <summary>
    ///     Currency futures
    /// </summary>
    FuturesFortsCurrency = 225,

    /// <summary>
    ///     Index futures
    /// </summary>
    FuturesFortsIndex = 226,

    /// <summary>
    ///     All futures
    /// </summary>
    FuturesFortsAll = 227,

    /// <summary>
    ///     Interest rate futures
    /// </summary>
    FuturesFortsInterest = 228,

    /// <summary>
    ///     Quotationlistsbond indices
    /// </summary>
    StockIndexQuotationlistBond = 229,

    /// <summary>
    ///     All general collateral certificates
    /// </summary>
    StockGccAll = 230,

    /// <summary>
    ///     Total return equity indices
    /// </summary>
    StockIndexTotalReturn = 249,

    /// <summary>
    ///     CNY/RUB delivery Futures
    /// </summary>
    CurrencyFuturesDeliveryCny = 250,

    /// <summary>
    ///     USD/RUB delivery Futures
    /// </summary>
    CurrencyFuturesDeliveryUsd = 252,

    /// <summary>
    ///     All currencies delivery Futures
    /// </summary>
    CurrencyFuturesDeliveryAll = 254,

    /// <summary>
    ///     EUR/RUB delivery Futures
    /// </summary>
    CurrencyFuturesDeliveryEur = 255,

    /// <summary>
    ///     Deposit CCP
    /// </summary>
    StockDepositAll = 258,

    /// <summary>
    ///     INAV
    /// </summary>
    StockIndexInav = 259,

    /// <summary>
    ///     OFZ futures
    /// </summary>
    FuturesFortsOfz = 260,

    /// <summary>
    ///     All currencies delivery SWAP
    /// </summary>
    CurrencyFuturesSwapAll = 286,

    /// <summary>
    ///     USD/RUB delivery SWAP
    /// </summary>
    CurrencyFuturesSwapUsd = 287,

    /// <summary>
    ///     EUR/RUB delivery SWAP
    /// </summary>
    CurrencyFuturesSwapEur = 288,

    /// <summary>
    ///     CNY/RUB delivery SWAP
    /// </summary>
    CurrencyFuturesSwapCny = 289,

    /// <summary>
    ///     Other currencies delivery SWAP
    /// </summary>
    CurrencyFuturesSwapOther = 292,

    /// <summary>
    ///     Other currencies delivery Futures
    /// </summary>
    CurrencyFuturesDeliveryOthers = 293,

    /// <summary>
    ///     Money market index
    /// </summary>
    StockIndexMmix = 295,

    /// <summary>
    ///     All currency fixings
    /// </summary>
    CurrencyIndicesAll = 297,

    /// <summary>
    ///     Foreign issuers shares
    /// </summary>
    StockForeignSharesAll = 301,

    /// <summary>
    ///     All commercial bonds
    /// </summary>
    OffboardBondsAll = 303,

    /// <summary>
    ///     SDFI indices
    /// </summary>
    StockIndexSdfi = 323,

    /// <summary>
    ///     Commodity Indices
    /// </summary>
    StockIndexCommodity = 324,

    /// <summary>
    ///     Custom indices
    /// </summary>
    StockIndexCustom = 327,

    /// <summary>
    ///     Eurobonds indices
    /// </summary>
    StockIndexEurobonds = 328,
}
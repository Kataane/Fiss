namespace Fiss;

/// <summary>
///     Type of trading mode groups
/// </summary>
public enum BoardGroup : ushort
{
    /// <summary>
    ///     REPO stocks - negotiated
    /// </summary>
    StockSharesRepo = 1,

    /// <summary>
    ///     REPO bonds - negotiated
    /// </summary>
    StockBondRepo = 2,

    /// <summary>
    ///     Dealer - Dealer REPO
    /// </summary>
    DealerDealer = 3,

    /// <summary>
    ///     T0: Main mode - order-driven
    /// </summary>
    StockShares = 6,

    /// <summary>
    ///     T0: Main mode - order-driven
    /// </summary>
    StockBonds = 7,

    /// <summary>
    ///     Neg. deals - negotiated
    /// </summary>
    StockNdm = 8,

    /// <summary>
    ///     Indices
    /// </summary>
    StockIndex = 9,

    /// <summary>
    ///     Main trading mode
    /// </summary>
    State = 10,

    /// <summary>
    ///     Non-system trades
    /// </summary>
    StateNdm = 11,

    /// <summary>
    ///     Government Securities indices
    /// </summary>
    StateIndex = 12,

    /// <summary>
    ///     System deals - order-driven
    /// </summary>
    Currency = 13,

    /// <summary>
    ///     Derivatives
    /// </summary>
    Futures = 15,

    /// <summary>
    ///     Commodity Futures (NAMEX)
    /// </summary>
    CommodityFutures = 20,

    /// <summary>
    ///     Odd lots - order-driven
    /// </summary>
    StockSharesSm = 21,

    /// <summary>
    ///     Grain sell interventions
    /// </summary>
    InterventionsGrain = 24,

    /// <summary>
    ///     Trades with Central counterpary - order-driven
    /// </summary>
    StockSharesCc = 30,

    /// <summary>
    ///     REPO CCP - negotiated
    /// </summary>
    StockRepoCc = 31,

    /// <summary>
    ///     Neg. deals CCP  - negotiated
    /// </summary>
    StockNdmCc = 32,

    /// <summary>
    ///     Options
    /// </summary>
    FuturesOptions = 35,

    /// <summary>
    ///     Standard - order-driven
    /// </summary>
    StockStandard = 36,

    /// <summary>
    ///     Standard: REPO - negotiated
    /// </summary>
    StockStandardRepo = 40,

    /// <summary>
    ///     Standard - negotiated
    /// </summary>
    StandardNdm = 41,

    /// <summary>
    ///     Dark pool - order-driven
    /// </summary>
    StockSharesDarkpool = 42,

    /// <summary>
    ///     Classica - order-driven
    /// </summary>
    StockClassica = 43,

    /// <summary>
    ///     Classica - negotiated
    /// </summary>
    StockClassicaNdm = 44,

    /// <summary>
    ///     Futures
    /// </summary>
    FuturesForts = 45,

    /// <summary>
    ///     Negotiated deals - negotiated
    /// </summary>
    CurrencyNdm = 46,

    /// <summary>
    ///     REPO CCP 1 day (RUB) - order-driven
    /// </summary>
    StockCcp = 50,

    /// <summary>
    ///     T+: Main mode - order-driven
    /// </summary>
    StockSharesTplus = 57,

    /// <summary>
    ///     T+: Main mode - order-driven
    /// </summary>
    StockBondsTplus = 58,

    /// <summary>
    ///     T+: Neg. deals CCP - negotiated
    /// </summary>
    StockNdmTplus = 59,

    /// <summary>
    ///     T0: for qualified investors - order-driven
    /// </summary>
    StockQnvMain = 60,

    /// <summary>
    ///     Neg. deals for qualified investors - negotiated
    /// </summary>
    StockQnvNdm = 61,

    /// <summary>
    ///     REPO: for qualified investors - negotiated
    /// </summary>
    StockQnvRepo = 62,

    /// <summary>
    ///     T+: for qualified investors - order-driven
    /// </summary>
    StockQnvTplus = 63,

    /// <summary>
    ///     Neg. deals CCP: for qualified investors - negotiated
    /// </summary>
    StockQnvNdmTplus = 64,

    /// <summary>
    ///     REPO CCP (RUB) - negotiated
    /// </summary>
    StockCcpNdm = 65,

    /// <summary>
    ///     T0: Main mode (Eurobonds) - order-driven
    /// </summary>
    StockBondsEuro = 67,

    /// <summary>
    ///     T+: Main mode (ETC) - order-driven
    /// </summary>
    StockEtcTplus = 68,

    /// <summary>
    ///     T0: Main mode (ETC) - order-driven
    /// </summary>
    StockEtc = 69,

    /// <summary>
    ///     Auction CBR - negotiated
    /// </summary>
    CurrencySeltCbr = 70,

    /// <summary>
    ///     Reporting OTC trades (06-67/pz-n)
    /// </summary>
    StockOtc = 71,

    /// <summary>
    ///     MOEX Board
    /// </summary>
    StockMoexboard = 72,

    /// <summary>
    ///     T+: Neg. deals CCP (USD) - negotiated
    /// </summary>
    StockNdmTplusUsd = 73,

    /// <summary>
    ///     Neg. deals (USD) - negotiated
    /// </summary>
    StockNdmUsd = 74,

    /// <summary>
    ///     REPO CCP 7 day (RUB) - order-driven
    /// </summary>
    StockCcpW = 76,

    /// <summary>
    ///     Dark pool - order-driven
    /// </summary>
    StockBondsDarkpools = 77,

    /// <summary>
    ///     REPO CCP 7 days (USD) - order-driven
    /// </summary>
    StockCcpWUsd = 78,

    /// <summary>
    ///     REPO CCP 7 days (EUR) - order-driven
    /// </summary>
    StockCcpWEur = 79,

    /// <summary>
    ///     REPO CCP GCC 14 days - order-driven
    /// </summary>
    StockGcc2w = 80,

    /// <summary>
    ///     REPO CCP GCC 2 months - order-driven
    /// </summary>
    StockGcc2m = 81,

    /// <summary>
    ///     REPO CCP GCC - negotiated
    /// </summary>
    StockGccNdm = 82,

    /// <summary>
    ///     REPO CCP GCC 7 days - order-driven
    /// </summary>
    StockGccW = 83,

    /// <summary>
    ///     REPO CCP GCC 1 month - order-driven
    /// </summary>
    StockGccM = 84,

    /// <summary>
    ///     REPO CCP GCC 3 months - order-driven
    /// </summary>
    StockGcc3m = 85,

    /// <summary>
    ///     REPO CCP GCC 1 day - order-driven
    /// </summary>
    StockGccD = 86,

    /// <summary>
    ///     T+: for qualified investors (USD) - order-driven
    /// </summary>
    StockQnvTplusUsd = 87,

    /// <summary>
    ///     System futures - order-driven
    /// </summary>
    CurrencyFutures = 88,

    /// <summary>
    ///     Negotiated futures - negotiated
    /// </summary>
    CurrencyFuturesNdm = 89,

    /// <summary>
    ///     Inter-dealer REPO (EUR) - negotiated
    /// </summary>
    StockRepoInterdealerEur = 90,

    /// <summary>
    ///     REPO CCP (USD) - negotiated
    /// </summary>
    StockCcpNdmUsd = 91,

    /// <summary>
    ///     REPO CCP 1 day (USD) - order-driven
    /// </summary>
    StockCcpDUsd = 92,

    /// <summary>
    ///     REPO CCP 1 day (EUR) - order-driven
    /// </summary>
    StockCcpDEur = 93,

    /// <summary>
    ///     Inter-dealer REPO (USD) - negotiated
    /// </summary>
    StockRepoInterdealerUsd = 94,

    /// <summary>
    ///     Inter-dealer REPO (RUB) - negotiated
    /// </summary>
    StockRepoInterdealerRub = 95,

    /// <summary>
    ///     REPO CCP (EUR) - negotiated
    /// </summary>
    StockCcpNdmEur = 96,

    /// <summary>
    ///     Deposit CCP - order-driven
    /// </summary>
    StockDepositOrder = 97,

    /// <summary>
    ///     Deposit CCP - negotiated
    /// </summary>
    StockDepositOffOrder = 98,

    /// <summary>
    ///     T0: ETF (USD) - order-driven
    /// </summary>
    StockEtfUsd = 99,

    /// <summary>
    ///     System fixing - order-driven
    /// </summary>
    CurrencyFixing = 100,

    /// <summary>
    ///     Negotiated fixing - negotiated
    /// </summary>
    CurrencyFixingNdm = 101,

    /// <summary>
    ///     REPO CCP GCC 1 year - order-driven
    /// </summary>
    StockGcc1y = 102,

    /// <summary>
    ///     REPO CCP GCC 6 months - order-driven
    /// </summary>
    StockGcc6m = 103,

    /// <summary>
    ///     INAV
    /// </summary>
    StockIndexInav = 104,

    /// <summary>
    ///     Delivery for FC
    /// </summary>
    StockBondsSettle = 105,

    /// <summary>
    ///     Neg. deals (nonRUB) - negotiated
    /// </summary>
    StockNdmCurrency = 106,

    /// <summary>
    ///     Neg. deals: Primary distribution - negotiated
    /// </summary>
    StockNdmIssuance = 107,

    /// <summary>
    ///     Neg. deals: Buyback - negotiated
    /// </summary>
    StockNdmBuyback = 108,

    /// <summary>
    ///     Deposit CCP (USD) - negotiated
    /// </summary>
    StockDepositOffOrderUsd = 109,

    /// <summary>
    ///     Deposit CCP (USD) - order-driven
    /// </summary>
    StockDepositOrderUsd = 110,

    /// <summary>
    ///     REPO CCP GCC 1 day (USD) - order-driven
    /// </summary>
    StockGccDUsd = 111,

    /// <summary>
    ///     REPO CCP GCC 7 days (USD) - order-driven
    /// </summary>
    StockGccWUsd = 112,

    /// <summary>
    ///     REPO CCP GCC 14 days (USD) - order-driven
    /// </summary>
    StockGcc2wUsd = 113,

    /// <summary>
    ///     REPO CCP GCC 1 month (USD) - order-driven
    /// </summary>
    StockGccMUsd = 114,

    /// <summary>
    ///     REPO CCP GCC 2 months (USD) - order-driven
    /// </summary>
    StockGcc2mUsd = 115,

    /// <summary>
    ///     REPO CCP GCC 3 months (USD) - order-driven
    /// </summary>
    StockGcc3mUsd = 116,

    /// <summary>
    ///     REPO CCP GCC 6 months (USD) - order-driven
    /// </summary>
    StockGcc6mUsd = 117,

    /// <summary>
    ///     REPO CCP GCC 1 year (USD) - order-driven
    /// </summary>
    StockGcc1yUsd = 118,

    /// <summary>
    ///     REPO CCP GCC (USD) - negotiated
    /// </summary>
    StockGccNdmUsd = 119,

    /// <summary>
    ///     Order-driven CCP deals - order-driven
    /// </summary>
    StockMamcLiq = 120,

    /// <summary>
    ///     Neg. deals: Buyback EUR - negotiated
    /// </summary>
    StockNdmBuybackEur = 121,

    /// <summary>
    ///     Buyback - order-driven
    /// </summary>
    StockBondsBuyback = 122,

    /// <summary>
    ///     Primary distribution - order-driven
    /// </summary>
    StockBondsDistribution = 123,

    /// <summary>
    ///     Neg. deals: Buyback USD - negotiated
    /// </summary>
    StockNdmBuybackUsd = 124,

    /// <summary>
    ///     Delivery for FC
    /// </summary>
    StockSharesSettle = 125,

    /// <summary>
    ///     Neg. deals: Anonymous - negotiated
    /// </summary>
    StockNdmAnonymous = 126,

    /// <summary>
    ///     REPO CCP GCC 1 day (EUR) - order-driven
    /// </summary>
    StockGccDEur = 127,

    /// <summary>
    ///     REPO CCP GCC 7 days (EUR) - order-driven
    /// </summary>
    StockGccWEur = 128,

    /// <summary>
    ///     REPO CCP GCC 14 days (EUR) - order-driven
    /// </summary>
    StockGcc2wEur = 129,

    /// <summary>
    ///     REPO CCP GCC 1 month (EUR) - order-driven
    /// </summary>
    StockGccMEur = 130,

    /// <summary>
    ///     REPO CCP GCC 2 months (EUR) - order-driven
    /// </summary>
    StockGcc2mEur = 131,

    /// <summary>
    ///     REPO CCP GCC 3 months (EUR) - order-driven
    /// </summary>
    StockGcc3mEur = 132,

    /// <summary>
    ///     REPO CCP GCC 6 months (EUR) - order-driven
    /// </summary>
    StockGcc6mEur = 133,

    /// <summary>
    ///     REPO CCP GCC 1 year (EUR) - order-driven
    /// </summary>
    StockGcc1yEur = 134,

    /// <summary>
    ///     REPO CCP GCC (EUR) - negotiated
    /// </summary>
    StockGccNdmEur = 135,

    /// <summary>
    ///     Deposit CCP (EUR) - negotiated
    /// </summary>
    StockDepositOffOrderEur = 136,

    /// <summary>
    ///     Deposit CCP (EUR) - order-driven
    /// </summary>
    StockDepositOrderEur = 137,

    /// <summary>
    ///     Futures IQS
    /// </summary>
    FuturesFortsiqs = 138,

    /// <summary>
    ///     Options IQS
    /// </summary>
    FuturesOptionsiqs = 139,

    /// <summary>
    ///     Settlement
    /// </summary>
    CurrencySeltSettle = 140,

    /// <summary>
    ///     OffBoard bonds
    /// </summary>
    OffboardBondAll = 141,

    /// <summary>
    ///     REPO CCP 1 month (RUB) - order-driven
    /// </summary>
    StockCcpM = 142,

    /// <summary>
    ///     REPO CCP 1 month (USD) - order-driven
    /// </summary>
    StockCcpMUsd = 143,

    /// <summary>
    ///     REPO CCP 1 month (EUR) - order-driven
    /// </summary>
    StockCcpMEur = 144,

    /// <summary>
    ///     REPO CCP 3 months (RUB) - order-driven
    /// </summary>
    StockCcp3m = 145,

    /// <summary>
    ///     REPO CCP 3 months (USD) - order-driven
    /// </summary>
    StockCcp3mUsd = 146,

    /// <summary>
    ///     REPO CCP 3 months (EUR) - order-driven
    /// </summary>
    StockCcp3mEur = 147,

    /// <summary>
    ///     REPO CCP Settle's Deals - order-driven
    /// </summary>
    StockCcpLiq = 148,

    /// <summary>
    ///     System WAP Deals - order-driven
    /// </summary>
    CurrencySeltWaps = 149,

    /// <summary>
    ///     Negotiated WAP Deals - negotiated
    /// </summary>
    CurrencySeltWapn = 150,

    /// <summary>
    ///     Non System Settle's Deals - order-driven
    /// </summary>
    CurrencySeltLicu = 151,

    /// <summary>
    ///     REPO CCP 1 day (CNY) - order-driven
    /// </summary>
    StockCcpDCny = 152,

    /// <summary>
    ///     REPO CCP (CNY) - negotiated
    /// </summary>
    StockCcpNdmCny = 153,

    /// <summary>
    ///     Money Market IndeX
    /// </summary>
    StockIndexMmix = 155,

    /// <summary>
    ///     T+: Main mode (USD) - order-driven
    /// </summary>
    StockSharesTplusUsd = 156,

    /// <summary>
    ///     T+: Main mode (EUR) - order-driven
    /// </summary>
    StockSharesTplusEur = 157,

    /// <summary>
    ///     T0 ETF: EUR - order-driven
    /// </summary>
    StockSharesEtfEur = 159,

    /// <summary>
    ///     Neg. deals (USD) - negotiated
    /// </summary>
    StockNdmEur = 160,

    /// <summary>
    ///     T+: Neg. deals CCP (EUR) - negotiated
    /// </summary>
    StockNdmTplusEur = 163,

    /// <summary>
    ///     Currency fixing
    /// </summary>
    CurrencyIndex = 165,

    /// <summary>
    ///     Dark pool: bonds USD - order-driven
    /// </summary>
    StockBondsDarkpoolsUsd = 167,

    /// <summary>
    ///     Auction with CCP overnight - order-driven
    /// </summary>
    StockCcpFkD = 169,

    /// <summary>
    ///     Auction with CCP 1 week - order-driven
    /// </summary>
    StockCcpFk2 = 171,

    /// <summary>
    ///     Auction with CCP 2 weeks - order-driven
    /// </summary>
    StockCcpFk2w = 173,

    /// <summary>
    ///     Auction with CCP 1 month - order-driven
    /// </summary>
    StockCcpFkM = 175,

    /// <summary>
    ///     Auction with CCP 2 months - order-driven
    /// </summary>
    StockCcpFk2m = 177,

    /// <summary>
    ///     Auction with CCP 3 months - order-driven
    /// </summary>
    StockCcpFk3m = 179,

    /// <summary>
    ///     Auction with CCP 6 months - order-driven
    /// </summary>
    StockCcpFk6 = 181,

    /// <summary>
    ///     Auction with CCP 1 year - order-driven
    /// </summary>
    StockCcpFk1y = 183,

    /// <summary>
    ///     Deposits with CCP ? Auction
    /// </summary>
    StockDepositCloseAuct = 185,

    /// <summary>
    ///     REPO CCP 9 months (RUB) - order-driven
    /// </summary>
    StockCcp9m = 187,

    /// <summary>
    ///     REPO CCP 9 months (USD) - order-driven
    /// </summary>
    StockCcp9mUsd = 189,

    /// <summary>
    ///     REPO CCP 9 months (EUR) - order-driven
    /// </summary>
    StockCcp9mEur = 191,

    /// <summary>
    ///     T+: Main mode (USD) - order-driven
    /// </summary>
    StockBondsTplusUsd = 193,

    /// <summary>
    ///     REPO-M - negotiated
    /// </summary>
    StockRepoInterdealerM = 201,

    /// <summary>
    ///     Neg. deals: Anonymous (USD)- negotiated
    /// </summary>
    StockNdmAnonymousUsd = 203,

    /// <summary>
    ///     Neg. deals: Anonymous  (EUR)- negotiated
    /// </summary>
    StockNdmAnonymousEur = 205,

    /// <summary>
    ///     T+: Bonds (EUR) - order-driven
    /// </summary>
    StockBondsTplusEur = 207,

    /// <summary>
    ///     Neg. deals CCP: bonds (EUR) - negotiated
    /// </summary>
    StockNdmCcpBondsEur = 209,

    /// <summary>
    ///     T+: Bonds inv. risk (CNY) - order-driven
    /// </summary>
    StockBondsTplusCny = 245,

    /// <summary>
    ///     Neg. deals: Inv. risk bonds (CNY) - negotiated
    /// </summary>
    StockNdmBondsCny = 247,

    /// <summary>
    ///     Neg. deals CCP: Inv. risk bonds (CNY) - negotiated
    /// </summary>
    StockNdmCcpBondsCny = 249,

    /// <summary>
    ///     Auction: targeted orders
    /// </summary>
    StockBondsAuctPact = 257,

    /// <summary>
    ///     OTC liquidity provider
    /// </summary>
    CurrencyOtcLiquidity = 261,

    /// <summary>
    ///     OTC full amount
    /// </summary>
    CurrencyOtcDarkpools = 263,

    /// <summary>
    ///     T+: FRGN stocks, DRs - order-driven
    /// </summary>
    StockForeignShares = 265,

    /// <summary>
    ///     NDM with CCP: FRGN stocks, DRs - negotiated
    /// </summary>
    StockForeignCcp = 267,

    /// <summary>
    ///     Neg. deals: FRGN stocks - negotiated
    /// </summary>
    StockForeignNdm = 269,

    /// <summary>
    ///     Agro: Sugar
    /// </summary>
    AgroSugarAll = 271,

    /// <summary>
    ///     Credits RUB - negotiated
    /// </summary>
    StockCreditRub = 275,

    /// <summary>
    ///     Credits USD - negotiated
    /// </summary>
    StockCreditUsd = 277,

    /// <summary>
    ///     Credits EUR - negotiated
    /// </summary>
    StockCreditEur = 279,

    /// <summary>
    ///     Auction with CCP 5 weeks - order-driven
    /// </summary>
    StockCcpFk5w = 281,

    /// <summary>
    ///     Neg. deals CCP: Bonds - negotiated
    /// </summary>
    StockNdmCcpBonds = 282,

    /// <summary>
    ///     Neg. deals CCP: Bonds (USD) - negotiated
    /// </summary>
    StockNdmCcpBondsUsd = 283,

    /// <summary>
    ///     Neg. deals: Bonds - negotiated
    /// </summary>
    StockNdmBonds = 284,

    /// <summary>
    ///     Neg. deals: Bonds (USD) - negotiated
    /// </summary>
    StockNdmBondsUsd = 285,

    /// <summary>
    ///     Neg. deals: Bonds (EUR) - negotiated
    /// </summary>
    StockNdmBondsEur = 286,

    /// <summary>
    ///     SDFI Indices
    /// </summary>
    StockIndexSdfi = 287,

    /// <summary>
    ///     Auction REPO with CCP overnight - order-driven
    /// </summary>
    StockCcpFrRepo1d = 288,

    /// <summary>
    ///     Auction REPO with CCP 1 week - order-driven
    /// </summary>
    StockCcpFrRepo1w = 289,

    /// <summary>
    ///     Auction REPO with CCP 1 month - order-driven
    /// </summary>
    StockCcpFrRepo1m = 290,

    /// <summary>
    ///     Auction REPO with CCP 3 months - order-driven
    /// </summary>
    StockCcpFrRepo3m = 291,

    /// <summary>
    ///     T+: FRGN stocks, DRs USD - order-driven
    /// </summary>
    StockForeignsharesTplusUsd = 292,

    /// <summary>
    ///     T+: NDM w/CCP: FRGN stck, DRs USD - negotiated
    /// </summary>
    StockForeignndmCcpUsd = 293,

    /// <summary>
    ///     Neg. deals: FRGN stocks USD - negotiated
    /// </summary>
    StockForeignndmUsd = 294,

    /// <summary>
    ///     Auction REPO with CCP 2 weeks - order-driven
    /// </summary>
    StockCcpFrRepo2w = 296,

    /// <summary>
    ///     Auction REPO with CCP 5 weeks - order-driven
    /// </summary>
    StockCcpFrRepo5w = 297,

    /// <summary>
    ///     OTC deals with CCP (USD) - order-driven
    /// </summary>
    OtcBondsTplusUsd = 1015,

    /// <summary>
    ///     OTC deals with CCP
    /// </summary>
    OtcNdmCcpRub = 1017,

    /// <summary>
    ///     OTC deals with CCP (USD)
    /// </summary>
    OtcNdmCcpUsd = 1019,

    /// <summary>
    ///     OTC deals with CCP - order-driven
    /// </summary>
    OtcBondsTplus = 1021,

    /// <summary>
    ///     NAMEX indices
    /// </summary>
    StockIndexNamex = 1028,

    /// <summary>
    ///     Agro: NAMEX Auctions
    /// </summary>
    AgroAuctionsAll = 1032,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Stocks, DRs - negotiated
    /// </summary>
    StockNonresndmSharesTplusRub = 1056,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Stocks, DRs (USD) - negotiated
    /// </summary>
    StockNonresndmSharesTplusUsd = 1058,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Stocks, DRs (EUR) - negotiated
    /// </summary>
    StockNonresndmSharesTplusEur = 1060,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Bonds - negotiated
    /// </summary>
    StockNonresndmBondsTplusRub = 1062,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Bonds (CNY) - negotiated
    /// </summary>
    StockNonresndmBondsTplusCny = 1064,

    /// <summary>
    ///     Neg. deals CCP Non-residents: Bonds (USD) - negotiated
    /// </summary>
    StockNonresndmBondsTplusUsd = 1066,

    /// <summary>
    ///     Neg. deals CCP: Non-residents: Bonds (EUR) - negotiated
    /// </summary>
    StockNonresndmBondsTplusEur = 1068,

    /// <summary>
    ///     REPO-M: Non-residents - negotiated
    /// </summary>
    StockNonresrepoInterdealerRub = 1071,

    /// <summary>
    ///     REPO-M: Non-residents (USD) - negotiated
    /// </summary>
    StockNonresrepoInterdealerUsd = 1073,

    /// <summary>
    ///     REPO-M: Non-residents (EUR) - negotiated
    /// </summary>
    StockNonresrepoInterdealerEur = 1075,

    /// <summary>
    ///     REPO-M: Non-residents (CNY) - negotiated
    /// </summary>
    StockNonresrepoInterdealerCny = 1077,

    /// <summary>
    ///     REPO CCP settle's Deals : Non-residents - order-driven
    /// </summary>
    StockNonresccpLiq = 1080,

    /// <summary>
    ///     Neg. CCP settle's Deals: Non-residents - order-driven
    /// </summary>
    StockNonresmamcLiq = 1082,

    /// <summary>
    ///     Agro: NAMEX Buy auctions
    /// </summary>
    AgroBuyauctionsAll = 1085,

    /// <summary>
    ///     REPO with CCP 7 day (CNY) - order-driven
    /// </summary>
    StockCcpWCny = 1116,

    /// <summary>
    ///     REPO with CCP 1 month (CNY) - order-driven
    /// </summary>
    StockCcp1mCny = 1118,

    /// <summary>
    ///     REPO CCP 3 months (CNY) - order-driven
    /// </summary>
    StockCcp3mCny = 1120,

    /// <summary>
    ///     REPO CCP GCC 1 day (CNY) - order-driven
    /// </summary>
    StockGccDCny = 1122,

    /// <summary>
    ///     REPO CCP GCC 7 days (CNY) - order-driven
    /// </summary>
    StockGccWCny = 1124,

    /// <summary>
    ///     REPO CCP GCC 14 days (CNY) - order-driven
    /// </summary>
    StockGcc2wCny = 1126,

    /// <summary>
    ///     REPO CCP GCC 1 month (CNY) - order-driven
    /// </summary>
    StockGcc1mCny = 1128,

    /// <summary>
    ///     REPO CCP GCC 2 months (CNY) - order-driven
    /// </summary>
    StockGcc2mCny = 1130,

    /// <summary>
    ///     REPO CCP GCC 3 months (CNY) - order-driven
    /// </summary>
    StockGcc3mCny = 1132,

    /// <summary>
    ///     REPO CCP GCC 6 months (CNY) - order-driven
    /// </summary>
    StockGcc6mCny = 1134,

    /// <summary>
    ///     REPO CCP GCC 9 months (CNY) - order-driven
    /// </summary>
    StockGcc9mCny = 1136,

    /// <summary>
    ///     REPO CCP GCC 1 year (CNY) - order-driven
    /// </summary>
    StockGcc1yCny = 1138,

    /// <summary>
    ///     REPO CCP GCC (CNY) - negotiated
    /// </summary>
    StockGccNdmCny = 1140,

    /// <summary>
    ///     Deposit CCP (CNY) - order-driven
    /// </summary>
    StockDepositOrderCny = 1142,

    /// <summary>
    ///     Deposit CCP (CNY) - negotiated
    /// </summary>
    StockDepositOffOrderCny = 1144,

    /// <summary>
    ///     Credits USD - negotiated
    /// </summary>
    StockCreditCny = 1146,

    /// <summary>
    ///     Price Fixing
    /// </summary>
    StockIndexPf = 1153,

    /// <summary>
    ///     REPO with CCP with GCP fl. 7d - order-driven (RUSFAR)
    /// </summary>
    StockGccFl1wRub = 1156,

    /// <summary>
    ///     REPO with CCP with GCP fl. 14d - order-driven (RUSFAR)
    /// </summary>
    StockGccFl2wRub = 1158,

    /// <summary>
    ///     REPO with CCP with GCP fl. 1m - order-driven (RUSFAR)
    /// </summary>
    StockGccFl1mRub = 1160,

    /// <summary>
    ///     REPO with CCP with GCP fl. 2m - order-driven (RUSFAR)
    /// </summary>
    StockGccFl2mRub = 1162,

    /// <summary>
    ///     REPO with CCP with GCP fl. 3m - order-driven (RUSFAR)
    /// </summary>
    StockGccFl3mRub = 1164,

    /// <summary>
    ///     REPO with CCP with GCP fl. 6m - order-driven (RUSFAR)
    /// </summary>
    StockGccFl6mRub = 1166,

    /// <summary>
    ///     REPO with CCP with GCP fl. 9m - order-driven (RUSFAR)
    /// </summary>
    StockGccFl9mRub = 1168,

    /// <summary>
    ///     REPO with CCP with GCP fl. 1y - order-driven (RUSFAR)
    /// </summary>
    StockGccFl1yRub = 1170,

    /// <summary>
    ///     REPO with CCP with GCP fl. 7d (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    StockGccFl1wCny = 1188,

    /// <summary>
    ///     REPO with CCP with GCP fl. 14d (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    StockGccFl2wCny = 1190,

    /// <summary>
    ///     REPO with CCP with GCP fl. 1m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    StockGccFl1mCny = 1192,

    /// <summary>
    ///     REPO with CCP with GCP fl. 2m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    StockGccFl2mCny = 1194,

    /// <summary>
    ///     REPO with CCP with GCP fl. 3m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    StockGccFl3mCny = 1196,

    /// <summary>
    ///     REPO with CCP with GCP fl. 6m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    StockGccFl6mCny = 1198,

    /// <summary>
    ///     REPO with CCP with GCP fl. 9m (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    StockGccFl9mCny = 1200,

    /// <summary>
    ///     REPO with CCP with GCP fl. 1y (CNY) - order-driven (RUSFARCNY)
    /// </summary>
    StockGccFl1yCny = 1202,

    /// <summary>
    ///     OTC deals with CCP (CNY)
    /// </summary>
    OtcNdmCcpCny = 1204,

    /// <summary>
    ///     T+: FRGN stocks, DRs CNY - order-driven
    /// </summary>
    StockForeignsharesTplusCny = 1206,

    /// <summary>
    ///     NDM w/CCP: i rsk stck FRGN CNY - negotiated
    /// </summary>
    StockForeignCcpCny = 1209,

    /// <summary>
    ///     Neg. deals: FRGN stocks CNY - negotiated
    /// </summary>
    StockForeignNdmCny = 1212,

    /// <summary>
    ///     T+: Main mode (CNY) - order-driven
    /// </summary>
    StockSharesTplusCny = 1215,

    /// <summary>
    ///     Neg. deals (CNY) - negotiated
    /// </summary>
    StockNdmCny = 1218,

    /// <summary>
    ///     T+: Neg. deals CCP (CNY) - negotiated
    /// </summary>
    StockNdmTplusCny = 1221,

    /// <summary>
    ///     T+: FRGN stocks, DRs HKD - order-driven
    /// </summary>
    StockForeignsharesTplusHkd = 1229,

    /// <summary>
    ///     NDM w/CCP: FRGN stck, DRs HKD - negotiated
    /// </summary>
    StockForeignCcpHkd = 1232,

    /// <summary>
    ///     Neg. deals: FRGN stocks HKD - negotiated
    /// </summary>
    StockForeignNdmHkd = 1235,

    /// <summary>
    ///     T+: Inv. funds (HKD) - order-driven
    /// </summary>
    StockSharesTplusHkd = 1238,

    /// <summary>
    ///     Neg. deals: Inv. funds HKD - negotiated
    /// </summary>
    StockNdmHkd = 1241,

    /// <summary>
    ///     NDM with CCP: Inv. funds (HKD) - negotiated
    /// </summary>
    StockNdmTplusHkd = 1244,

    /// <summary>
    ///     Auction w/reverse CCP 1 day - order-driven
    /// </summary>
    StockCcpR1d = 1247,

    /// <summary>
    ///     Auction w/reverse CCP 1 week - order-driven
    /// </summary>
    StockCcpR1w = 1249,

    /// <summary>
    ///     Auction w/reverse CCP 2 weeks - order-driven
    /// </summary>
    StockCcpR2w = 1251,

    /// <summary>
    ///     Auction w/reverse CCP 1 month - order-driven
    /// </summary>
    StockCcpR1m = 1253,

    /// <summary>
    ///     Auction w/reverse CCP 5 weeks - order-driven
    /// </summary>
    StockCcpR5w = 1255,
}